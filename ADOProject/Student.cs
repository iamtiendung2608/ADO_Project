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
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
            unable();

        }
        private void unable()
        {
            SName.Enabled = false;
            StudentID.Enabled = false;
            SAge.Enabled = false;
            SGender.Enabled = false;
            SName.Text = "Tên";
            SAge.Text = "Tuổi";
            StudentID.Text = "Mã Sinh Viên";
            Addbtn.Enabled = true;
            Updatebtn.Enabled = true;
            Savebtn.Enabled = false;
            Clearbtn.Enabled = false;
            SGender.Checked = false;
        }
        private void btnChange()
        {
            Addbtn.Enabled = false;
            Updatebtn.Enabled = false;
            Savebtn.Enabled = true;
            Clearbtn.Enabled = true;
        }
        private void enable()
        {
            StudentID.Enabled = true;
            SName.Enabled = true;
            SAge.Enabled = true;
            SGender.Enabled = true;
        }
        
        private void Addbtn_Click(object sender, EventArgs e)
        {
            //Enable input
            btnChange();
            enable();
            StudentID.Focus();
        }
        
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            //Clear form
            unable();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            btnChange();
            //Fill data to Input field
            enable();
            StudentID.Enabled = false;
            SName.Focus();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //Clear form after save
            unable();
        }
    }
}
