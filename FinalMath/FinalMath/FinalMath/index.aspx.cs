using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var page = HttpContext.Current.Handler as Page;
            Response.Redirect(page.GetRouteUrl("Default",
                new { Controller = "Home", Action = "Index" }), false);
        }
    }
}