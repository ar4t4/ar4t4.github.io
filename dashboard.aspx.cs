using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class dashboard : System.Web.UI.Page
    {
        string strcon = WebConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                label1.Text = "Login Success, Welcome " + Session["username"].ToString();
            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }

        protected void btnManageUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("showmessages.aspx");
        }

        protected void btnEditContent_Click(object sender, EventArgs e)
        {
            string aboutContent = RetrieveAboutContentFromDatabase();

            // Display the retrieved content in a TextBox for editing
            txtAboutContent.Text = aboutContent;

            // Show the editing section
            txtAboutContent.Visible = true;
            btnSaveAbout.Visible = true;


        }

        protected void btnViewStatistics_Click(object sender, EventArgs e)
        {

            Response.Redirect("skills.aspx");

        }

        protected void upbtn_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = upfile.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;
            try {

                if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                    || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
                {
                    Stream stream = postedFile.InputStream;
                    BinaryReader binaryReader = new BinaryReader(stream);
                    Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                    string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("uploadd", con);
                        cmd.CommandType = CommandType.StoredProcedure;



                        SqlParameter paramImageData = new SqlParameter()
                        {
                            ParameterName = "@ImageData",
                            Value = bytes
                        };
                        cmd.Parameters.Add(paramImageData);

                        SqlParameter paramNewId = new SqlParameter()
                        {
                            ParameterName = "@NewId",
                            Value = -1,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramNewId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        lbl2.Text = "Image Uploaded Successfully";
                        lbl2.Visible = true;

                        hyperlink.Visible = true;
                        hyperlink.NavigateUrl = "~/index.aspx?Id=" +
                            cmd.Parameters["@NewId"].Value.ToString();
                     
                    }
                }
                else
                {

                    hyperlink.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "')</script>");
            }

            }


        protected string RetrieveAboutContentFromDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            string aboutContent = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Define the SQL query to retrieve the "about" content
                    string query = "SELECT About FROM about";
        
            // Create and configure a SqlCommand object
            using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters if necessary (e.g., if you're filtering by ID)
                      //  command.Parameters.AddWithValue("@Id", /*Provide the ID of the about content you want to retrieve*/);

                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the scalar result
                        aboutContent = command.ExecuteScalar() as string;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., log the error, display an error message)
                // For simplicity, this example just throws the exception again
                throw ex;
            }

            return aboutContent;
        }

        protected void btnSaveAbout_Click(object sender, EventArgs e)
        {


            string updatedContent = txtAboutContent.Text;

            // Define your SQL query to update the about content
            string query = "UPDATE about SET About = @AboutContent";

            // Establish a connection to the database
            string connectionString = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@AboutContent", updatedContent);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            // Display success message
                            Response.Write("<script>alert('About content updated successfully.');</script>");
                        }
                        else
                        {
                            // Display error message if no rows were affected
                            Response.Write("<script>alert('Failed to update about content.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
        //void BindGridView()
        //{
        //    string query = "SELECT * FROM images";
        //    SqlConnection connection = new SqlConnection(strcon);
        //    SqlCommand command = new SqlCommand(query, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    pic1.DataSource = reader;
        //    pic1.DataBind();
        //    reader.Close();
        //    connection.Close();
        //}

       
      
    }
