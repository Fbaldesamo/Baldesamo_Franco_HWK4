using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Baldesamo_Franco_HWK4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        ValidationSettings: UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
           

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost;user id=root;database=paws_info";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            //prepare query
            string User_ID = TextBox1.Text;
            string User_fname = TextBox2.Text;
            string User_lname = TextBox6.Text;
            string User_ADDRESS = TextBox3.Text;
            string User_TEL= TextBox4.Text;
            string User_EMAIL = TextBox5.Text;

            string Query = "INSERT INTO paws_tbl (USER_ID, USER_FNAME, USER_LNAME, USER_ADDRESS, USER_TELEPHONE, USER_EMAIL) VALUES ('"+ User_ID + "','" + User_fname + "','" + User_lname + "','" + User_ADDRESS + "','" + User_TEL + "','" + User_EMAIL + "',)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();


            con.Close();

            Server.Transfer("WebForm2.aspx");

        }
    }
}