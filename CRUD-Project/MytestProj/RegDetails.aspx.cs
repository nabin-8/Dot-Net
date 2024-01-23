using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MytestProj
{
    public partial class RegDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                //database connection
                MySqlConnection con = new MySqlConnection("Server=localhost; Database=mytest_db;Uid=root;Pwd=;");
                con.Open();

                //command to select data
                MySqlCommand cmd = new MySqlCommand("select id,full_name, email, password from testproj_tb order by id", con);

                //use data adapter to select data
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                //Use database to store data
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //assign data table data to grid view
                gridListUser.DataSource = dt;
                gridListUser.DataBind();

            }
            catch (Exception ex)
            {

                err_message.InnerText = "Error :" + ex.Message;

            }
        }

        protected void btnnDelete_Click(object sender, EventArgs e)
        {
            string id =inputId.Text;
            int a;
            if(!int.TryParse(id, out a))
            {
                err_message.Style.Add("color", "red");
                err_message.InnerText = "Enter Valid ID";

            }
            else
            {
                try
                {
                    //database connection
                    MySqlConnection conn = new MySqlConnection("Server=localhost; Database=mytest_db;Uid=root;Pwd=;");
                    conn.Open();

                    //command to selecr data
                    MySqlCommand cmd = new MySqlCommand("delete from testproj_tb where id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    //execute
                    cmd.ExecuteNonQuery();
                    LoadUserData();
                    err_message.InnerText = "Rrcord: Delete Successfully!";
                    err_message.Style.Add("color", "#12a4d9");
                }
                catch (Exception ex)
                {
                    err_message.InnerText=ex.Message;
                }
            }
        }

        protected void btnnUpdate_Click(object sender, EventArgs e)
        {
            string id = inputId.Text;
            int b;
            if (!int.TryParse(id, out b))
            {
                err_message.InnerText = "Enter valid ID";
                err_message.Style.Add("color", "red");
            }
            else
            {
                Response.Redirect("EditStudent.aspx?id=" + id);
            }
        }
    }
}