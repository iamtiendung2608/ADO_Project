using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOProject
{
    public partial class Form1 : Form
    {
        private Details DetailsForm = new Details();
        private Course CoursesForm = new Course();
        private Result ResultForm = new Result();
        public Form1()
        {
            InitializeComponent();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            ContentLabel.Text = "Điểm số";
            LayoutPanel.Controls.Clear();
            LayoutPanel.Controls.Add(ResultForm);

        }

        private void userbtn_Click_1(object sender, EventArgs e)
        {
            ContentLabel.Text = "Sinh Viên";
            LayoutPanel.Controls.Clear();
            //LayoutPanel.Controls.Add(ResultForm);
        }

        private void Coursebtn_Click(object sender, EventArgs e)
        {
            ContentLabel.Text = "Môn học";
            LayoutPanel.Controls.Clear();
            LayoutPanel.Controls.Add(CoursesForm);
        }

        private void Detailsbtn_Click(object sender, EventArgs e)
        {
            ContentLabel.Text = "Thông tin SV";
            LayoutPanel.Controls.Clear();
            LayoutPanel.Controls.Add(DetailsForm);
        }
    }
}
