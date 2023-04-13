using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class BankReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDateFrom.Text = ((System.DateTime.Now).AddMonths(-1)).ToString("MM/dd/yyyy");
                txtDateTo.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("select * from Heads", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlchead.DataSource = dt;
                ddlchead.DataTextField = "HEAD_NAME";
                ddlchead.DataValueField = "HEAD_ID";
                ddlchead.DataBind();


                cmd = new SqlCommand("select * from MODES_OF_PAYMENTS where MODES_OF_PAYMENT_NAME!='Cash'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlpaymentmode.DataSource = dt;
                ddlpaymentmode.DataTextField = "MODES_OF_PAYMENT_NAME";
                ddlpaymentmode.DataValueField = "MODES_OF_PAYMENTS_ID";
                ddlpaymentmode.DataBind();




                cmd = new SqlCommand("select * from VENDORS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlvendor.DataSource = dt;
                ddlvendor.DataTextField = "VENDOR_NAME";
                ddlvendor.DataValueField = "VENDOR_ID";
                ddlvendor.DataBind();

                cmd = new SqlCommand("select * from USERS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddluser.DataSource = dt;
                ddluser.DataTextField = "USER_NAME";
                ddluser.DataValueField = "USER_ID";
                ddluser.DataBind();

            }

        }
        protected void btnshowreport_Click(object sender, EventArgs e)
        {
            String filter = "";

            if (txtDateFrom.Text != "")
            {
                filter += " AND DATE >= '" + txtDateFrom.Text + "'";
            }
            if (txtDateTo.Text != "")
            {
                filter += " AND DATE <= '" + txtDateTo.Text + "'";
            }
            if (txtvoucher.Text != "")
            {
                filter += " AND VOUCHER_NO = '" + txtvoucher.Text + "'";
            }
            if (ddlchead.SelectedItem.Value != "-1")
            {
                filter += " AND HEAD_FID = '" + ddlchead.SelectedItem.Value + "'";
            }

            if (ddlvendor.SelectedItem.Value != "-1")
            {
                filter += " AND VENDOR_FID = '" + ddlvendor.SelectedItem.Value + "'";
            }

            if (ddluser.SelectedItem.Value != "-1")
            {
                filter += " AND USER_FID = '" + ddluser.SelectedItem.Value + "'";
            }

            if (ddlpaymentmode.SelectedItem.Value != "-1")
            {
                filter += " AND MODES_OF_PAYMENTS_FID = '" + ddlpaymentmode.SelectedItem.Value + "'";
            }
            if (ddldepexp.SelectedItem.Value != "-1")
            {
                string data = ddldepexp.SelectedItem.Text;
               
                string res = string.Empty;
                for(int i=0;i<data.Length;i++)
                {
                    res = data[i].ToString();
                    break;
                }

                if(res== "E")
                {
                    filter += " AND exp_type = 'e'";
                }
                if (res == "D")
                {
                    filter += " AND exp_type = 'd'";
                }
                if (res == "W")
                {
                    filter += " AND exp_type = 'w'";
                }
                if (res == "O")
                {
                    filter += " AND exp_type = 'od'";
                }
            }




            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

            SqlCommand cmd = new SqlCommand("select exp_type,i.DATE as 'Date',i.VOUCHER_NO as 'Voucher',i.DESCRIPTION as 'Desc',INCOME_AMOUNT as 'CrRs',EXPENSE_AMOUNT as 'DrRs',i.PIC as 'Doc',v.VENDOR_NAME as 'Vendor',h.HEAD_NAME as 'Head',m.MODES_OF_PAYMENT_NAME as 'Mode',u.USER_NAME as 'username' from DUES i inner join VENDORS v on i.VENDOR_FID=v.VENDOR_ID inner join USERS u on i.USER_FID=u.USER_ID inner join HEADS h on h.HEAD_ID=i.HEAD_FID inner join MODES_OF_PAYMENTS m on m.MODES_OF_PAYMENTS_ID=i.MODES_OF_PAYMENTS_FID  WHERE 1=1 " + filter + " AND MODES_OF_PAYMENT_NAME!='Cash' ORDER BY i.DATE ASC", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("bal", typeof(System.Int64));
            Int64 totalbal = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                if(dt.Rows[i]["exp_type"].ToString()=="e")
                {
                    totalbal = totalbal - Int64.Parse(dt.Rows[i]["DrRs"].ToString());
                    dt.Rows[i]["bal"] = totalbal;
                    dt.Rows[i]["exp_type"] = "Expense";
                }
                if (dt.Rows[i]["exp_type"].ToString() == "d")
                {
                    totalbal = totalbal + Int64.Parse(dt.Rows[i]["DrRs"].ToString());
                    dt.Rows[i]["bal"] = totalbal;                    
                    dt.Rows[i]["exp_type"] = "Deposit";
                    dt.Rows[i]["CrRs"] = dt.Rows[i]["DrRs"].ToString();
                    dt.Rows[i]["DrRs"] = "0";
                }
                if (dt.Rows[i]["exp_type"].ToString() == "od")
                {
                    totalbal = totalbal + Int64.Parse(dt.Rows[i]["CrRs"].ToString());
                    dt.Rows[i]["bal"] = totalbal;
                    
                    dt.Rows[i]["exp_type"] = "Online Income";
                    dt.Rows[i]["CrRs"] = dt.Rows[i]["CrRs"].ToString();
                    dt.Rows[i]["DrRs"] = "0";
                }
                if (dt.Rows[i]["exp_type"].ToString() == "w")
                {
                    totalbal = totalbal - Int64.Parse(dt.Rows[i]["CrRs"].ToString());
                     dt.Rows[i]["bal"] = totalbal;
                     dt.Rows[i]["exp_type"] = "Withdraw";
                    dt.Rows[i]["DrRs"] = dt.Rows[i]["CrRs"].ToString();
                    dt.Rows[i]["CrRs"] = "0";
                }

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["bal"].ToString() == "")
                {
                    dt.Rows[i]["bal"] = "0";
                }
            }


                /*  DataTable mydt = new DataTable();
                  mydt.Columns.Add("balance");
                  mydt.Rows.Add(dt.Rows[0]["CrRs"].ToString());
                  for (int i = 1; i < dt.Rows.Count; i++)
                  {
                      mydt.Rows.Add((double.Parse(dt.Rows[i]["CrRs"].ToString()) + double.Parse(mydt.Rows[i - 1]["balance"].ToString())).ToString());
                  }
                  Session["Print"] = mydt;
                  dt = mydt.Clone();*/
                Session["Print"] = dt;
            Session["Head"] = ddlchead.SelectedItem.Text;
            Session["Vendor"] = ddlvendor.SelectedItem.Text;
            Session["paytype"] = ddlpaymentmode.SelectedItem.Text;

            IncomeGridView.DataSource = dt;
            IncomeGridView.DataBind();
            IncomeGridView.Visible = true;


            if (dt.Rows.Count > 0)
            {
                double income = 0;
                double expense = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["CrRs"].ToString() == "")
                    {
                        dt.Rows[i][""] = "0";
                    }
                    income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    if (dt.Rows[i]["DrRs"].ToString() == "")
                    {
                        dt.Rows[i][""] = "0";
                    }
                    expense += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                }
                     ((Label)IncomeGridView.FooterRow.FindControl("lblqty")).Text = income.ToString("#,##0");

                ((Label)IncomeGridView.FooterRow.FindControl("lblqty1")).Text = expense.ToString("#,##0");
                ((Label)IncomeGridView.FooterRow.FindControl("lbltbal")).Text = (income-expense).ToString("#,##0");

            }
        }

        protected void btnprintReport_Click(object sender, EventArgs e)
        {


            String[] info = { txtDateFrom.Text, txtDateTo.Text,ddldepexp.SelectedItem.Text};
            Session["info"] = info;
            Response.Redirect("Invoice.aspx");
        }

        protected void btnshortreport_Click(object sender, EventArgs e)
        {


            String[] info = { txtDateFrom.Text, txtDateTo.Text };
            Session["info"] = info;

            Response.Redirect("ShortInvoice.aspx");
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the runtime error "  
            //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."  
        }
        protected void btnexcel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Vithal" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);


            IncomeGridView.GridLines = GridLines.Both;
            IncomeGridView.HeaderStyle.Font.Bold = true;
            IncomeGridView.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();

        }
    }
}