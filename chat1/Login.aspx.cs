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
    public partial class Login : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=temp");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void username_TextChanged(object sender, EventArgs e)
        {




        }

        protected void registerbutton_Click(object sender, EventArgs e)
        {
            
        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from students where 'uname'='"+username.Text.ToString()+"'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
            }
            Session["user"] = username.Text;
            Response.Redirect("~\\Chat.aspx");
        }
    }
}