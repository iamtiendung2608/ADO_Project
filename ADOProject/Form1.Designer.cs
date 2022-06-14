
namespace ADOProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Coursebtn = new System.Windows.Forms.Button();
            this.Detailsbtn = new System.Windows.Forms.Button();
            this.userbtn = new System.Windows.Forms.Button();
            this.resultbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Coursebtn);
            this.panel1.Controls.Add(this.Detailsbtn);
            this.panel1.Controls.Add(this.userbtn);
            this.panel1.Controls.Add(this.resultbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 474);
            this.panel1.TabIndex = 0;
            // 
            // Coursebtn
            // 
            this.Coursebtn.BackColor = System.Drawing.Color.White;
            this.Coursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coursebtn.Image = global::ADOProject.Properties.Resources.book_stack;
            this.Coursebtn.Location = new System.Drawing.Point(3, 235);
            this.Coursebtn.Name = "Coursebtn";
            this.Coursebtn.Size = new System.Drawing.Size(110, 110);
            this.Coursebtn.TabIndex = 1;
            this.Coursebtn.UseVisualStyleBackColor = false;
            this.Coursebtn.Click += new System.EventHandler(this.Coursebtn_Click);
            // 
            // Detailsbtn
            // 
            this.Detailsbtn.BackColor = System.Drawing.Color.White;
            this.Detailsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Detailsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Detailsbtn.Image")));
            this.Detailsbtn.Location = new System.Drawing.Point(3, 351);
            this.Detailsbtn.Name = "Detailsbtn";
            this.Detailsbtn.Size = new System.Drawing.Size(110, 110);
            this.Detailsbtn.TabIndex = 3;
            this.Detailsbtn.UseVisualStyleBackColor = false;
            this.Detailsbtn.Click += new System.EventHandler(this.Detailsbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.BackColor = System.Drawing.Color.White;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userbtn.Image = ((System.Drawing.Image)(resources.GetObject("userbtn.Image")));
            this.userbtn.Location = new System.Drawing.Point(3, 119);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(110, 110);
            this.userbtn.TabIndex = 1;
            this.userbtn.UseVisualStyleBackColor = false;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click_1);
            // 
            // resultbtn
            // 
            this.resultbtn.BackColor = System.Drawing.Color.White;
            this.resultbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultbtn.Image = global::ADOProject.Properties.Resources.best;
            this.resultbtn.Location = new System.Drawing.Point(3, 3);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(110, 110);
            this.resultbtn.TabIndex = 0;
            this.resultbtn.UseVisualStyleBackColor = false;
            this.resultbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ContentLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(121, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 64);
            this.panel2.TabIndex = 1;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(502, 12);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(138, 31);
            this.ContentLabel.TabIndex = 1;
            this.ContentLabel.Text = "Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình quản lý:";
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.dataGridView1);
            this.LayoutPanel.Location = new System.Drawing.Point(125, 65);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(712, 448);
            this.LayoutPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Gender,
            this.Age});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Column1";
            this.Name.Name = "Name";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Column1";
            this.Gender.Name = "Gender";
            // 
            // Age
            // 
            this.Age.HeaderText = "Column1";
            this.Age.Name = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Detailsbtn;
        private System.Windows.Forms.Button Coursebtn;
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.Button resultbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LayoutPanel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}

