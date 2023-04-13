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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("select SUM(i.INCOME_AMOUNT) as totalinc from DUES i", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0]["totalinc"].ToString() == "")
                {
                    lblincome.Text = "0";
                }
                else
                {
                    lblincome.Text = dt.Rows[0]["totalinc"].ToString();
                }



                cmd = new SqlCommand("select SUM(i.EXPENSE_AMOUNT) as totalexp from DUES i", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0]["totalexp"].ToString() == "")
                {
                    lblexp.Text = "0";
                }
                else
                {
                    lblexp.Text = dt.Rows[0]["totalexp"].ToString();
                }



                double pl = double.Parse(lblincome.Text) - double.Parse(lblexp.Text);
                lblprofitloss.Text = pl.ToString();



                cmd = new SqlCommand("select SUM(i.INCOME_AMOUNT) as donation from DUES i inner join HEADS h on h.HEAD_ID=i.HEAD_FID where h.HEAD_NAME='Donation' OR h.HEAD_NAME='donation'", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lbldonation.Text = dt.Rows[0]["donation"].ToString();
                }
                else
                {
                    lbldonation.Text = "0";
                }
                cmd = new SqlCommand("select * from VENDORS v where v.isActive=1", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                lblVend.Text = dt.Rows.Count.ToString();

                cmd = new SqlCommand("select * from PATIENT_INFO v where v.isActive=1", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                lblpat.Text = dt.Rows.Count.ToString();


                cmd = new SqlCommand("select * from USERS u where u.IsActive=1", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                lbluser.Text = dt.Rows.Count.ToString();

                cmd = new SqlCommand("select * from EMPLOYEES u where u.IsActive=1", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                lblemp.Text = dt.Rows.Count.ToString();



            }
        }
    }
}