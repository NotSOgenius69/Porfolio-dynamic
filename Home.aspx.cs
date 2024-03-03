using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Porfolio_dynamic
{
    public partial class Home : System.Web.UI.Page
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
                object result1 = command1.ExecuteScalar();
                object result2 = command2.ExecuteScalar();
                object result3 = command3.ExecuteScalar();
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
                con.Close();
            }
            catch (Exception ex)
            {
                PhoneNoLabel.Text = ex.Message;
                EmailLabel.Text = ex.Message;
                AddressLabel.Text = ex.Message;
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameId.Value;
                string email = emailId.Value;
                string msg = messageId.Value;

                if(name != "" && email!="" && msg!="")
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();

                    SqlCommand command = new SqlCommand("insert into Messages values(@name,@email,@message)", con);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@message", msg);
                    command.ExecuteNonQuery();
                    HudaiLabel.Text = "Message Send";
                    nameId.Value = "";
                    emailId.Value = "";
                    messageId.Value = "";
                    con.Close();
                }
                else
                {
                    HudaiLabel.Text = "Please fill out all the fields";
                }
                
            }
            catch(Exception ex) {
                HudaiLabel.Text = ex.Message;
            }
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}