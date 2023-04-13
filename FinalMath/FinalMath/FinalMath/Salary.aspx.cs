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
    public partial class Salary : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
        SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                cmd = new SqlCommand("select * from Employees", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlemp.DataSource = dt;
                ddlemp.DataTextField = "EMPLOYEE_NAME";
                ddlemp.DataValueField = "EMPLOYEE_ID";
                ddlemp.DataBind();
                ddlemp.Items.Insert(0, new ListItem("Select Employee", "0"));
            }

        }

        protected void ddlemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlemp.SelectedValue!="0")
            {
                cmd = new SqlCommand("select * from Employees where EMPLOYEE_ID='" + ddlemp.SelectedValue + "'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbasicsal.Text = dt.Rows[0]["EMPLOYEE_MONTHLY_SALARY"].ToString();
                txtallow.Text = dt.Rows[0]["EMPLOYEE_ALLOWENCES"].ToString();
                txtemp_type.Text = dt.Rows[0]["EMPLOYEE_TYPE"].ToString();
                txttotalsal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text)).ToString();
                txtgtotal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text) + decimal.Parse(txtextraduty.Text)).ToString();
                
                DateTime date = DateTime.Parse(txtdate.Text);
                int monthno = date.Month;
                int year = date.Year;
                int nodays = DateTime.DaysInMonth(year, monthno);
                txtabscentamount.Text = Math.Round((decimal.Parse(txtbasicsal.Text) / nodays) * decimal.Parse(txtdays.Text)).ToString();
                txtnetsal.Text = (decimal.Parse(txtgtotal.Text) - decimal.Parse(txtadvanceamount.Text) - decimal.Parse(txtabscentamount.Text)).ToString();

            }
            
        }

        protected void txtextraduty_TextChanged(object sender, EventArgs e)
        {
            txttotalsal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text)).ToString();
            txtgtotal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text) + decimal.Parse(txtextraduty.Text)).ToString();
            DateTime date = DateTime.Parse(txtdate.Text);
            int monthno = date.Month;
            int year = date.Year;
            int nodays = DateTime.DaysInMonth(year, monthno);
            txtabscentamount.Text = Math.Round((decimal.Parse(txtbasicsal.Text) / nodays) * decimal.Parse(txtdays.Text)).ToString();
            txtnetsal.Text = (decimal.Parse(txtgtotal.Text) - decimal.Parse(txtadvanceamount.Text) - decimal.Parse(txtabscentamount.Text)).ToString();

        }

        protected void txtdays_TextChanged(object sender, EventArgs e)
        {
            txttotalsal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text)).ToString();
            txtgtotal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text) + decimal.Parse(txtextraduty.Text)).ToString();
            DateTime date = DateTime.Parse(txtdate.Text);
            int monthno = date.Month;
            int year = date.Year;
            int nodays = DateTime.DaysInMonth(year, monthno);
            txtabscentamount.Text = Math.Round((decimal.Parse(txtbasicsal.Text) / nodays) * decimal.Parse(txtdays.Text)).ToString();
            txtnetsal.Text = (decimal.Parse(txtgtotal.Text) - decimal.Parse(txtadvanceamount.Text) - decimal.Parse(txtabscentamount.Text)).ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO salary (EMPLOYEE_FID,EXTRA_DUTY,TOTAL_SALARY,ADVANCE_AMOUNT,ABSENT_DAYS,BY_CHEQUE,BY_CASH,NET_SALARY,SALARY_DATE,ABSENT_AMOUNT) VALUES('"+ddlemp.SelectedValue+ "','"+txtextraduty.Text+ "','"+txtgtotal.Text+ "','"+txtadvanceamount.Text+ "','"+txtdays.Text+ "','"+txtbycheque.Text+ "','"+txtbycash.Text+ "','"+txtnetsal.Text+ "','"+txtdate.Text+ "','"+txtabscentamount.Text+ "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "Saved Salary for: "+ddlemp.SelectedItem.Text;
            lblmsg.Visible = true;
        }

        protected void txtadvanceamount_TextChanged(object sender, EventArgs e)
        {
            txttotalsal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text)).ToString();
            txtgtotal.Text = (decimal.Parse(txtbasicsal.Text) + decimal.Parse(txtallow.Text) + decimal.Parse(txtextraduty.Text)).ToString();
            DateTime date = DateTime.Parse(txtdate.Text);
            int monthno = date.Month;
            int year = date.Year;
            int nodays = DateTime.DaysInMonth(year, monthno);
            txtabscentamount.Text = Math.Round((decimal.Parse(txtbasicsal.Text) / nodays) * decimal.Parse(txtdays.Text)).ToString();
            txtnetsal.Text = (decimal.Parse(txtgtotal.Text) - decimal.Parse(txtadvanceamount.Text) - decimal.Parse(txtabscentamount.Text)).ToString();


        }
    }
}