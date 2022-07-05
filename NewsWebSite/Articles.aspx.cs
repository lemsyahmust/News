using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NewsWebSite
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAjtArticles_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("server=DESKTOP-SAN3PBB\\SQLEXPRESS;uid=sa;pwd=123;database=News");
            cnx.Open();

            SqlCommand cmd = new SqlCommand("insert into Articles(title, details,photo) values(@title,@details,@photo)", cnx);
            cmd.Parameters.Add("@title", txtbxtitle.Text);
            cmd.Parameters.Add("@details", txtbxdetails.Text);
            string strImg = System.IO.Path.GetFileName(File1.PostedFile.FileName);
            cmd.Parameters.Add("@photo", strImg);
            cmd.ExecuteNonQuery();

            cnx.Close();
            File1.PostedFile.SaveAs(Server.MapPath("Images\\") + strImg);
        }
    }
}