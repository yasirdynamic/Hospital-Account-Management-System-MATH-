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
    public partial class ManageBankTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnauto.Visible = false;
            btnmanual.Checked = true;
            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("select max(DUES_ID) as 'id' from DUES", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            String id = dt.Rows[0]["id"].ToString();

            cmd = new SqlCommand("select * from DUES where DUES_ID='" + id + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            String voucherid = "";
            if (dt.Rows.Count > 0)
            {
                voucherid = dt.Rows[0]["VOUCHER_NO"].ToString();
            }
            cmd = new SqlCommand("select * from DUES where VOUCHER_NO='" + voucherid + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            lblvoucher.Text = dt.Rows.Count.ToString();
            lblvouchername.Text = voucherid;
            if (!IsPostBack)
            {

                rdobtnexpen.Checked = true;
                btnauto.Visible = false;
                btnmanual.Checked = true;
                if (btnauto.Checked)
                {
                    txtincamount.Visible = false;
                    ddlinchead.Visible = false;

                }
                if (btnmanual.Checked)
                {

                    txtincamount.Visible = true;
                    ddlinchead.Visible = true;
                }
                cmd = new SqlCommand("select * from Heads h inner join HEADTYPES t on t.HEADTYPE_ID=h.HEADTYPE_FID where t.HEAD_TYPE='income'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlinchead.DataSource = dt;
                ddlinchead.DataTextField = "HEAD_NAME";
                ddlinchead.DataValueField = "HEAD_ID";
                ddlinchead.DataBind();

                cmd = new SqlCommand("select max(DUES_ID) as 'id' from DUES", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                id = dt.Rows[0]["id"].ToString();
                cmd = new SqlCommand("select * from DUES where DUES_ID='" + id + "'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    voucherid = dt.Rows[0]["VOUCHER_NO"].ToString();
                }

                cmd = new SqlCommand("select * from DUES where VOUCHER_NO='" + voucherid + "'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                lblvoucher.Text = dt.Rows.Count.ToString();
                lblvouchername.Text = voucherid;



                cmd = new SqlCommand("select * from MODES_OF_PAYMENTS p where p.MODES_OF_PAYMENT_NAME!='Cash'", con);
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

                cmd = new SqlCommand("select * from DISTYPE", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddldistype.DataSource = dt;
                ddldistype.DataTextField = "DISTYPENAME";
                ddldistype.DataValueField = "DISTYPE_ID";
                ddldistype.DataBind();
                cmd = new SqlCommand("select * from DISTYPE", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexpdistype.DataSource = dt;
                ddlexpdistype.DataTextField = "DISTYPENAME";
                ddlexpdistype.DataValueField = "DISTYPE_ID";
                ddlexpdistype.DataBind();

                cmd = new SqlCommand("select * from Heads h inner join HEADTYPES t on t.HEADTYPE_ID=h.HEADTYPE_FID where t.HEAD_TYPE='expense'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlexphead.DataSource = dt;
                ddlexphead.DataTextField = "HEAD_NAME";
                ddlexphead.DataValueField = "HEAD_ID";
                ddlexphead.DataBind();




                cmd = new SqlCommand("select * from MODES_OF_PAYMENTS p where p.MODES_OF_PAYMENT_NAME!='Cash' ", con);
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

            }

        }

        protected void btnincsave_Click(object sender, EventArgs e)
        {
            String voucherid = "";
            string id = "";
            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("", con);
            String usernname = (String)Session["AccInfo"];
          
            if (btnmanual.Checked)
            {
                String path = "images/" + fileuploaderinc.FileName;
                if (fileuploaderinc.HasFile)
                {
                    path = "images/" + fileuploaderinc.FileName;
                    String root = Server.MapPath(path);
                    fileuploaderinc.SaveAs(root);
                }

                if (rbtnwith.Checked)
                {
                    cmd = new SqlCommand("insert into DUES (DATE,VOUCHER_NO,VENDOR_FID,USER_FID,HEAD_FID,MODES_OF_PAYMENTS_FID,EXPENSE_AMOUNT,INCOME_AMOUNT,DESCRIPTION,PIC,DISTYPE_FID,DUESTYPE,exp_type)values('" + txtincdate.Text + "','" + txtincvoucher.Text + "','" + ddlincvendor.SelectedValue + "','" + usernname + "','" + ddlinchead.SelectedValue + "','" + ddlincpaymentmode.SelectedValue + "','0','" + txtincamount.Text + "','" + txtincdesc.Text + "','" + path + "','" + ddldistype.SelectedValue + "','income','w')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                if (rbtndep.Checked)
                {
                    cmd = new SqlCommand("insert into DUES (DATE,VOUCHER_NO,VENDOR_FID,USER_FID,HEAD_FID,MODES_OF_PAYMENTS_FID,EXPENSE_AMOUNT,INCOME_AMOUNT,DESCRIPTION,PIC,DISTYPE_FID,DUESTYPE,exp_type)values('" + txtincdate.Text + "','" + txtincvoucher.Text + "','" + ddlincvendor.SelectedValue + "','" + usernname + "','" + ddlinchead.SelectedValue + "','" + ddlincpaymentmode.SelectedValue + "','0','" + txtincamount.Text + "','" + txtincdesc.Text + "','" + path + "','" + ddldistype.SelectedValue + "','income','od')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }


                /*txtincdate.Text = "";
                txtincamount.Text = "";
                txtincdesc.Text = "";
                txtincvoucher.Text = "";
                ddlinchead.SelectedIndex = 0;
                ddlincpaymentmode.SelectedIndex = 0;
                ddldistype.SelectedIndex = 0;
                ddlincvendor.SelectedIndex = 0;*/
            }


             cmd = new SqlCommand("select max(DUES_ID) as 'id' from DUES", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            id = dt.Rows[0]["id"].ToString();
            cmd = new SqlCommand("select * from DUES where DUES_ID='" + id + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                voucherid = dt.Rows[0]["VOUCHER_NO"].ToString();
            }

            cmd = new SqlCommand("select * from DUES where VOUCHER_NO='" + voucherid + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            lblvoucher.Text = dt.Rows.Count.ToString();
            lblvouchername.Text = voucherid;



        }
        protected void btnexpsave_Click(object sender, EventArgs e)
        {
            string exptype = string.Empty;
            if (rdobtndesposit.Checked==true)
            {
                exptype = "d";
            }
            if (rdobtnexpen.Checked == true)
            {
                exptype = "e";
            }


            String usernname = (String)Session["AccInfo"];
            String path = "images/" + fileiploaderexp.FileName;
            if (fileuploaderinc.HasFile)
            {
                path = "images/" + fileiploaderexp.FileName;
                String root = Server.MapPath(path);
                fileuploaderinc.SaveAs(root);
            }

            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("insert into DUES (DATE,VOUCHER_NO,VENDOR_FID,USER_FID,HEAD_FID,MODES_OF_PAYMENTS_FID,EXPENSE_AMOUNT,INCOME_AMOUNT,DESCRIPTION,PIC,DISTYPE_FID,DUESTYPE,exp_type)values('" + txtexpdate.Text + "','" + txtexpvoucher.Text + "','" + ddlexpvendor.SelectedValue + "','" + usernname + "','" + ddlexphead.SelectedValue + "','" + ddlexppaymentmode.SelectedValue + "','" + txtexpamount.Text + "','0','" + txtexpdesc.Text + "','" + path + "','" + ddlexpdistype.SelectedValue + "','expense','"+exptype+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            /*
            txtexpdate.Text = "";
            txtexpamount.Text = "";
            txtexpdesc.Text = "";
            txtexpvoucher.Text = "";
            ddlexphead.SelectedIndex = 0;
            ddlexppaymentmode.SelectedIndex = 0;
            ddlexpdistype.SelectedIndex = 0;
            ddlexpvendor.SelectedIndex = 0;*/
            string id="";
            string voucherid = "";
            cmd = new SqlCommand("select max(DUES_ID) as 'id' from DUES", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            id = dt.Rows[0]["id"].ToString();
            cmd = new SqlCommand("select * from DUES where DUES_ID='" + id + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                voucherid = dt.Rows[0]["VOUCHER_NO"].ToString();
            }

            cmd = new SqlCommand("select * from DUES where VOUCHER_NO='" + voucherid + "'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            lblvoucher.Text = dt.Rows.Count.ToString();
            lblvouchername.Text = voucherid;


        }

        protected void btnauto_CheckedChanged(object sender, EventArgs e)
        {
            if (btnauto.Checked)
            {
                txtincamount.Visible = false;
                ddlinchead.Visible = false;

            }
            if (btnmanual.Checked)
            {

                txtincamount.Visible = true;
                ddlinchead.Visible = true;
            }
        }

        protected void btnmanual_CheckedChanged(object sender, EventArgs e)
        {
            if (btnauto.Checked)
            {
                txtincamount.Visible = false;
                ddlinchead.Visible = false;

            }
            if (btnmanual.Checked)
            {

                txtincamount.Visible = true;
                ddlinchead.Visible = true;
            }
        }
    }
}