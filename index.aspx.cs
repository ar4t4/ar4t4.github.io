using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    
    public partial class index : System.Web.UI.Page
    {
        string x, y, z;


        protected string StrBase64 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //aboutDescription = (HtmlGenericControl)this.FindControl("aboutDescription");
            LoadAboutContent();
            string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // Fetch the last ID from the database
                SqlCommand getLastIdCmd = new SqlCommand("SELECT MAX(Id) FROM image", con);
                int lastId = (int)getLastIdCmd.ExecuteScalar();

                // Now use the last ID to fetch the corresponding image
                SqlCommand cmd = new SqlCommand("imgid", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter()
                {
                    ParameterName = "@Id",
                    Value = lastId // Use the last ID retrieved from the database
                };
                cmd.Parameters.Add(paramId);

                // Fetch the image data
                byte[] bytes = (byte[])cmd.ExecuteScalar();

                // Convert the image data to a base64 string
                string strBase64 = Convert.ToBase64String(bytes);

                // Set the base64 string as the image source
                Image1.ImageUrl = "data:Image/png;base64," + strBase64;

                con.Close();

            }
            if (!IsPostBack)
            {

                //if (!string.IsNullOrEmpty(Request.QueryString["skill"]))
                //{
                //    // Get the skill value from the query string
                //    string skillValue = Request.QueryString["skill"];

                //    // Update the text of the label
                //    cf.Text = skillValue;
                //    x = cf.Text;
                //}


                //if (!string.IsNullOrEmpty(Request.QueryString["skill1"]))
                //{
                //    // Get the skill value from the query string
                //    string skillValue1 = Request.QueryString["skill1"];

                //    // Update the text of the label
                //    f1.Text = skillValue1;
                //}
                
                HttpCookie cookie1 = Request.Cookies["t1"];
                HttpCookie cookie = Request.Cookies["t2"];
                if (cookie != null)
                {
                    f1.Text = cookie.Value;
                    
                } 
                if (cookie1 != null)
                {
                    cf.Text = cookie1.Value;
                    
                }


                if (Session["t3"] != null)
                {
                    f2.Text = Session["t3"].ToString();
                }
                
                
            }

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
                string sql = "INSERT INTO Message (Email, Subject, Message,date) VALUES ('" + email.Text + "', '" + subject.Text + "', '" + message.Text + "','" + DateTime.Now + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script>alert('message sent succesfully');</script>");


            }
        }
        private void LoadAboutContent()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            string query = "SELECT About FROM About";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    Label aboutDescription = (Label)Page.FindControl("aboutDescription");
                    if (result != null)
                    {
                        aboutDescription.Text = result.ToString();
                        aboutDescription.Visible = true; // Make the label visible
                    }
                }
            }




        }
    }

}