using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace chat1
{
    public partial class Register : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=temp");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into students values('" + enrollno.Text.ToString() + "','" + fname.Text.ToString() + "','" + mname.Text.ToString() + "','" + lname.Text.ToString() + "','" + "GECA" + "','" + branch.Text.ToString() + "','" + password.Text.ToString() + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            Session["user"] = fname.Text;

            Response.Redirect("~\\Login.aspx");
        }
    }
}