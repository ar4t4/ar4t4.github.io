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



        }

        protected void btnViewStatistics_Click(object sender, EventArgs e)
        {

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
