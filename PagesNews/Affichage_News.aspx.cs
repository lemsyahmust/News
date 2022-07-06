using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PagesNews
{
    public partial class Affichage_News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("server=DESKTOP-SAN3PBB\\SQLEXPRESS;uid=sa;pwd=123;database=News");
            cnx.Open();

            SqlCommand cmd = new SqlCommand("select id,title from Articles", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            string strtitle = "";
            while (dr.Read())
                strtitle += "<a href = NewPageNews.aspx?x=" + dr["id"] + ">" + "<b>" + dr["title"] + "</b>" + "</a> &nbsp; &nbsp; &nbsp;" ;
            n.InnerHtml = "<marquee id=news onmouseover=news.stop(); onmouseout = news.start();>" + strtitle + "</marquee>";

            cnx.Close();
        }
    }
}