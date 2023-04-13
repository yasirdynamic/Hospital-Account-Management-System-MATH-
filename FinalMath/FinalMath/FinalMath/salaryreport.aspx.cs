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
    public partial class salaryreport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDateFrom.Text = ((System.DateTime.Now).AddMonths(-1)).ToString("MM/dd/yyyy");
                txtDateTo.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlemp.DataSource = dt;
                ddlemp.DataTextField = "EMPLOYEE_NAME";
                ddlemp.DataValueField = "EMPLOYEE_ID";
                ddlemp.DataBind();                

            }

        }
        protected void btnshowreport_Click(object sender, EventArgs e)
        {
            String filter = "";

            if (txtDateFrom.Text != "")
            {
                filter += " AND SALARY_DATE >= '" + txtDateFrom.Text + "'";
            }
            if (txtDateTo.Text != "")
            {
                filter += " AND SALARY_DATE <= '" + txtDateTo.Text + "'";
            }           
            if (ddlemp.SelectedItem.Value != "-1")
            {
                filter += " AND EMPLOYEE_FID = '" + ddlemp.SelectedItem.Value + "'";
            }
            if (ddltype.SelectedItem.Value != "-1")
            {
                filter += " AND EMPLOYEE_TYPE = '" + ddltype.SelectedItem.Text + "'";
            }
            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

            SqlCommand cmd = new SqlCommand("  select * from salary s inner join employees e on e.EMPLOYEE_ID=s.EMPLOYEE_FID where 1=1 " + filter + " ORDER BY s.SALARY_DATE ASC", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            /*  DataTable mydt = new DataTable();
              mydt.Columns.Add("balance");
              mydt.Rows.Add(dt.Rows[0]["CrRs"].ToString());
              for (int i = 1; i < dt.Rows.Count; i++)
              {
                  mydt.Rows.Add((double.Parse(dt.Rows[i]["CrRs"].ToString()) + double.Parse(mydt.Rows[i - 1]["balance"].ToString())).ToString());
              }
              Session["Print"] = mydt;
              dt = mydt.Clone();*/

            //dt.Columns.Add("bal", typeof(System.Int64));
            //Int64 totalbal = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string data = dt.Rows[i]["CrRs"].ToString();
            //    if (data != "0")
            //    {
            //        totalbal = totalbal + Int64.Parse(dt.Rows[i]["CrRs"].ToString());
            //        dt.Rows[i]["bal"] = totalbal;

            //    }
            //    data = dt.Rows[i]["DrRs"].ToString();
            //    if (data != "0")
            //    {
            //        totalbal = totalbal - Int64.Parse(dt.Rows[i]["DrRs"].ToString());
            //        dt.Rows[i]["bal"] = totalbal;
            //    }


            //}


            Session["SalPrint"] = dt;
            Session["Emp"] = ddlemp.SelectedItem.Text;
            Session["Type"] = ddltype.SelectedItem.Text;

            dt.Columns.Add("BA_TOTAL_SALARY", typeof(string));
            for(int i=0;i<dt.Rows.Count;i++)
            {
                dt.Rows[i]["BA_TOTAL_SALARY"] = (decimal.Parse(dt.Rows[i]["EMPLOYEE_MONTHLY_SALARY"].ToString()) + decimal.Parse(dt.Rows[i]["EMPLOYEE_ALLOWENCES"].ToString())).ToString();
            }

            IncomeGridView.DataSource = dt;
            IncomeGridView.DataBind();
            IncomeGridView.Visible = true;


            if (dt.Rows.Count > 0)
            {
                double totalbasicsal = 0;
                double totalallow = 0;
                double totalextraduties = 0;
                double totaltoalsal = 0;
                double totaladvanceamount = 0;
                double totadays = 0;
                double totalabsamount = 0;
                double totalbycheque = 0;
                double totalbycash = 0;
                double totalnetsal = 0;
                double totalbasal = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["EMPLOYEE_MONTHLY_SALARY"].ToString() == "")
                    {
                        dt.Rows[i]["EMPLOYEE_MONTHLY_SALARY"] = "0";
                    }
                    totalbasicsal += (double.Parse(dt.Rows[i]["EMPLOYEE_MONTHLY_SALARY"].ToString()));
                    if (dt.Rows[i]["EMPLOYEE_ALLOWENCES"].ToString() == "")
                    {
                        dt.Rows[i]["EMPLOYEE_ALLOWENCES"] = "0";
                    }
                    totalallow += (double.Parse(dt.Rows[i]["EMPLOYEE_ALLOWENCES"].ToString()));
                    if (dt.Rows[i]["EXTRA_DUTY"].ToString() == "")
                    {
                        dt.Rows[i]["EXTRA_DUTY"] = "0";
                    }
                    totalextraduties += (double.Parse(dt.Rows[i]["EXTRA_DUTY"].ToString()));
                    if (dt.Rows[i]["TOTAL_SALARY"].ToString() == "")
                    {
                        dt.Rows[i][""] = "0";
                    }
                    totaltoalsal += (double.Parse(dt.Rows[i]["TOTAL_SALARY"].ToString()));
                    if (dt.Rows[i]["ADVANCE_AMOUNT"].ToString() == "")
                    {
                        dt.Rows[i]["ADVANCE_AMOUNT"] = "0";
                    }
                    totaladvanceamount += (double.Parse(dt.Rows[i]["ADVANCE_AMOUNT"].ToString()));
                    if (dt.Rows[i]["ABSENT_DAYS"].ToString() == "")
                    {
                        dt.Rows[i]["ABSENT_DAYS"] = "0";
                    }
                    totadays += (double.Parse(dt.Rows[i]["ABSENT_DAYS"].ToString()));

                    if (dt.Rows[i]["ABSENT_AMOUNT"].ToString() == "")
                    {
                        dt.Rows[i]["ABSENT_AMOUNT"] = "0";
                    }
                    totalabsamount += (double.Parse(dt.Rows[i]["ABSENT_AMOUNT"].ToString()));
                    if (dt.Rows[i]["BY_CHEQUE"].ToString() == "")
                    {
                        dt.Rows[i]["BY_CHEQUE"] = "0";
                    }
                    totalbycheque += (double.Parse(dt.Rows[i]["BY_CHEQUE"].ToString()));
                    if (dt.Rows[i]["BY_CASH"].ToString() == "")
                    {
                        dt.Rows[i]["BY_CASH"] = "0";
                    }
                    totalbycash += (double.Parse(dt.Rows[i]["BY_CASH"].ToString()));
                    if (dt.Rows[i]["NET_SALARY"].ToString() == "")
                    {
                        dt.Rows[i]["NET_SALARY"] = "0";
                    }
                    totalnetsal += (double.Parse(dt.Rows[i]["NET_SALARY"].ToString()));
                    if (dt.Rows[i]["BA_TOTAL_SALARY"].ToString() == "")
                    {
                        dt.Rows[i]["BA_TOTAL_SALARY"] = "0";
                    }
                    totalbasal += (double.Parse(dt.Rows[i]["BA_TOTAL_SALARY"].ToString()));

                }
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalbasicsal")).Text = totalbasicsal.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalallownces")).Text = totalallow.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalextraduties")).Text = totalextraduties.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotaltotalsal")).Text = totaltoalsal.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotaladvamount")).Text = totaladvanceamount.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalabsdays")).Text = totadays.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalabsamount")).Text = totalabsamount.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalcheq")).Text = totalbycheque.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalcash")).Text = totalbycash.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltotalnetsal")).Text = totalnetsal.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lblbasal")).Text = totalbasal.ToString("#,##0");

                

            }
        }

        protected void btnprintReport_Click(object sender, EventArgs e)
        {


            String[] info = { txtDateFrom.Text, txtDateTo.Text};
            Session["info"] = info;
            Response.Redirect("SalaryPrint.aspx");
        }
       
    }
}