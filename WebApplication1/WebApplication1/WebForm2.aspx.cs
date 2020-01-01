using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static string refers = "Etudiant";
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList3.Enabled = false;
            //SqlDataReader rd;
          

            //    if (!Page.IsPostBack)
            //    {
            //        Class1.connecter();
            //        Class1.cmd = new SqlCommand("Select * from Filiere", Class1.cn);
            //     rd  = Class1.cmd.ExecuteReader();
            //        DataTable dt = new DataTable();
            //        dt.Load(rd);
            //        DropDownList2.DataSource = dt;
            //        DropDownList2.DataTextField = "nom_filiere";
            //        DropDownList2.DataValueField = "id_filiere";
            //        DropDownList2.DataBind();
                
            //        Class1.Deconnecter();
            //    }
           
           
          //  DropDownList1.Visible = false;
        }

        protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {
          //  DropDownList1.Visible = true;
            DivCRLO.Attributes["style"] = "height: 33em;";
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //DropDownList1.Visible = false;
            DivCRLO.Attributes["style"] = "height: 30em;";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //DropDownList3.Visible = false;
            //DropDownList1.Visible = false;
            //refs = "formateur";
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            //DropDownList3.Visible = true;
            //DropDownList1.Visible = true;
            //refs = "Etudiant";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DropDownList3.Enabled = true;
            Class1.connecter();
            //Class1.cmd = new SqlCommand("Select id_filiere from Filiere where nom_filiere = @a", Class1.cn);
            //Class1.cmd.Parameters.AddWithValue("@a", DropDownList2.Text);
            //lb1.Text = DropDownList2.Text;
            //SqlDataReader rd = Class1.cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(rd);

            //Class1.cmd = new SqlCommand("Select * from Groupe where id_filiere = @a   And annee = @b", Class1.cn);
            //Class1.cmd.Parameters.AddWithValue("@a", DropDownList2.Text);
            //Class1.cmd.Parameters.AddWithValue("@b", DropDownList1.Text);
            //SqlDataReader rd2 = Class1.cmd.ExecuteReader();
            //DataTable dt2 = new DataTable();
            //dt2.Load(rd2);
            //DropDownList3.DataSource = dt2;
            //DropDownList3.DataTextField = "nom_grp";
            //DropDownList3.DataValueField = "id";
            //DropDownList3.DataBind();
            //Class1.Deconnecter();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
                {
                    Page.ClientScript.RegisterClientScriptBlock(GetType(), "alert depuis le codehind", string.Format("alert('{0}')", "Erreur !!   vous devez remplir tous les champs "), true);
                }
                else
                {
                    Class1.connecter();

                    Class1.cmd = new SqlCommand("Insert into Etudiant values(@a,@b,@c,@d)", Class1.cn);
                    Class1.cmd.Parameters.AddWithValue("@a", TextBox1.Text);
                    Class1.cmd.Parameters.AddWithValue("@b", TextBox3.Text);
                    Class1.cmd.Parameters.AddWithValue("@c", TextBox4.Text);
                    Class1.cmd.Parameters.AddWithValue("@d", TextBox2.Text);

                    SqlDataReader rd = Class1.cmd.ExecuteReader();
                    // lb1.Text = "Inscription bien effectuer";
                    Page.ClientScript.RegisterClientScriptBlock(GetType(), "alert depuis le codehind", string.Format("alert('{0}')", "Inscription bien effectuer"), true);
                    //  r = true;
                    Class1.Deconnecter();
                    Response.Redirect("WebForm1.aspx");

                }
            }
            catch (Exception)
            {
            }


          
          
        }
      

        protected void btn1_Click(object sender, EventArgs e)
        {
            refers = "formateur";
            //DropDownList3.Visible = false;
            //DropDownList1.Visible = false;
        }

        protected void btn2_Click(object sender, EventArgs e)
        {

            refers = "Etudiant";
            //DropDownList3.Visible = true;
            //DropDownList1.Visible = true;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
  
}