
namespace ADOProject
{
    partial class Result
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.Identity = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(8, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatebtn.Location = new System.Drawing.Point(508, 57);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(112, 39);
            this.Updatebtn.TabIndex = 13;
            this.Updatebtn.Text = "update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.Red;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbtn.Location = new System.Drawing.Point(508, 12);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(112, 39);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Blue;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Savebtn.Location = new System.Drawing.Point(390, 57);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(112, 39);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Lime;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Addbtn.Location = new System.Drawing.Point(390, 12);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(112, 39);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(370, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 144);
            this.panel1.TabIndex = 9;
            // 
            // CourseID
            // 
            this.CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID.Location = new System.Drawing.Point(10, 57);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(164, 31);
            this.CourseID.TabIndex = 15;
            this.CourseID.Text = "Mã Môn Học";
            // 
            // StudentID
            // 
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(10, 16);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(164, 31);
            this.StudentID.TabIndex = 14;
            this.StudentID.Text = "Mã Sinh Viên";
            // 
            // Identity
            // 
            this.Identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identity.Location = new System.Drawing.Point(192, 57);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(164, 31);
            this.Identity.TabIndex = 17;
            this.Identity.Text = "Xếp loại";
            // 
            // Grade
            // 
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.Location = new System.Drawing.Point(192, 16);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(164, 31);
            this.Grade.TabIndex = 16;
            this.Grade.Text = "Điểm số";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.Identity);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(744, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.TextBox Identity;
        private System.Windows.Forms.TextBox Grade;
    }
}
