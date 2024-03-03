using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porfolio_dynamic
{
    public partial class MessagesAdmin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BindGridView();
            }
            catch(Exception ex) {
                HudaiLabel.Text = ex.Message;
            }
        }
        protected void MsgGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string name = MsgGridView.Rows[e.RowIndex].Cells[1].Text;
                
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                SqlCommand command = new SqlCommand("delete from Messages where Name= @name", con);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                BindGridView();

                con.Close();
            }
            catch (Exception ex)
            {
                HudaiLabel.Text = ex.Message;
            }

        }
        protected void BindGridView()
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlDataAdapter sadp = new SqlDataAdapter("select * from Messages", con);
            DataTable dtbl = new DataTable();
            sadp.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                MsgGridView.DataSource = dtbl;
                MsgGridView.DataBind();
            }
            else
            {
                MsgGridView.DataSource = dtbl;
                MsgGridView.DataBind();
                HudaiLabel.Text = "Nothing to show";
            }
            con.Close();
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditMode.aspx");
        }
    }
}