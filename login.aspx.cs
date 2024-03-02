using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate the credentials against the database
            if (ValidateUser(username, password))
            {
                // Redirect to the home page or another page
                Session["username"] = username;
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                // Display an error message
                Response.Write("<script>alert('Invalid username or password');</script>");
            }
        }

       



    private bool ValidateUser(string username, string password)
    {
       
        string query = "SELECT COUNT(*) FROM login WHERE Username = @Username AND Password = @Password";

        using (SqlConnection connection = new SqlConnection(strcon))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                    int count =(int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
}