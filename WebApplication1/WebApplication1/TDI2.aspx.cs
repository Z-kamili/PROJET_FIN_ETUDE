using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TDI2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_reg_Click(object sender, EventArgs e)
        {
            Session["ID"] = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}