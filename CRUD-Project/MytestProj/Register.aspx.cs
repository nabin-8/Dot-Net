using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MytestProj
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Reset error Message
            errUsername.InnerText=errEmail.InnerText=errPassword.InnerText=String.Empty;

            //extract or get from data
            String full_name = textUsername.Text;
            String email = textEmail.Text;
            String password = textPassword.Text;

            //initilization error count to 0
            int error = 0;

            //Process for form validation
            if(String.IsNullOrEmpty(full_name))
            {
                error++;
                errUsername.InnerText = "Enter fullName";
                errUsername.Style.Add("color", "red");
            }
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

            //Check for no error after validation
            //check for number of errors after validation
            if (error == 0) {
                try
                {
                    //Database Configration
                    MySqlConnection con = new MySqlConnection("Server=localhost; Database=mytest_db;Uid=root;Pwd=;");
                    con.Open();

                    //Sql Query to insert record
                    MySqlCommand cmd = new MySqlCommand("insert into testproj_tb(full_name, email, password) values(@full_name, @email, @password)", con);
                    cmd.Parameters.AddWithValue("@full_name", full_name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    //execute query
                    cmd.ExecuteNonQuery();
                    error_message.InnerText = "Success: Register Successfully";
                    error_message.Style.Add("color", "#12a4d9");
                }
                catch ( MySqlException mex)
                {
                    error_message.Style.Add("color", "red");
                    error_message.InnerText ="Error:" +mex.Message;
                    
                }
            }
        }
    }
}