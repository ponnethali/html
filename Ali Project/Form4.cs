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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


       

        private void Buttoncmd_Click(object sender, EventArgs e)
        {
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
            int index = 0;
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(" SELECT * FROM register ", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (reader.Read())
                        {
                            //dataGridView1.Name += $"{reader.GetString("name")};";
                            //dataGridView1.Class += $"{reader.GetString("class")};";
                            index = index;
                            this.dataGridView1.Rows.Add(reader.GetString("name"), reader.GetString("class"), reader.GetString("division"), ""); //reader.GetString("mark");

                            //dataGridView1.Name[index]((string)reader["TABLE_NAME"]);
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
