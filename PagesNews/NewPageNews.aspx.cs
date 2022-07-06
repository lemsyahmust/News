using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace PagesNews
{
    public partial class NewPageNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection cnx = new SqlConnection("server=DESKTOP-SAN3PBB\\SQLEXPRESS;uid=sa;pwd=123;database=News");
                cnx.Open();

                SqlCommand cmd = new SqlCommand("select * from Articles where id = " + Request.Params["x"], cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    art.InnerHtml += "<center><b>" + dr["title"] + "</b><br></center>";
                    art.InnerHtml += "<center>" + dr["details"] + "<br></center>";
                    art.InnerHtml += "<center><img src=images/" + dr["photo"] + " height = 200 width = 200 /><br></center>";

                }
                cnx.Close();
                cnx.Open();

                SqlCommand cmd2 = new SqlCommand("select * from Commentaire where id = " + Request.Params["x"], cnx);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {

                    comments.InnerHtml += "<b>" + dr2["Name"] + " :  </b>" + dr2["Commentaire"] + "<br>";

                }
                cnx.Close();
            }
        }

        protected void btnAjouter_cm_Click(object sender, EventArgs e)
        {
            comments.InnerHtml += "<b>" + txtbxname.Text + " :  </b>" + txtbxcommet.Text + "<br>";
            SqlConnection cnx = new SqlConnection("server=DESKTOP-SAN3PBB\\SQLEXPRESS;uid=sa;pwd=123;database=News");
            cnx.Open();

            SqlCommand cmd = new SqlCommand("insert into commentaire(Name,Commentaire,id) values(@Name,@Commentaire,@id)", cnx);
            cmd.Parameters.Add("@Name", txtbxname.Text);
            cmd.Parameters.Add("@Commentaire", txtbxcommet.Text);
            cmd.Parameters.Add("@id", Request.Params["x"]);
            cmd.ExecuteNonQuery();
            cnx.Close();
            txtbxname.Text = "";
            txtbxcommet.Text = "";
        }
    }
}