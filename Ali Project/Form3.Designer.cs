
namespace Ali_Project
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.Label();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.Lblclass = new System.Windows.Forms.Label();
            this.Txtclass = new System.Windows.Forms.TextBox();
            this.lbldiv = new System.Windows.Forms.Label();
            this.Txtdiv = new System.Windows.Forms.TextBox();
            this.Buttoncmd = new System.Windows.Forms.Button();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.Nextbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnname,
            this.Columnclass,
            this.ColumnDiv,
            this.Columnmark});
            this.dataGridView1.Location = new System.Drawing.Point(44, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Columnname
            // 
            this.Columnname.HeaderText = "Name";
            this.Columnname.Name = "Columnname";
            // 
            // Columnclass
            // 
            this.Columnclass.HeaderText = "Class";
            this.Columnclass.Name = "Columnclass";
            // 
            // ColumnDiv
            // 
            this.ColumnDiv.HeaderText = "Division";
            this.ColumnDiv.Name = "ColumnDiv";
            // 
            // Columnmark
            // 
            this.Columnmark.HeaderText = "Mark";
            this.Columnmark.Name = "Columnmark";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(56, 200);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 15);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name :";
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(181, 192);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(100, 23);
            this.Txtname.TabIndex = 2;
            // 
            // Lblclass
            // 
            this.Lblclass.AutoSize = true;
            this.Lblclass.Location = new System.Drawing.Point(56, 239);
            this.Lblclass.Name = "Lblclass";
            this.Lblclass.Size = new System.Drawing.Size(40, 15);
            this.Lblclass.TabIndex = 5;
            this.Lblclass.Text = "Class :";
            // 
            // Txtclass
            // 
            this.Txtclass.Location = new System.Drawing.Point(181, 231);
            this.Txtclass.Name = "Txtclass";
            this.Txtclass.Size = new System.Drawing.Size(100, 23);
            this.Txtclass.TabIndex = 4;
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Location = new System.Drawing.Point(56, 277);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(49, 15);
            this.lbldiv.TabIndex = 7;
            this.lbldiv.Text = "Division";
            // 
            // Txtdiv
            // 
            this.Txtdiv.Location = new System.Drawing.Point(181, 269);
            this.Txtdiv.Name = "Txtdiv";
            this.Txtdiv.Size = new System.Drawing.Size(100, 23);
            this.Txtdiv.TabIndex = 6;
            // 
            // Buttoncmd
            // 
            this.Buttoncmd.Location = new System.Drawing.Point(359, 249);
            this.Buttoncmd.Name = "Buttoncmd";
            this.Buttoncmd.Size = new System.Drawing.Size(165, 43);
            this.Buttoncmd.TabIndex = 8;
            this.Buttoncmd.Text = "submit";
            this.Buttoncmd.UseVisualStyleBackColor = true;
            this.Buttoncmd.Click += new System.EventHandler(this.Buttoncmd_Click_1);
            // 
            // myComboBox
            // 
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(513, 41);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(121, 23);
            this.myComboBox.TabIndex = 10;
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(400, 298);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 11;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.Buttoncmd);
            this.Controls.Add(this.lbldiv);
            this.Controls.Add(this.Txtdiv);
            this.Controls.Add(this.Lblclass);
            this.Controls.Add(this.Txtclass);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.dataGridView1);
            //this.Name = "Form3";
            this.Text = "Form3";
            //this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txtname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Lblclass;
        private System.Windows.Forms.TextBox Txtclass;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.TextBox Txtdiv;
        private System.Windows.Forms.Button Buttoncmd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.Button Nextbtn;
    }
}