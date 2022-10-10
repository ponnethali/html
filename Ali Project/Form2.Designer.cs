
using System;
using System.Data.SqlClient;

namespace Ali_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Lblclass = new System.Windows.Forms.Label();
            this.Txtclass = new System.Windows.Forms.TextBox();
            this.lbldiv = new System.Windows.Forms.Label();
            this.Txtdiv = new System.Windows.Forms.TextBox();
            this.Buttoncmd = new System.Windows.Forms.Button();
            this.Rchtxt = new System.Windows.Forms.RichTextBox();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(194, 43);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(100, 23);
            this.Txtname.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(69, 51);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 15);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name :";
            // 
            // Lblclass
            // 
            this.Lblclass.AutoSize = true;
            this.Lblclass.Location = new System.Drawing.Point(69, 114);
            this.Lblclass.Name = "Lblclass";
            this.Lblclass.Size = new System.Drawing.Size(40, 15);
            this.Lblclass.TabIndex = 3;
            this.Lblclass.Text = "Class :";
            this.Lblclass.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txtclass
            // 
            this.Txtclass.Location = new System.Drawing.Point(194, 106);
            this.Txtclass.Name = "Txtclass";
            this.Txtclass.Size = new System.Drawing.Size(100, 23);
            this.Txtclass.TabIndex = 2;
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Location = new System.Drawing.Point(69, 177);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(49, 15);
            this.lbldiv.TabIndex = 5;
            this.lbldiv.Text = "Division";
            // 
            // Txtdiv
            // 
            this.Txtdiv.Location = new System.Drawing.Point(194, 169);
            this.Txtdiv.Name = "Txtdiv";
            this.Txtdiv.Size = new System.Drawing.Size(100, 23);
            this.Txtdiv.TabIndex = 4;
            // 
            // Buttoncmd
            // 
            this.Buttoncmd.Location = new System.Drawing.Point(155, 234);
            this.Buttoncmd.Name = "Buttoncmd";
            this.Buttoncmd.Size = new System.Drawing.Size(165, 43);
            this.Buttoncmd.TabIndex = 6;
            this.Buttoncmd.Text = "submit";
            this.Buttoncmd.UseVisualStyleBackColor = true;
            this.Buttoncmd.Click += new System.EventHandler(this.Buttoncmd_Click);
            // 
            // Rchtxt
            // 
            this.Rchtxt.Location = new System.Drawing.Point(300, 43);
            this.Rchtxt.Name = "Rchtxt";
            this.Rchtxt.Size = new System.Drawing.Size(103, 149);
            this.Rchtxt.TabIndex = 7;
            this.Rchtxt.Text = "";
            this.Rchtxt.TextChanged += new System.EventHandler(this.Rchtxt_TextChanged);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(432, 254);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 8;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Rchtxt);
            this.Controls.Add(this.Buttoncmd);
            this.Controls.Add(this.lbldiv);
            this.Controls.Add(this.Txtdiv);
            this.Controls.Add(this.Lblclass);
            this.Controls.Add(this.Txtclass);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Txtname);
            //this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Lblclass;
        private System.Windows.Forms.TextBox Txtclass;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.TextBox Txtdiv;
        private System.Windows.Forms.Button Buttoncmd;
        private System.Windows.Forms.RichTextBox Rchtxt;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}