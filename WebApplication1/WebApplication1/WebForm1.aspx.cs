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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Class1.connecter();
            bool r = false;
            try
            {
                
               
                Class1.cmd = new SqlCommand("select * from Etudiant", Class1.cn);
                SqlDataReader dr2 = Class1.cmd.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (TextBox2.Text == dt2.Rows[i][2].ToString() && TextBox1.Text == dt2.Rows[i][3].ToString())
                    {
                        Session["ID"] = dt2.Rows[i][0].ToString();
                        r = true;
                        break;
                       
                    }
                }
                if (r)
                {
                    Response.Redirect("WebForm3.aspx");
                }

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "alert depuis le codehind", string.Format("alert('{0}')",ex.Message), true);

            }
        }
    }
}