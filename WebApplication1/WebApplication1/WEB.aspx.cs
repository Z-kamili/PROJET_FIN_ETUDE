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
    public partial class WEB : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-14BHUMG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        static int r = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] == null)
            {

                Response.Redirect("WebForm1.aspx");

            }
            else {

                pnl111.Visible = false;
                pnl222.Visible = false;
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Question where id_examen = @a ", cn);
                cmd.Parameters.AddWithValue("@a", 3);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                label111.Text = dt.Rows[0][1].ToString();
                Label222.Text = dt.Rows[1][1].ToString();
                label33.Text = dt.Rows[2][1].ToString();
                Label44.Text = dt.Rows[3][1].ToString();
                Label55.Text = dt.Rows[4][1].ToString();
                Label66.Text = dt.Rows[5][1].ToString();
                Label77.Text = dt.Rows[6][1].ToString();
                Label88.Text = dt.Rows[7][1].ToString();


                cn.Close();
                cn.Open();

                SqlCommand cmd2 = new SqlCommand("select * from Choix", cn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);

                wbR1.Text = dt2.Rows[24][1].ToString();
                wbR2.Text = dt2.Rows[25][1].ToString();
                wbR3.Text = dt2.Rows[26][1].ToString();
                //RadioButton4.Text = dt2.Rows[3][1].ToString();

                wbr4.Text = dt2.Rows[27][1].ToString();
                wbr5.Text = dt2.Rows[28][1].ToString();
                wbr6.Text = dt2.Rows[29][1].ToString();
                //RadioButton8.Text = dt2.Rows[7][1].ToString();


                wbr7.Text = dt2.Rows[30][1].ToString();
                wbr8.Text = dt2.Rows[31][1].ToString();
                wbr9.Text = dt2.Rows[32][1].ToString();
                //RadioButton12.Text = dt2.Rows[11][1].ToString();


                wbr10.Text = dt2.Rows[33][1].ToString();
                wbr11.Text = dt2.Rows[34][1].ToString();
                wbr12.Text = dt2.Rows[35][1].ToString();

                ////////////////////////////////////////
                wbr17.Text = dt2.Rows[48][1].ToString();
                wbr18.Text = dt2.Rows[49][1].ToString();
                wbr19.Text = dt2.Rows[50][1].ToString();


                RadioButton1.Text = dt2.Rows[51][1].ToString();
                RadioButton2.Text = dt2.Rows[52][1].ToString();
                RadioButton3.Text = dt2.Rows[53][1].ToString();


                RadioButton5.Text = dt2.Rows[54][1].ToString();
                RadioButton6.Text = dt2.Rows[55][1].ToString();
                RadioButton7.Text = dt2.Rows[56][1].ToString();


                RadioButton9.Text = dt2.Rows[57][1].ToString();
                RadioButton10.Text = dt2.Rows[58][1].ToString();
                RadioButton11.Text = dt2.Rows[59][1].ToString();

                cn.Close();



            }






        }

        protected void btn44_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (wbr10.Checked) resultas = wbr10.Text;
            else if (wbr11.Checked) resultas = wbr11.Text;
            else if (wbr12.Checked) resultas = wbr12.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            if (r > 6)
            {
                pnl111.Visible = true;
                note3.Text = r + "/ 10";
            }
            else
            {
                pnl222.Visible = true;
                note3.Text = r + "/ 10";
            }
            div33.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div22.Attributes.Add("style", "display:none");
        }

        protected void btn33_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (wbr7.Checked) resultas = wbr7.Text;
            else if (wbr8.Checked) resultas = wbr8.Text;
            else if (wbr9.Checked) resultas = wbr9.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

           
            DivLandingPage222.Attributes.Add("style", "display:none");
            div22.Attributes.Add("style", "display:block");
            //if q 2 is true or false
        }

        protected void btn22_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (wbr4.Checked) resultas = wbr4.Text;
            else if (wbr5.Checked) resultas = wbr5.Text;
            else if (wbr6.Checked) resultas = wbr6.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

           
            DivLandingPage222.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div11.Attributes.Add("style", "display:none");
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
          
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (wbR1.Checked) resultas = wbR1.Text;
            else if (wbR2.Checked) resultas = wbR2.Text;
            else if (wbR3.Checked) resultas = wbR3.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            DivLandingPage11.Attributes.Add("style", "display:none");
            //if q 1 is true or false
            div11.Attributes.Add("style", "display:block");



        }

        protected void BTN_reg_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            r = 0;
            Response.Redirect("WebForm1.aspx");
        }

        protected void btn55_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (wbr17.Checked) resultas = wbr17.Text;
            else if (wbr18.Checked) resultas = wbr18.Text;
            else if (wbr19.Checked) resultas = wbr19.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }
            div333.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div33.Attributes.Add("style", "display:none");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton1.Checked) resultas = RadioButton1.Text;
            else if (RadioButton2.Checked) resultas = RadioButton2.Text;
            else if (RadioButton3.Checked) resultas = RadioButton3.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }
            div222.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div333.Attributes.Add("style", "display:none");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton5.Checked) resultas = RadioButton5.Text;
            else if (RadioButton6.Checked) resultas = RadioButton6.Text;
            else if (RadioButton7.Checked) resultas = RadioButton7.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }
            div444.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div222.Attributes.Add("style", "display:none");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 3);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton9.Checked) resultas = RadioButton9.Text;
            else if (RadioButton10.Checked) resultas = RadioButton10.Text;
            else if (RadioButton11.Checked) resultas = RadioButton11.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }
            r += 2;
            if (r > 6)
            {
                pnl111.Visible = true;
                note3.Text = r + "/ 10";
              
            }
            else
            {
                pnl222.Visible = true;
                note3.Text = r + "/ 10";
              
            }
            Afficher_Resultat3.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div444.Attributes.Add("style", "display:none");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (r > 6)
            {
                r = 0;
                Response.ContentType = "application/pdf";
                Response.AppendHeader("content-disposition", "filename=certificate_example.pdf");
                Response.TransmitFile(Server.MapPath("~/Certife/certificate_example.pdf"));
                Response.End();
              
            }else
            {
                r = 0;
            }
         
        }
    }
}