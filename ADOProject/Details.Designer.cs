
namespace ADOProject
{
    partial class DetailsForm
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
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.DID = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
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
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatebtn.Location = new System.Drawing.Point(508, 59);
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
            this.Clearbtn.Location = new System.Drawing.Point(508, 14);
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
            this.Savebtn.Location = new System.Drawing.Point(390, 59);
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
            this.Addbtn.Location = new System.Drawing.Point(390, 14);
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
            this.panel1.Location = new System.Drawing.Point(370, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 144);
            this.panel1.TabIndex = 9;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(190, 62);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(164, 31);
            this.Type.TabIndex = 25;
            this.Type.Text = "CT đào tạo";
            // 
            // Province
            // 
            this.Province.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province.Location = new System.Drawing.Point(190, 16);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(164, 31);
            this.Province.TabIndex = 24;
            this.Province.Text = "Tỉnh";
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(10, 62);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(164, 31);
            this.City.TabIndex = 23;
            this.City.Text = "Thành Phố";
            // 
            // DID
            // 
            this.DID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DID.Location = new System.Drawing.Point(10, 16);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(164, 31);
            this.DID.TabIndex = 22;
            this.DID.Text = "Mã Sinh Viên";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(10, 107);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(192, 20);
            this.StartDate.TabIndex = 26;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.City);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DetailsForm";
            this.Size = new System.Drawing.Size(744, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Province;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox DID;
        private System.Windows.Forms.DateTimePicker StartDate;
    }
}
