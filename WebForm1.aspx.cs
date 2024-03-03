using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        }
    }
}