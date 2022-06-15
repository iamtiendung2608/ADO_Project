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
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
            unable();
        }
        void unable()
        {
            StudentID.Enabled = false;
            CourseID.Enabled = false;
            Grade.Enabled = false;
            Identity.Enabled = false;
            StudentID.Text = "Mã Sinh Viên";
            CourseID.Text = "Mã Môn Học";
            Grade.Text = "Điểm số";
            Identity.Text = "Xếp loại";
            Savebtn.Enabled = false;
            Clearbtn.Enabled = false;
        }
        void enable()
        {
            Savebtn.Enabled = true;
            Clearbtn.Enabled = true;
            StudentID.Enabled = true;
            CourseID.Enabled = true;
            Grade.Enabled = true;
            Identity.Enabled = true;
        }
        void btnUnable(bool value)
        {
            Updatebtn.Enabled = value;
            Addbtn.Enabled = value;
        }
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            enable();
            btnUnable(false);
            StudentID.Enabled = false;
            CourseID.Enabled = false;
            Grade.Focus();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            unable();
            btnUnable(true);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            enable();
            btnUnable(false);
            StudentID.Focus();

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            unable();
            btnUnable(true);

        }
    }
}
