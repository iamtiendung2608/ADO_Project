
namespace ADOProject
{
    partial class Student
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
            this.SName = new System.Windows.Forms.TextBox();
            this.SAge = new System.Windows.Forms.TextBox();
            this.SGender = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // SName
            // 
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.Location = new System.Drawing.Point(10, 57);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(164, 31);
            this.SName.TabIndex = 1;
            this.SName.Text = "Tên";
            // 
            // SAge
            // 
            this.SAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAge.Location = new System.Drawing.Point(197, 57);
            this.SAge.Name = "SAge";
            this.SAge.Size = new System.Drawing.Size(164, 31);
            this.SAge.TabIndex = 2;
            this.SAge.Text = "Tuổi";
            // 
            // SGender
            // 
            this.SGender.AutoSize = true;
            this.SGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGender.Location = new System.Drawing.Point(197, 16);
            this.SGender.Name = "SGender";
            this.SGender.Size = new System.Drawing.Size(78, 29);
            this.SGender.TabIndex = 3;
            this.SGender.Text = "Nam";
            this.SGender.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(370, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 144);
            this.panel1.TabIndex = 4;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Lime;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Addbtn.Location = new System.Drawing.Point(390, 11);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(112, 39);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Blue;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Savebtn.Location = new System.Drawing.Point(390, 56);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(112, 39);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.Red;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbtn.Location = new System.Drawing.Point(508, 11);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(112, 39);
            this.Clearbtn.TabIndex = 7;
            this.Clearbtn.Text = "clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatebtn.Location = new System.Drawing.Point(508, 56);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(112, 39);
            this.Updatebtn.TabIndex = 8;
            this.Updatebtn.Text = "update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // StudentID
            // 
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(10, 16);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(164, 31);
            this.StudentID.TabIndex = 9;
            this.StudentID.Text = "Mã Sinh Viên";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SGender);
            this.Controls.Add(this.SAge);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(744, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox SAge;
        private System.Windows.Forms.CheckBox SGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TextBox StudentID;
    }
}
