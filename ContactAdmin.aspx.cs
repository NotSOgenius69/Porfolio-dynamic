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
    public partial class ContactAdmin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updatebtn1_Click(object sender, EventArgs e)
        {
            EmailId.Text = "";
            AddressId.Text = "";
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            try
            {
                if (string.IsNullOrEmpty(PhoneId.Text))
                {
                    Label1.Text = "Please fill out the field";
                }
                else
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();

                    SqlCommand command = new SqlCommand("UPDATE contactInfos SET Info=@info where Title='PhoneNo'", con);
                    command.Parameters.AddWithValue("@info", PhoneId.Text.Trim());
                    command.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Successfully Updated";
                    PhoneId.Text = "";
                }
            }
            catch(Exception ex) {
                Label1.Text = ex.Message;
            }
        }

        protected void updatebtn2_Click(object sender, EventArgs e)
        {
            PhoneId.Text = "";
            AddressId.Text = "";
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            try
            {
                if (string.IsNullOrEmpty(EmailId.Text))
                {
                    Label2.Text = "Please fill out the field";
                }
                else
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();

                    SqlCommand command = new SqlCommand("UPDATE contactInfos SET Info=@info where Title='Email'", con);
                    command.Parameters.AddWithValue("@info", EmailId.Text.Trim());
                    command.ExecuteNonQuery();
                    con.Close();
                    Label2.Text = "Successfully Updated";
                    EmailId.Text = "";
                }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }

        protected void updatebtn3_Click(object sender, EventArgs e)
        {
            PhoneId.Text = "";
            EmailId.Text = "";
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            try
            {
                if (string.IsNullOrEmpty(AddressId.Text))
                {
                    Label3.Text = "Please fill out the field";
                }
                else
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();

                    SqlCommand command = new SqlCommand("UPDATE contactInfos SET Info=@info where Title='Address'", con);
                    command.Parameters.AddWithValue("@info", AddressId.Text.Trim());
                    command.ExecuteNonQuery();
                    con.Close();
                    Label3.Text = "Successfully Updated";
                    AddressId.Text = "";
                }
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditMode.aspx");
        }
    }
}