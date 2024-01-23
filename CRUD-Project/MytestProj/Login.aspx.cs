using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MytestProj
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Reset error Message
            errEmail.InnerText = errPassword.InnerText = String.Empty;

            //extract or get from data
            String email = textEmail.Text;
            String password = textPassword.Text;

            //initilization error count to 0
            int error = 0;

            //Process for form validation
            if (String.IsNullOrEmpty(password))
            {
                error++;
                errPassword.InnerText = "Enter Password";
                errPassword.Style.Add("color", "red");
            }
            if (String.IsNullOrEmpty(email))
            {
                error++;
                errEmail.InnerText = "Enter Email";
                errEmail.Style.Add("color", "red");
            }

            if (error == 0)
            {
                try
                {
                    //database connection
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=mytest_db;Uid=root;Pwd=;");
                    connect.Open();
                    //command to select data
                    MySqlCommand cmd = new MySqlCommand("select * from testproj_tb where email=@email and password=@password", connect);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    object obj = cmd.ExecuteScalar();
                    //login process
                    if (obj != null)
                    {
                        Session.Add("email", email);
                        Response.Redirect("Dashboard.aspx");
                    }
                    else
                    {
                        error_message.InnerText = "Invalid Information email/Password";
                        error_message.Style.Add("color", "red");
                    }
                }
                catch (MySqlException mex)
                {
                    error_message.InnerText = "Error :" + mex.Message;
                    error_message.Style.Add("color", "red");
                }
            }


        }
    }
}