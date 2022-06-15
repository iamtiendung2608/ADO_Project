
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.Panel();
            this.Coursebtn = new System.Windows.Forms.Button();
            this.Detailsbtn = new System.Windows.Forms.Button();
            this.userbtn = new System.Windows.Forms.Button();
            this.resultbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Coursebtn);
            this.panel1.Controls.Add(this.Detailsbtn);
            this.panel1.Controls.Add(this.userbtn);
            this.panel1.Controls.Add(this.resultbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 474);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.ContentLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(90, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 59);
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
            this.LayoutPanel.Location = new System.Drawing.Point(90, 55);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(744, 419);
            this.LayoutPanel.TabIndex = 2;
            // 
            // Coursebtn
            // 
            this.Coursebtn.BackColor = System.Drawing.Color.White;
            this.Coursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coursebtn.Image = global::ADOProject.Properties.Resources.book_stack1;
            this.Coursebtn.Location = new System.Drawing.Point(5, 235);
            this.Coursebtn.Name = "Coursebtn";
            this.Coursebtn.Size = new System.Drawing.Size(80, 80);
            this.Coursebtn.TabIndex = 1;
            this.Coursebtn.UseVisualStyleBackColor = false;
            this.Coursebtn.Click += new System.EventHandler(this.Coursebtn_Click);
            // 
            // Detailsbtn
            // 
            this.Detailsbtn.BackColor = System.Drawing.Color.White;
            this.Detailsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Detailsbtn.Image = global::ADOProject.Properties.Resources.resume1;
            this.Detailsbtn.Location = new System.Drawing.Point(5, 351);
            this.Detailsbtn.Name = "Detailsbtn";
            this.Detailsbtn.Size = new System.Drawing.Size(80, 80);
            this.Detailsbtn.TabIndex = 3;
            this.Detailsbtn.UseVisualStyleBackColor = false;
            this.Detailsbtn.Click += new System.EventHandler(this.Detailsbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.BackColor = System.Drawing.Color.White;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userbtn.Image = global::ADOProject.Properties.Resources.best1;
            this.userbtn.Location = new System.Drawing.Point(5, 119);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(80, 80);
            this.userbtn.TabIndex = 1;
            this.userbtn.UseVisualStyleBackColor = false;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click_1);
            // 
            // resultbtn
            // 
            this.resultbtn.BackColor = System.Drawing.Color.White;
            this.resultbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultbtn.Image = global::ADOProject.Properties.Resources.user1;
            this.resultbtn.Location = new System.Drawing.Point(5, 11);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(80, 80);
            this.resultbtn.TabIndex = 0;
            this.resultbtn.UseVisualStyleBackColor = false;
            this.resultbtn.Click += new System.EventHandler(this.userbtn_Click);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

