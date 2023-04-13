using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class ShortReportInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] info = (String[])Session["info"];
                DataTable dt = (DataTable)Session["Print"];
             /*   PrintRepeater.DataSource = dt;
                PrintRepeater.DataBind();*/
                if (dt.Rows.Count > 0)
                {
                    double expense = 0;
                    double income = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        expense += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                        income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }
              /*      lbltotal.Text = expense.ToString();
                    lbltotal1.Text = income.ToString();
                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = info[0].ToString();
                    lbldateto.Text = info[1].ToString();
                    lbltype.Text = info[2].ToString();*/

                }
            }
        }
    }
}