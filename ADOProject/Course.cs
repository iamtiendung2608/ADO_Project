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
    public partial class Course : UserControl
    {
        public Course()
        {
            InitializeComponent();
            unable(false);
        }
        private void unable(bool value)
        {
            CID.Text = "Mã Môn Học";
            CName.Text = "Tên Môn Học";
            CCredit.Text = "Số chỉ";
            CPrice.Text = "Giá Tiền";
            CID.Enabled = value;
            CName.Enabled = value;
            CCredit.Enabled = value;
            CPrice.Enabled = value;
        }
        void btnEnable(bool value)
        {
            Addbtn.Enabled = value;
            Updatebtn.Enabled = value;
            Clearbtn.Enabled = !value;
            Savebtn.Enabled = !value;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            unable(true);
            btnEnable(false);
            CID.Focus();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            unable(true);
            btnEnable(false);
            CID.Enabled = false;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            btnEnable(true);
            unable(false);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            btnEnable(true);
            unable(false);
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }
    }
}
