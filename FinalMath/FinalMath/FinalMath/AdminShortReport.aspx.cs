using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class AdminShortReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] info = (String[])Session["info"];
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

                SqlCommand cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.DUESTYPE='income' and d.DATE>='" + info[0].ToString() + "' and d.DATE<='" + info[1].ToString() + "'  GROUP BY h.HEAD_NAME", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                PrintRepeaterCR.DataSource = dt;
                PrintRepeaterCR.DataBind();
                if (dt.Rows.Count > 0)
                {

                    double income = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }

                    lbltotal1.Text = income.ToString();
                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = info[0].ToString();
                    lbldateto.Text = info[1].ToString();


                }


                cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.DUESTYPE='expense' and d.DATE>='" + info[0].ToString() + "' and d.DATE<='" + info[1].ToString() + "'  GROUP BY h.HEAD_NAME", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                RepeaterDR.DataSource = dt;
                RepeaterDR.DataBind();



                if (dt.Rows.Count > 0)
                {
                    double expense = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        expense += (double.Parse(dt.Rows[i]["DrRs"].ToString()));

                    }
                    lbltotal.Text = expense.ToString();

                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = info[0].ToString();
                    lbldateto.Text = info[1].ToString();


                }
            }
        }


        protected void btnback_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DirectorReport.aspx");
        }
    }
}