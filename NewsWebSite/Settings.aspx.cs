using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NewsWebSite
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome" + Session["un"].ToString();
        }

        protected void BtnS_adduser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void BtnS_Articles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articles.aspx");
        }

        protected void BtnS_MSJArticl_Click(object sender, EventArgs e)
        {
            Response.Redirect("MSJ_Articles.aspx");
        }
    }
}