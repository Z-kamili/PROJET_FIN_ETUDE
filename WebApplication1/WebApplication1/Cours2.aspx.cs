using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cours2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null) Response.Redirect("WebForm1.aspx");
            Afficher_Resultats1.Attributes.Add("style", "display:block");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
           
        }

        protected void BTN_reg_Click(object sender, EventArgs e)
        {

            Session["ID"] = null;
            Response.Redirect("WebForm1.aspx");

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "filename=certificate_example.pdf");
            Response.TransmitFile(Server.MapPath("~/Certife/Cours.pdf"));
            Response.End();
        }
    }
}