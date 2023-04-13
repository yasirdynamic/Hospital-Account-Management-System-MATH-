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
    public partial class SalaryPrint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] info = (String[])Session["info"];
                String emp = (String)Session["Emp"];
                String type = (String)Session["Type"];
                DataTable dt = (DataTable)Session["SalPrint"];
                IncomeGridView.DataSource = dt;
                IncomeGridView.DataBind();

                lblemp.Text = emp;
                lbltype.Text = type;
                if(info[0]!="" && info[1]!="")
                {
                    lbldatefrom.Text = DateTime.Parse(info[0]).ToString("MM/dd/yyyy");
                    lbldateto.Text = DateTime.Parse(info[1]).ToString("MM/dd/yyyy");

                }
                lbldatetoday.Text = System.DateTime.Now.ToString("MM/dd/yyyy");

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

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx");
        }
    }
}