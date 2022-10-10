using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Ali_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void Buttoncmd_Click_1(object sender, EventArgs e)
        {

            //DECLARE @SName VARCHAR(100) = Txtname.Text;
            //DECLARE @Sclass VARCHAR(100) = Txtclass.Text;
            //DECLARE @Sdiv VARCHAR(100) = Txtdiv.Text;
            string SName, Sclass, Sdiv;
            SName = Txtname.Text;
            Sclass = Txtclass.Text;
            Sdiv = Txtdiv.Text;
            this.dataGridView1.Rows.Add(SName, Sclass, Sdiv);
            string connetionString = null;
            SqlConnection connection;
            SqlCommand cmd;
            string sql = null;
            string sql2 = null;

            connetionString = "Data Source=DESKTOP-1U7QG0F\\SQLEXPRESS;Initial Catalog=Alidb;" +
                "Integrated Security=SSPI";

            //sql2 = "SELECT * FROM register";
            
            connection = new SqlConnection(connetionString);
            //try
            //{
                
                connection.Open();
            //using (cmd = new SqlCommand("INSERT INTO Main1(FirstName, SecondName) VALUES(@FirstName, @SecondName)", connection))
            using (cmd = new SqlCommand("INSERT INTO register(name, class, division) VALUES(@FirstName, @Sclass, @Sdiv)", connection))
            {
                //var @Sname, @Sclass, @Sdiv;
                //sql = "INSERT INTO Main(FirstName, SecondName) VALUES(@FirstName, @SecondName)";
                    cmd.Parameters.AddWithValue("@FirstName", Txtname.Text);
                    cmd.Parameters.AddWithValue("@Sclass", Txtclass.Text);
                    cmd.Parameters.AddWithValue("@Sdiv", Txtdiv.Text);

                //MessageBox.Show(" 1 2!!");

                cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

            using (cmd = new SqlCommand("INSERT INTO Main(FirstName, SecondName) VALUES(@FirstName, @SecondName)", connection))
            {
                cmd.Parameters.AddWithValue("@FirstName", Txtname.Text);
                cmd.Parameters.AddWithValue("@SecondName", Txtclass.Text);
                //command = new SqlCommand(sql, connection);
                //command.ExecuteNonQuery();
                //command.Dispose();
                //command = new SqlCommand(sql2, connection);
                //command.ExecuteNonQuery();
                //command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Can not open connection ! ");
                //}

                /*
                connection = new SqlConnection("connectionString");

                    connection.Open();
                    sql = "INSERT INTO Main(FirstName, SecondName) VALUES(@FirstName, @SecondName)";
                    using (cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", Txtname.Text);
                        cmd.Parameters.AddWithValue("@SecondName", Txtname.Text);

                        cmd.ExecuteNonQuery();
                    }
                */
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con))
                    {
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            myComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                myComboBox.Items.Add((string)reader["TABLE_NAME"]);
                            }
                        }
                    }
                }
            }
        }

       

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            var myForm = new Form4();
            myForm.Show();
            this.Hide();
        }
    }
}
