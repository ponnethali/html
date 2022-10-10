
namespace Ali_Project
{
    partial class Form4
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
            this.Buttoncmd = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(41, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(446, 294);
            this.dataGridView1.TabIndex = 1;
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
            // Buttoncmd
            // 
            this.Buttoncmd.Location = new System.Drawing.Point(537, 26);
            this.Buttoncmd.Name = "Buttoncmd";
            this.Buttoncmd.Size = new System.Drawing.Size(165, 43);
            this.Buttoncmd.TabIndex = 9;
            this.Buttoncmd.Text = "submit";
            this.Buttoncmd.UseVisualStyleBackColor = true;
            this.Buttoncmd.Click += new System.EventHandler(this.Buttoncmd_Click);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(537, 129);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 10;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Buttoncmd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnmark;
        private System.Windows.Forms.Button Buttoncmd;
        private System.Windows.Forms.Button Nextbtn;
    }
}