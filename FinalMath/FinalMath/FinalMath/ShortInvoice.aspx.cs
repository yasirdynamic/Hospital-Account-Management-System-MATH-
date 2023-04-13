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
    public partial class ShortInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblopenbal.Text = "0";
                lblclosebal.Text = "0";
                String[] info = (String[])Session["info"];
                String datefrom = info[0].ToString();
                String dateto = info[1].ToString();

                String to;
                String from;
                if (info[0].ToString() == "" && info[1].ToString() == "")
                {
                    datefrom = "01/01/0001";
                    dateto = System.DateTime.Now.ToString("MM/dd/yyyy");

                    from = DateTime.ParseExact("01/06/2020", "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                    to = DateTime.ParseExact(from, "dd/MM/yyyy", null).AddMonths(+1).ToString("MM/dd/yyyy");

                }
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                if (info[0].Equals(""))
                {
                    from = DateTime.ParseExact("01/06/2020", "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                    to = DateTime.ParseExact(from, "dd/MM/yyyy", null).AddMonths(+1).ToString("MM/dd/yyyy");
                }
                else
                {
                    from = "06/01/2020";
                    to = DateTime.ParseExact(from, "MM/dd/yyyy", null).AddMonths(+1).ToString("MM/dd/yyyy");

                }

                if (DateTime.ParseExact(datefrom, "MM/dd/yyyy", null).Day <= 7 && DateTime.ParseExact(datefrom, "MM/dd/yyyy", null).Year <= 2020)
                {
                    lblopenbal.Text = "495936";
                }
                else
                {
                    while(DateTime.ParseExact(from, "MM/dd/yyyy", null) < DateTime.ParseExact(datefrom, "MM/dd/yyyy", null))
                    {                    

                        if (DateTime.ParseExact(from, "MM/dd/yyyy", null) == DateTime.ParseExact("06/01/2020","MM/dd/yyyy", null))
                        {
                            lblopenbal.Text = "495936";
                        }
                        else
                        {
                                con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                                cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where  h.head_name!='Opening Balance (MCB)' and h.head_name!='Opening Balance (BOP)' and h.head_name!='Opening Balance (BOK)'  and   d.DUESTYPE='income' and d.DATE>='" + from + "' and d.DATE<'" + to + "'  GROUP BY h.HEAD_NAME", con);
                                da = new SqlDataAdapter();
                                da.SelectCommand = cmd;
                                dt = new DataTable();
                                da.Fill(dt);
                                PrintRepeaterCR.DataSource = dt;
                                PrintRepeaterCR.DataBind();
                                if (dt.Rows.Count >= 0)
                                {

                                    double income = 0;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {

                                        income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                                    }

                                    /*cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where (d.exp_type='e' or d.exp_type='w') and d.modes_of_payments_fid!=4 and d.DATE>='" + from.ToString("MM/dd/yyyy") + "' and d.DATE<'" + to.ToString("MM/dd/yyyy") + "'  GROUP BY h.HEAD_NAME", con);
                                    da = new SqlDataAdapter();
                                    da.SelectCommand = cmd;
                                    dt = new DataTable();
                                    da.Fill(dt);
                                    double toinc = 0;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {

                                        toinc += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                                    }*/
                                    cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where (d.exp_type='e' or d.exp_type='w') and d.modes_of_payments_fid!=4 and d.DATE>='" + from + "' and d.DATE<'" + to + "'  GROUP BY h.HEAD_NAME", con);
                                    da = new SqlDataAdapter();
                                    da.SelectCommand = cmd;
                                    dt = new DataTable();
                                    da.Fill(dt);
                                    double toexp = 0;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {

                                        toexp += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                                    }
                                    //income
                                    lbltotal1.Text = (double.Parse(income.ToString()) + double.Parse(lblopenbal.Text) + double.Parse(toexp.ToString())).ToString();
                                    lbldatetoday.Text = System.DateTime.Now.ToString();
                                    lbldatefrom.Text = datefrom;
                                    lbldateto.Text = dateto;
                                }
                                cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.DUESTYPE='expense' and d.DATE>='" + from + "' and d.DATE<'" + to + "'  GROUP BY h.HEAD_NAME", con);
                                da = new SqlDataAdapter();
                                da.SelectCommand = cmd;
                                dt = new DataTable();
                                da.Fill(dt);
                                RepeaterDR.DataSource = dt;
                                RepeaterDR.DataBind();
                                if (dt.Rows.Count >= 0)
                                {
                                    double expense = 0;

                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        expense += (double.Parse(dt.Rows[i]["DrRs"].ToString()));

                                    }

                                    cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where h.head_name!='Opening Balance (MCB)' and h.head_name!='Opening Balance (BOP)' and h.head_name!='Opening Balance (BOK)'  and  (d.exp_type='d' or d.exp_type='od') and d.modes_of_payments_fid!=4 and d.DATE>='" + from + "' and d.DATE<'" + to + "'  GROUP BY h.HEAD_NAME", con);
                                    da = new SqlDataAdapter();
                                    da.SelectCommand = cmd;
                                    dt = new DataTable();
                                    da.Fill(dt);
                                    double toinc = 0;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {

                                        toinc += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                                    }
                                    //expense
                                    lbltotal.Text = (double.Parse(expense.ToString()) + double.Parse(toinc.ToString())).ToString();

                                    lbldatetoday.Text = System.DateTime.Now.ToString();
                                    lbldatefrom.Text = datefrom;
                                    lbldateto.Text = dateto;

                                }
                             lblopenbal.Text = (double.Parse(lbltotal1.Text) - double.Parse(lbltotal.Text)).ToString("#,##0");
                           
                        }
                        from = to;
                        to = DateTime.ParseExact(from, "MM/dd/yyyy", null).AddMonths(+1).ToString("MM/dd/yyyy");


                    }

                }
                string t1 = "";
                string t = "";
                cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.MODES_OF_PAYMENTS_FID=4 and d.DUESTYPE='income' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.exp_type='od' and d.MODES_OF_PAYMENTS_FID!=4 and d.DUESTYPE='income' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = i + 1; j < dt.Rows.Count; j++)
                        {
                            if (dt.Rows[i]["HEAD_NAME"].Equals(dt.Rows[j]["HEAD_NAME"].ToString()))
                            {
                                string rev = dt.Rows[i]["CrRs"].ToString();
                                string next = dt.Rows[j]["CrRs"].ToString();
                                dt.Rows[i]["CrRs"] = (double.Parse(dt.Rows[i]["CrRs"].ToString()) + double.Parse(dt.Rows[j]["CrRs"].ToString())).ToString();
                                DataRow dr = dt.Rows[j];
                                if (dt.Rows[i]["HEAD_NAME"].ToString() == dt.Rows[j]["HEAD_NAME"].ToString())
                                {
                                    dr.Delete();
                                    dt.AcceptChanges();
                                }
                            }
                        }
                    }
                }

                PrintRepeaterCR.DataSource = dt;
                PrintRepeaterCR.DataBind();
                if (dt.Rows.Count > 0)
                {

                    double income = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        income += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }

                    cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',p.MODES_OF_PAYMENT_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on p.MODES_OF_PAYMENTS_ID=d.MODES_OF_PAYMENTS_FID where (d.exp_type='e' or d.exp_type='w') and d.modes_of_payments_fid!=4 and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY p.MODES_OF_PAYMENT_NAME", con);
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);
                    double toinc = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        toinc += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }
                    cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'CrRS',p.MODES_OF_PAYMENT_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on p.MODES_OF_PAYMENTS_ID=d.MODES_OF_PAYMENTS_FID where (d.exp_type='e' or d.exp_type='w') and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY p.MODES_OF_PAYMENT_NAME", con);
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = i + 1; j < dt.Rows.Count; j++)
                        {
                            if (dt.Rows[i]["MODES_OF_PAYMENT_NAME"].Equals(dt.Rows[j]["MODES_OF_PAYMENT_NAME"].ToString()))
                            {
                                string rev = dt.Rows[i]["CrRs"].ToString();
                                string next = dt.Rows[j]["CrRs"].ToString();
                                dt.Rows[i]["CrRs"] = (double.Parse(dt.Rows[i]["CrRs"].ToString()) + double.Parse(dt.Rows[j]["CrRs"].ToString())).ToString();
                                DataRow dr = dt.Rows[j];
                                if (dt.Rows[i]["MODES_OF_PAYMENT_NAME"].ToString() == dt.Rows[j]["MODES_OF_PAYMENT_NAME"].ToString())
                                {
                                    dr.Delete();
                                    dt.AcceptChanges();
                                }
                            }
                        }
                    }

                    //double totalb = 0;
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{

                    //    totalb += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    //}
                    //DataTable mytb = new DataTable();

                    //mytb.Columns.Add("MODES_OF_PAYMENT_NAME");
                    //mytb.Columns.Add("CrRS");
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{

                    //}
                    //    DataRow _ravi = mytb.NewRow();
                    //_ravi["MODES_OF_PAYMENT_NAME"] = dt.Rows[0]["MODES_OF_PAYMENT_NAME"].ToString();
                    //_ravi["CrRS"] =  totalb.ToString();
                    //mytb.Rows.Add(_ravi);
                    RepeaterBANK.DataSource = dt;
                    RepeaterBANK.DataBind();

                    double toexp = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        toexp += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }
                    //expense
                    lbltotal1.Text = (double.Parse(income.ToString()) + double.Parse(lblopenbal.Text) + double.Parse(toexp.ToString())).ToString();
                    t1 = lbltotal1.Text;
                    lbltotal1.Text = (double.Parse(income.ToString()) + double.Parse(lblopenbal.Text) + double.Parse(toexp.ToString())).ToString("#,##0");

                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = datefrom;
                    lbldateto.Text = dateto;

                }


                cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where d.DUESTYPE='expense' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
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

                    cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'CrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID where (d.exp_type='d' or d.exp_type='od') and d.modes_of_payments_fid!=4 and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);
                    double toinc = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        toinc += (double.Parse(dt.Rows[i]["CrRs"].ToString()));
                    }


                    //income
                    lbltotal.Text = (double.Parse(expense.ToString()) + double.Parse(toinc.ToString())).ToString();
                    t = lbltotal.Text;
                    lbltotal.Text = (double.Parse(expense.ToString()) + double.Parse(toinc.ToString())).ToString("#,##0");

                    lbldatetoday.Text = System.DateTime.Now.ToString();
                    lbldatefrom.Text = datefrom;
                    lbldateto.Text = dateto;

                }

                /////Bank Balance
                //datefrom= "01/01/0001";
                //double bopexp = 0;
                //cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='BOP Bank' and duestype='expense' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "' GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);                

                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopexp += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}


                //cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='BOP Bank' and duestype='income'  and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //double bopincome = 0;
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopincome += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}

                //lblbop.Text = (bopincome - bopexp).ToString("#,##0");
                //bopexp = bopincome = 0;

                //cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='BOK Bank'  and duestype='expense' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "'  GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopexp += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}
                //cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='BOK Bank'  and duestype='income' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "' GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopincome += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}
                //lblbok.Text = (bopincome- bopexp).ToString("#,##0");
                //bopexp = bopincome = 0;

                //cmd = new SqlCommand("select SUM(d.EXPENSE_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='MCB Bank' and duestype='expense'  and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "' GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopexp += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}
                //cmd = new SqlCommand("select SUM(d.INCOME_AMOUNT) as 'DrRS',h.HEAD_NAME from DUES d inner join HEADS h on h.HEAD_ID=d.HEAD_FID inner join MODES_OF_PAYMENTS p on d.MODES_OF_PAYMENTS_FID=p.MODES_OF_PAYMENTS_ID where p.MODES_OF_PAYMENT_NAME='MCB Bank' and duestype='income' and d.DATE>='" + datefrom + "' and d.DATE<='" + dateto + "' GROUP BY h.HEAD_NAME", con);
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        if (dt.Rows[i]["DrRs"].ToString() == "")
                //        {
                //            dt.Rows[i][""] = "0";
                //        }
                //        bopincome += (double.Parse(dt.Rows[i]["DrRs"].ToString()));
                //    }
                //}
                //lblmcb.Text = (bopincome- bopexp).ToString("#,##0");


                con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                cmd = new SqlCommand("", con);
                da = new SqlDataAdapter();
                dt = new DataTable();


                cmd = new SqlCommand("select duestype,exp_type,i.DATE as 'Date',i.VOUCHER_NO as 'Voucher',i.DESCRIPTION as 'Desc',INCOME_AMOUNT as 'CrRs',EXPENSE_AMOUNT as 'DrRs',i.PIC as 'Doc',v.VENDOR_NAME as 'Vendor',h.HEAD_NAME as 'Head',m.MODES_OF_PAYMENT_NAME as 'Mode',u.USER_NAME as 'username' from DUES i inner join VENDORS v on i.VENDOR_FID=v.VENDOR_ID inner join USERS u on i.USER_FID=u.USER_ID inner join HEADS h on h.HEAD_ID=i.HEAD_FID inner join MODES_OF_PAYMENTS m on m.MODES_OF_PAYMENTS_ID=i.MODES_OF_PAYMENTS_FID  WHERE i.DATE>='" + datefrom + "' and i.DATE<='" + dateto + "' ORDER BY i.DATE ASC", con);
                da.SelectCommand = cmd;
                da.Fill(dt);
                dt.Columns.Add("bal", typeof(System.Int64));
                Int64 totalbal = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["exp_type"].ToString() == "" && dt.Rows[i]["duestype"].ToString() == "income")
                    {
                        totalbal = totalbal + Int64.Parse(dt.Rows[i]["CrRs"].ToString());
                        dt.Rows[i]["bal"] = totalbal;
                        dt.Rows[i]["exp_type"] = "Cash Income";
                        dt.Rows[i]["CrRs"] = dt.Rows[i]["CrRs"].ToString();
                        dt.Rows[i]["DrRs"] = "0";
                    }
                    if (dt.Rows[i]["exp_type"].ToString() == "" && dt.Rows[i]["duestype"].ToString() == "expense")
                    {
                        totalbal = totalbal - Int64.Parse(dt.Rows[i]["DrRs"].ToString());
                        dt.Rows[i]["bal"] = totalbal;
                        dt.Rows[i]["exp_type"] = "Cash Expense";
                        dt.Rows[i]["DrRs"] = dt.Rows[i]["DrRs"].ToString();
                        dt.Rows[i]["CrRs"] = "0";
                    }
                    if (dt.Rows[i]["exp_type"].ToString() == "e")
                    {
                        totalbal = totalbal - Int64.Parse(dt.Rows[i]["DrRs"].ToString());
                        dt.Rows[i]["bal"] = totalbal;
                        dt.Rows[i]["exp_type"] = "Bank Expense";
                    }
                    if (dt.Rows[i]["exp_type"].ToString() == "d")
                    {
                        totalbal = totalbal + Int64.Parse(dt.Rows[i]["DrRs"].ToString());
                        dt.Rows[i]["bal"] = totalbal;
                        dt.Rows[i]["exp_type"] = "Bank Deposit";
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
                        dt.Rows[i]["exp_type"] = "Bank Withdraw";
                        dt.Rows[i]["DrRs"] = dt.Rows[i]["CrRs"].ToString();
                        dt.Rows[i]["CrRs"] = "0";
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
                    lblrec.Text = income.ToString("#,##0");

                    lblexpen.Text = expense.ToString("#,##0");
                    lblsur.Text = (income - expense).ToString("#,##0");



                    lblclosebal.Text = (Convert.ToInt32(t1) - Convert.ToInt32(t)).ToString("#,##0");




                }




            }
        }
      

        protected void btnback_Click1(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx");
        }
    }
}