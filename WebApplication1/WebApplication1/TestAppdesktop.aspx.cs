using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;

namespace WebApplication1
{
    public partial class TestAppdesktop : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-14BHUMG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
  static  int r = 0;
        bool f = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
               
               
                    
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Question where id_examen = @a ", cn);
                    cmd.Parameters.AddWithValue("@a", 1);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    lbl1.Text = dt.Rows[0][1].ToString();
                    Label2.Text = dt.Rows[1][1].ToString();
                    label3.Text = dt.Rows[2][1].ToString();
                    Label4.Text = dt.Rows[3][1].ToString();
                    Label5.Text = dt.Rows[4][1].ToString();
                    Label1.Text = dt.Rows[5][1].ToString();
                    Label6.Text = dt.Rows[6][1].ToString();
                    Label7.Text = dt.Rows[7][1].ToString();

                    cn.Close();
                    cn.Open();

                    SqlCommand cmd2 = new SqlCommand("select * from Choix  ", cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    DataTable dt2 = new DataTable();
                    dt2.Load(dr2);

                    RadioButton1.Text = dt2.Rows[0][1].ToString();
                    RadioButton2.Text = dt2.Rows[1][1].ToString();
                    RadioButton3.Text = dt2.Rows[2][1].ToString();
                    //RadioButton4.Text = dt2.Rows[3][1].ToString();

                    RadioButton5.Text = dt2.Rows[3][1].ToString();
                    RadioButton6.Text = dt2.Rows[4][1].ToString();
                    RadioButton7.Text = dt2.Rows[5][1].ToString();
                    //RadioButton8.Text = dt2.Rows[7][1].ToString();


                    RadioButton9.Text = dt2.Rows[6][1].ToString();
                    RadioButton10.Text = dt2.Rows[7][1].ToString();
                    RadioButton11.Text = dt2.Rows[8][1].ToString();
                    //RadioButton12.Text = dt2.Rows[11][1].ToString();


                    RadioButton13.Text = dt2.Rows[9][1].ToString();
                    RadioButton14.Text = dt2.Rows[10][1].ToString();
                    RadioButton15.Text = dt2.Rows[11][1].ToString();



                    RadioButton17.Text = dt2.Rows[36][1].ToString();
                    RadioButton18.Text = dt2.Rows[37][1].ToString();
                    RadioButton19.Text = dt2.Rows[38][1].ToString();
                    // RadioButton20.Text = dt2.Rows[40][1].ToString();

                    RadioButton4.Text = dt2.Rows[39][1].ToString();
                    RadioButton8.Text = dt2.Rows[40][1].ToString();
                    RadioButton12.Text = dt2.Rows[41][1].ToString();
                    //   RadioButton16.Text = dt2.Rows[43][1].ToString();


                    RadioButton21.Text = dt2.Rows[42][1].ToString();
                    RadioButton22.Text = dt2.Rows[43][1].ToString();
                    RadioButton23.Text = dt2.Rows[44][1].ToString();
                    //  RadioButton20.Text = dt2.Rows[24][1].ToString();


                    RadioButton25.Text = dt2.Rows[45][1].ToString();
                    RadioButton26.Text = dt2.Rows[46][1].ToString();
                    RadioButton27.Text = dt2.Rows[47][1].ToString();
                    //   RadioButton20.Text = dt2.Rows[40][1].ToString();

                    cn.Close();
                
              
                
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Div2.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            Div1.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a",cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton13.Checked) resultas = RadioButton13.Text;
            else if (RadioButton14.Checked) resultas = RadioButton14.Text;
            else if (RadioButton15.Checked) resultas = RadioButton15.Text;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }
           
            cn.Close();

            //if(r > 6)
            //{
            //    pnl1.Visible = true;
            //    note.Text = r + "/ 10";
            //}else
            //{
            //    pnl2.Visible = true;
            //    note.Text = r + "/ 10";
            //}

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Div1.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            DivLandingPage2.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a",cn);
            cmd.Parameters.AddWithValue("@a", 1);
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
            cn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DivLandingPage.Attributes.Add("style", "display:none");
            //if q 1 is true or false
            DivLandingPage1.Attributes.Add("style", "display:block");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton1.Checked) resultas = RadioButton1.Text;
         else   if (RadioButton2.Checked) resultas = RadioButton2.Text;
         else   if (RadioButton3.Checked) resultas = RadioButton3.Text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    
                    r += 1;

                }
            }
            cn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DivLandingPage2.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            DivLandingPage1.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a",cn);
            cmd.Parameters.AddWithValue("@a", 1);
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
            cn.Close();
        }

        protected void BTN_reg_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            r = 0;
            Response.Redirect("WebForm1.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //PrintDocument imp = new PrintDocument();
            //imp.DocumentName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "~/Certife/certificate_example.pdf";
            //string vue = imp.ToString();
            //imp.Print();
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            Div4.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            Div2.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton17.Checked) resultas = RadioButton17.Text;
            else if (RadioButton18.Checked) resultas = RadioButton18.Text;
            else if (RadioButton19.Checked) resultas = RadioButton19.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            //if (r > 6)
            //{
            //    pnl1.Visible = true;
            //    note.Text = r + "/ 10";
            //}
            //else
            //{
            //    pnl2.Visible = true;
            //    note.Text = r + "/ 10";
            //}

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Div5.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            Div4.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton4.Checked) resultas = RadioButton4.Text;
            else if (RadioButton8.Checked) resultas = RadioButton8.Text;
            else if (RadioButton12.Checked) resultas = RadioButton12.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            //if (r > 6)
            //{
            //    pnl1.Visible = true;
            //    note.Text = r + "/ 10";
            //}
            //else
            //{
            //    pnl2.Visible = true;
            //    note.Text = r + "/ 10";
            //}
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Div6.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            Div5.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton21.Checked) resultas = RadioButton21.Text;
            else if (RadioButton22.Checked) resultas = RadioButton22.Text;
            else if (RadioButton23.Checked) resultas = RadioButton23.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();

            //if (r > 6)
            //{
            //    pnl1.Visible = true;
            //    note.Text = r + "/ 10";
            //}
            //else
            //{
            //    pnl2.Visible = true;
            //    note.Text = r + "/ 10";
            //}
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Afficher_Resultat.Attributes.Add("style", "display:block");
            //if q 2 is true or false
            Div6.Attributes.Add("style", "display:none");
            string resultas = "";
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Choix where etats = @a", cn);
            cmd.Parameters.AddWithValue("@a", 1);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (RadioButton25.Checked) resultas = RadioButton25.Text;
            else if (RadioButton26.Checked) resultas = RadioButton26.Text;
            else if (RadioButton27.Checked) resultas = RadioButton27.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (resultas == dt.Rows[i][1].ToString())
                {
                    r += 1;

                }
            }

            cn.Close();
            r += 2;
            if (r > 6)
            {
                pnl1.Visible = true;
                note.Text =r  + "/ 10";
                f = true;
            }
            else
            {
                pnl2.Visible = true;
                note.Text = r  + "/ 10";
                f = true;
            }
        }
    }
}