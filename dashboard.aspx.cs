using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class dashboard : System.Web.UI.Page
    {
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
    }
}