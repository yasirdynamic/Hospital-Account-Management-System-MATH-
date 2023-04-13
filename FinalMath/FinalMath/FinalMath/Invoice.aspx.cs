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
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] info = (String[])Session["info"];
                String head = (String)Session["Head"];
                String vendor = (String)Session["vendor"];
                String paytype = (String)Session["paytype"];
                DataTable dt = (DataTable)Session["Print"];
                PrintRepeater.DataSource = dt;
                PrintRepeater.DataBind();
                DateTime to;
                DateTime from;

                if (info[0].Equals(""))
                {
                    to = DateTime.ParseExact("01/01/2000", "MM/dd/yyyy", null);
                    from = to.AddMonths(-1);
                }
                else
                {
                    to = DateTime.ParseExact(info[0], "MM/dd/yyyy", null);
                    from = to.AddMonths(-1);
                }
                double expense = 0;
                double income = 0;

                if (dt.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        expense += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                        income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }

                    
                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text =info[0].ToString();
                   
                    lbldateto.Text = info[1].ToString();
                    lbltype.Text = info[2].ToString();
                    lblheadtype.Text = head.ToString();
                    lblvendor.Text = vendor.ToString();
                    lblpaytype.Text = paytype.ToString();


                }

                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

                SqlCommand cmd = new SqlCommand("SELECT Sum(Expense_Amount) as 'exp'  FROM DUES where date>='"+from.ToString("MM/dd/yyyy")+ "' and date<='" + to.ToString("MM/dd/yyyy") + "'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                String totalexp = dt.Rows[0]["exp"].ToString();
                if(totalexp.Equals(""))
                {
                    totalexp = "0";
                }
                cmd = new SqlCommand("SELECT Sum(income_Amount) as 'inc'  FROM DUES where date>='" + from.ToString("MM/dd/yyyy") + "' and date<='" + to.ToString("MM/dd/yyyy") + "'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                String totalinc = dt.Rows[0]["inc"].ToString();
                if (totalinc.Equals(""))
                {
                    totalinc = "0";
                }
                lblopenbal.Text = (Convert.ToInt32(income.ToString()) - Convert.ToInt32(expense.ToString())).ToString("#,##0");
                lblexpense.Text = expense.ToString("#,##0");
                lblincome.Text = income.ToString("#,##0");

            }

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx");
        }
    }
}