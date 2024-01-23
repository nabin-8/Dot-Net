using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MytestProj
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //fetch data according to student id passed into url as query string
                string id = Request.QueryString["id"];
                try
                {
                    //database connection
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=mytest_db;Uid=root;Pwd=;");
                    connect.Open();
                    //command to select data
                    MySqlCommand cmd = new MySqlCommand("select * from testproj_tb where id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtId.Value = reader["id"].ToString();

                        textUsername.Text = reader["full_name"].ToString();
                        textEmail.Text = reader["email"].ToString();
                        textPassword.Text = reader["password"].ToString();
                    }
                    else
                    {
                        error_message.InnerText = "Invalid Information";

                    }
                }
                catch (MySqlException mex)
                {
                    error_message.InnerText = "Error :" + mex.Message;
                }
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Value;

            string username = textUsername.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
           
            try
            {
                //database connection
                MySqlConnection connect = new MySqlConnection("Server=localhost;Database=mytest_db;Uid=root;Pwd=;");
                connect.Open();
                //query to insert data
                MySqlCommand cmd = new MySqlCommand("update testproj_tb set full_name=@full_name,email=@email,password=@password where id=@id", connect);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@full_name", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                error_message.InnerText = "Record Updated Successfully";
            }
            catch (Exception err)
            {
                error_message.InnerText = err.Message;
            }
        }
    }
}