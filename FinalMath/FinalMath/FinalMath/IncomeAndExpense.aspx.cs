using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class IncomeAndExpense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

              

                SqlCommand cmd = new SqlCommand("select * from Heads h inner join HEADTYPES t on t.HEADTYPE_ID=h.HEADTYPE_FID where t.HEAD_TYPE='income'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlinchead.DataSource = dt;
                ddlinchead.DataTextField ="HEAD_NAME";
                ddlinchead.DataValueField ="HEAD_ID";
                ddlinchead.DataBind();


                 cmd = new SqlCommand("select * from MODES_OF_PAYMENTS", con);
                 da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                 dt = new DataTable();
                da.Fill(dt);
                ddlincpaymentmode.DataSource = dt;
                ddlincpaymentmode.DataTextField = "MODES_OF_PAYMENT_NAME";
                ddlincpaymentmode.DataValueField = "MODES_OF_PAYMENTS_ID";
                ddlincpaymentmode.DataBind();




                cmd = new SqlCommand("select * from VENDORS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlincvendor.DataSource = dt;
                ddlincvendor.DataTextField = "VENDOR_NAME";
                ddlincvendor.DataValueField = "VENDOR_ID";
                ddlincvendor.DataBind();

                cmd = new SqlCommand("select * from USERS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlincuser.DataSource = dt;
                ddlincuser.DataTextField = "USER_NAME";
                ddlincuser.DataValueField = "USER_ID";
                ddlincuser.DataBind();

                cmd = new SqlCommand("select * from Heads h inner join HEADTYPES t on t.HEADTYPE_ID=h.HEADTYPE_FID where t.HEAD_TYPE='expense'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexphead.DataSource = dt;
                ddlexphead.DataTextField = "HEAD_NAME";
                ddlexphead.DataValueField = "HEAD_ID";
                ddlexphead.DataBind();




                cmd = new SqlCommand("select * from MODES_OF_PAYMENTS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexppaymentmode.DataSource = dt;
                ddlexppaymentmode.DataTextField = "MODES_OF_PAYMENT_NAME";
                ddlexppaymentmode.DataValueField = "MODES_OF_PAYMENTS_ID";
                ddlexppaymentmode.DataBind();




                cmd = new SqlCommand("select * from VENDORS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexpvendor.DataSource = dt;
                ddlexpvendor.DataTextField = "VENDOR_NAME";
                ddlexpvendor.DataValueField = "VENDOR_ID";
                ddlexpvendor.DataBind();

                cmd = new SqlCommand("select * from USERS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexpuser.DataSource = dt;
                ddlexpuser.DataTextField = "USER_NAME";
                ddlexpuser.DataValueField = "USER_ID";
                ddlexpuser.DataBind();
            }
        }

        protected void btnincsave_Click(object sender, EventArgs e)
        {
            String path = "images/" + fileuploaderinc.FileName;
            if (fileuploaderinc.HasFile)
            {
                 path = "images/" + fileuploaderinc.FileName;
                String root = Server.MapPath(path);
                fileuploaderinc.SaveAs(root);
            }

            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("insert into incomes (INCOME_DATE,VOUCHER_NO,VENDOR_FID,USER_FID,HEAD_FID,MODES_OF_PAYMENTS_FID,INCOME_AMOUNT,INCOME_DESCRIPTION,INCOME_PIC)values('"+txtincdate.Text+"','"+txtincvoucher.Text+"','"+ddlincvendor.SelectedValue+"','"+ddlincuser.SelectedValue+"','"+ddlinchead.SelectedValue+"','"+ddlexppaymentmode.SelectedValue+"','"+txtincamount.Text+"','"+txtincdesc.Text+"','"+path+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtincdate.Text = "";
            txtincamount.Text = "";
            txtincdesc.Text = "";
           txtincvoucher.Text = "";
            ddlinchead.SelectedIndex = 0;
            ddlincpaymentmode.SelectedIndex = 0;
            ddlincuser.SelectedIndex = 0;
            
            ddlincvendor.SelectedIndex = 0;



        }
        protected void btnexpsave_Click(object sender, EventArgs e)
        {
            String path = "images/" + fileiploaderexp.FileName;
            if (fileuploaderinc.HasFile)
            {
                path = "images/" + fileiploaderexp.FileName;
                String root = Server.MapPath(path);
                fileuploaderinc.SaveAs(root);
            }

            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("insert into EXPENCES (EXPENSE_DATE,VOUCHER_NO,VENDOR_FID,USER_FID,HEAD_FID,MODES_OF_PAYMENTS_FID,EXPENSE_AMOUNT,EXPENSE_DESCRIPTION,EXPENSE_PIC)values('" + txtexpdate.Text + "','" + txtexpvoucher.Text + "','" + ddlexpvendor.SelectedValue + "','" + ddlexpuser.SelectedValue + "','" + ddlexphead.SelectedValue + "','" + ddlexppaymentmode.SelectedValue + "','" + txtexpamount.Text + "','" + txtexpdesc.Text + "','" + path + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtexpdate.Text = "";
            txtexpamount.Text = "";
            txtexpdesc.Text = "";
            txtexpvoucher.Text = "";
            ddlexphead.SelectedIndex = 0;
            ddlexppaymentmode.SelectedIndex = 0;
            ddlexpuser.SelectedIndex = 0;
            ddlexpvendor.SelectedIndex = 0;


        }
    }
}