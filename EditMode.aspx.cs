using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porfolio_dynamic
{
    public partial class contactEdit : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand command1 = new SqlCommand("SELECT Info FROM contactInfos WHERE Title='PhoneNo'", con);
                SqlCommand command2 = new SqlCommand("SELECT Info FROM contactInfos WHERE Title='Email'", con);
                SqlCommand command3 = new SqlCommand("SELECT Info FROM contactInfos WHERE Title='Address'", con);
                SqlCommand command4 = new SqlCommand("select count(Name) from Messages", con);
                object result1 = command1.ExecuteScalar();
                object result2 = command2.ExecuteScalar();
                object result3 = command3.ExecuteScalar();
                object result4 = command4.ExecuteScalar();
                if (result1 != null)
                {
                    string info = result1.ToString();
                    PhoneNoLabel.Text = info;
                }
                else
                {
                    PhoneNoLabel.Text = "Nothing to show";
                }
                if (result2 != null)
                {
                    string info = result2.ToString();
                    EmailLabel.Text = info;
                }
                else
                {
                    EmailLabel.Text = "Nothing to show";
                }
                if (result3 != null)
                {
                    string info = result3.ToString();
                    AddressLabel.Text = info;
                }
                else
                {
                    AddressLabel.Text = "Nothing to show";
                }
                if (result4 != null)
                {
                    string info = result4.ToString();
                    MsgLabel.Text = info+" Unread Messages.";
                }
                else
                {
                    MsgLabel.Text = "Nothing to show";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                PhoneNoLabel.Text = ex.Message;
                EmailLabel.Text = ex.Message;
                AddressLabel.Text = ex.Message;
                MsgLabel.Text = ex.Message;
            }
        }

        protected void contactEditbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactAdmin.aspx");
        }
        protected void Showbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MessagesAdmin.aspx");
        }

        protected void logoutbtn_Click(Object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}