using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace NewsWebSite
{
    public partial class Authentification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("server=DESKTOP-SAN3PBB\\SQLEXPRESS;uid=sa;pwd=123;database=News");
            SqlCommand cmd = new SqlCommand("select * from Users where username = @username and password = @password", cnx);
            cmd.Parameters.Add("@username", txtbxAuusername.Text);
            cmd.Parameters.Add("@password", txtbxAupassw.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            if (ds.Tables["Users"].Rows.Count == 0)
                Response.Write("Invalid Users");
            else
            {
                Session["un"] = txtbxAuusername.Text;
                Response.Redirect("Settings.aspx");
            }
               

        }
    }
}