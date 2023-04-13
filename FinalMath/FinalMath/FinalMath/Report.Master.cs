using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class Report : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnpplink_Click(object sender, EventArgs e)
        {
            Session["Data Entry Operator"] = "true";
            var page = HttpContext.Current.Handler as Page;
            Response.Redirect(page.GetRouteUrl("Default",
                new { Controller = "PATIENT_INFODATAOPERATOR", Action = "Index" }), false);

        }
    }
}