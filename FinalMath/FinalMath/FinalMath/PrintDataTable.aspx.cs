using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class PrintDataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] info = (String[])Session["info"];
                DataTable dt = (DataTable)Session["Print"];
                PrintRepeater.DataSource = dt;
                PrintRepeater.DataBind();
                if (dt.Rows.Count > 0)
                {
                    double expense = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        expense += (double.Parse(dt.Rows[i]["Amount"].ToString()));
                    }
                    lbltotal.Text = expense.ToString();
                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = info[0].ToString();
                    lbldateto.Text = info[1].ToString();
                    lbltype.Text = info[2].ToString();

                }
            }

        }
    }
}