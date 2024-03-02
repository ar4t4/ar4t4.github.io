using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        string ConnectionString = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        protected void sendButton_Click(object sender, EventArgs e)
        {
            
            if (!IsValid) 
            {
                Response.Write("<script>alert('message is not valid ');</script>");
                return;
            }

            // !!! WARNING: Code below does not implement sanitization or prepared statements. !!!

            // Database connection and insertion
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Message (Email, Subject, Message,date) VALUES ('" + email.Text + "', '" + subject.Text + "', '" + message.Text + "','" + DateTime.Now+ "')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('message sent succesfully');</script>");
           

            }
        }

        
       
    }

}