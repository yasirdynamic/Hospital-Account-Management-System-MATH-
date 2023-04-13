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
    public partial class VendorsLimits : System.Web.UI.Page
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

                cmd = new SqlCommand("select * from VENDORS", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                ddlvendor.DataSource = dt;
                ddlvendor.DataTextField = "VENDOR_NAME";
                ddlvendor.DataValueField = "VENDOR_ID";
                ddlvendor.DataBind();

             

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
           
            if (ddlchead.SelectedItem.Value != "-1")
            {
                filter += " AND HEAD_FID = '" + ddlchead.SelectedItem.Value + "'";
            }

            if (ddlvendor.SelectedItem.Value != "-1")
            {
                filter += " AND VENDOR_FID = '" + ddlvendor.SelectedItem.Value + "'";
            }
          

            if (ddltype.SelectedItem.Text=="income")
            {
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

                SqlCommand cmd = new SqlCommand("SELECT m.vendor_id,m.vendor_name,m.VENDOR_ADDRESS,m.VENDOR_PHONE,m.VENDOR_DESCRIPTION,Sum(d.income_amount) as 'Balance'  FROM vendors m inner join dues d on d.vendor_fid=m.vendor_id  WHERE d.duestype='income' " + filter + " group by m.vendor_id,m.vendor_name,m.VENDOR_ADDRESS,m.VENDOR_PHONE,m.VENDOR_DESCRIPTION order by balance desc ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                IncomeGridView.DataSource = dt;
                IncomeGridView.DataBind();
                IncomeGridView.Visible = true;

            }
            if (ddltype.SelectedItem.Text == "expense")
            {
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");

                SqlCommand cmd = new SqlCommand("SELECT m.vendor_id,m.vendor_name,m.VENDOR_ADDRESS,m.VENDOR_PHONE,m.VENDOR_DESCRIPTION,Sum(d.expense_amount) as 'Balance'  FROM vendors m inner join dues d on d.vendor_fid=m.vendor_id  WHERE d.duestype='expense' " + filter + " group by m.vendor_id,m.vendor_name,m.VENDOR_ADDRESS,m.VENDOR_PHONE,m.VENDOR_DESCRIPTION order by balance desc ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                IncomeGridView.DataSource = dt;
                IncomeGridView.DataBind();
                IncomeGridView.Visible = true;
            }

           
            
        
        }
    }
}