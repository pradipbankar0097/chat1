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
using System.Net;
/*
 this is comment.
this is comment 2.
 
 */
namespace chat1
{
    public partial class Login : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=temp");
        protected void Page_Load(object sender, EventArgs e)
        {
           /* 
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ip.Text = myIP;
           */
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
            cmd.CommandText = "select * from students";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(reader["uname"].ToString() == username.Text)
                {
                    if (reader["password"].ToString() == password.Text)
                    {
                        Session["user"] = reader["fname"].ToString() +" "+ reader["lname"].ToString();
                        Response.Redirect("~\\Chat.aspx");
                    }
                    else
                    {
                        ip.Text = "Invalid credentials";
                    }
                }
                else
                {
                    ip.Text = "Invalid credentials";
                }


            }
            reader.Close();
            con.Close();
        }
    }
}