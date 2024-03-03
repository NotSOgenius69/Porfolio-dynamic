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
    public partial class login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void loggingInbtn_Click(Object sender, EventArgs e)
        {
            HudaiLabel.Text = "";
            string email = adminEmail.Value;
            string pass = adminPass.Value;
            try
            {
                if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
                {
                    HudaiLabel.Text = "Please fill out all the fields";
                }
                else
                {
                    SqlConnection con = new SqlConnection(strcon);
                    con.Open();

                    SqlCommand command = new SqlCommand("select * from loginInfo where Email=@email", con);
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read())
                    {
                        string adminemail = reader["Email"].ToString();
                        HudaiLabel.Text += adminemail+" ";
                        string adminpassword = reader["Password"].ToString() ;
                        HudaiLabel.Text+=adminpassword;
                        if(adminemail==email && adminpassword==pass)
                        {
                            Response.Redirect("EditMode.aspx");
                        }
                        else
                        {
                            HudaiLabel.Text = "Wrong credentials.Try again!";
                        }
                    }
                    else
                    {
                        HudaiLabel.Text = "Wrong credentials.Try again!";
                    }

                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                HudaiLabel.Text = ex.Message;
            }
        }
    }
}