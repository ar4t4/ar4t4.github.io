using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }
        protected void BindGridView()
        {
            // Connection string to your database
            string connectionString = WebConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

            // Query to retrieve data from your database
            string query = "SELECT email, subject, message,date FROM message";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Bind the data to the GridView
                GridView1.DataSource = reader;
                GridView1.DataBind();

                reader.Close();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string idToDelete = GridView1.DataKeys[rowIndex].Value.ToString();

            // Delete the row from the database
            DeleteRowFromDatabase(idToDelete);

            // Rebind the GridView to reflect the changes
            BindGridView();
        }
        private void DeleteRowFromDatabase(string id)
        {
            // Connection string to your database
            string connectionString = WebConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

            // Query to delete the row from your database
            string query = "DELETE FROM message WHERE message= @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    
                    throw ex;
                }
            }
        }
        protected void ReplyButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            string email = row.Cells[0].Text; // Assuming email is in the third column (index 2)
            string url = "mailto:" + email;
            Response.Redirect(url);
        }


    }
}