using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ali_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Buttoncmd_Click(object sender, EventArgs e)
        {
            string var1,var2,var3;
            var1 = Txtname.Text;
            var2 = Txtclass.Text;
            var3 = Txtdiv.Text;
            Rchtxt.Text = "Name:";
            Rchtxt.Text += var1;
            Rchtxt.Text += "\n class:";
            Rchtxt.Text += var2;
            Rchtxt.Text += "\n division:";
            Rchtxt.Text += var3;
            comboBox1.Items.Add(var1);
            //MessageBox.Show("Name:");
            //MessageBox.Show( var1);
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            //string var1, var2, var3;
            var myForm = new Form3();
            myForm.Show();
            this.Hide();
            //var1 = Txtname.Text;
            //var2 = Txtclass.Text;
            //var3 = Txtdiv.Text;
            //comboBox1.Items.Add(var1);
            //comboBox1.Text += var1;
            // comboBox1.Text += var2;
            //comboBox1.Text += var3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
