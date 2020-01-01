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
    public partial class Mobile : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-14BHUMG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        static int r = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null) Response.Redirect("WebForm1.aspx");
            else
            {

                pnl11.Visible = false;
                pnl22.Visible = false;
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Question where id_examen = @a ", cn);
                cmd.Parameters.AddWithValue("@a", 2);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                label11.Text = dt.Rows[0][1].ToString();
                Label22.Text = dt.Rows[1][1].ToString();
                label33.Text = dt.Rows[2][1].ToString();
                Label44.Text = dt.Rows[3][1].ToString();
                Label55.Text = dt.Rows[4][1].ToString();
                Label1.Text = dt.Rows[5][1].ToString();
                Label2.Text = dt.Rows[6][1].ToString();
                Label3.Text = dt.Rows[7][1].ToString();

            cn.Close();
                cn.Open();

                SqlCommand cmd2 = new SqlCommand("select * from Choix", cn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);

                MbR1.Text = dt2.Rows[12][1].ToString();
                MbR2.Text = dt2.Rows[13][1].ToString();
                MbR3.Text = dt2.Rows[14][1].ToString();
                //RadioButton4.Text = dt2.Rows[3][1].ToString();

                Mbr4.Text = dt2.Rows[15][1].ToString();
                Mbr5.Text = dt2.Rows[16][1].ToString();
                Mbr6.Text = dt2.Rows[17][1].ToString();
                //RadioButton8.Text = dt2.Rows[7][1].ToString();


                Mbr7.Text = dt2.Rows[18][1].ToString();
                Mbr8.Text = dt2.Rows[19][1].ToString();
                Mbr9.Text = dt2.Rows[20][1].ToString();
                //RadioButton12.Text = dt2.Rows[11][1].ToString();


            Mbr17.Text = dt2.Rows[60][1].ToString();
            Mbr18.Text = dt2.Rows[61][1].ToString();
            Mbr19.Text = dt2.Rows[62][1].ToString();  

            RadioButton1.Text = dt2.Rows[63][1].ToString();
            RadioButton2.Text = dt2.Rows[64][1].ToString();
            RadioButton3.Text = dt2.Rows[65][1].ToString();



            RadioButton5.Text = dt2.Rows[66][1].ToString();
            RadioButton6.Text = dt2.Rows[67][1].ToString();
            RadioButton7.Text = dt2.Rows[68][1].ToString();



            RadioButton9.Text = dt2.Rows[69][1].ToString();
            RadioButton10.Text = dt2.Rows[70][1].ToString();
            RadioButton11.Text = dt2.Rows[71][1].ToString();


            Mbr10.Text = dt2.Rows[21][1].ToString();
            Mbr11.Text = dt2.Rows[22][1].ToString();
            Mbr12.Text = dt2.Rows[23][1].ToString();

            cn.Close();


            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {


            DivLandingPage1.Attributes.Add("style", "display:none");
            //if q 1 is true or false
            div1.Attributes.Add("style", "display:block");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (MbR1.Checked) resultas = MbR1.Text;
            else if (MbR2.Checked) resultas = MbR2.Text;
            else if (MbR3.Checked) resultas = MbR3.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

          
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (Mbr4.Checked) resultas = Mbr4.Text;
            else if (Mbr5.Checked) resultas = Mbr5.Text;
            else if (Mbr6.Checked) resultas = Mbr6.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 2;

                }
            }

            cn.Close();

        
            DivLandingPage22.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div1.Attributes.Add("style", "display:none");
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            div3.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div2.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (Mbr10.Checked) resultas = Mbr10.Text;
            else if (Mbr11.Checked) resultas = Mbr11.Text;
            else if (Mbr12.Checked) resultas = Mbr12.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            
           
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (Mbr7.Checked) resultas = Mbr7.Text;
            else if (Mbr8.Checked) resultas = Mbr8.Text;
            else if (Mbr9.Checked) resultas = Mbr9.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 2;

                }
            }

            cn.Close();

           
            DivLandingPage22.Attributes.Add("style", "display:none");
            div2.Attributes.Add("style", "display:block");
            //if q 2 is true or false
           
        }

        protected void BTN_reg_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Response.Redirect("WebForm1.aspx");
            r = 0;
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            div4.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div3.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (Mbr17.Checked) resultas = Mbr17.Text;
            else if (Mbr18.Checked) resultas = Mbr18.Text;
            else if (Mbr19.Checked) resultas = Mbr19.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            div5.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div4.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
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

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            div6.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div5.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
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
                    r += 2;

                }
            }

        }

        protected void btn3_Click1(object sender, EventArgs e)
        {
            div2.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            DivLandingPage22.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
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
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Afficher_Resultat2.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            div6.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Choix.* from Choix,Question where Choix.id_qte = Question.id_qte And Question.id_examen = @b And  etats = @a  ", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            cmd.Parameters.AddWithValue("@b", 2);
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
                pnl11.Visible = true;
                note2.Text = r + "/ 10";
              
            }
            else
            {
                pnl22.Visible = true;
                note2.Text = r + "/ 10";
               
            }
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