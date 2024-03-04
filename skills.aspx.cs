using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asif_portfolio
{
    public partial class skills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //string skillValue = t1.Text;

            //// Redirect to index.aspx page with the skill value in the query string
            //Response.Redirect("index.aspx?skill=" + Server.UrlEncode(skillValue));
            //Session["t1"] = t1.Text;
            //Response.Redirect("index.aspx");

            HttpCookie cookie1 = new HttpCookie("t1");
            cookie1.Value = t1.Text;
            cookie1.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie1);
            Response.Redirect("index.aspx");
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            //string skillValue1 = t2.Text;
            //Response.Redirect("index.aspx?skill1=" + Server.UrlEncode(skillValue1));

            HttpCookie cookie = new HttpCookie("t2");
            cookie.Value = t2.Text;
            cookie.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie);
            Response.Redirect("index.aspx");

        }
        protected void btn3_Click(object sender, EventArgs e)
        {
            Session["t3"]= t3.Text;
            Response.Redirect("index.aspx");

        }

    }

        
    }
