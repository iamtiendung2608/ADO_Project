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
    public partial class DetailsForm : UserControl
    {
        public DetailsForm()
        {
            InitializeComponent();
            enable(false);
        }
        private void enable(bool value)
        {
            DID.Text = "Mã Sinh Viên";
            City.Text = "Thành Phố";
            Province.Text = "Tỉnh";
            Type.Text = "CT đào tạo";
            StartDate.Value = DateTime.Today;

            DID.Enabled = value;
            City.Enabled = value;
            Province.Enabled = value;
            Type.Enabled = value;
            StartDate.Enabled = value;
        }
        private void btnEnable(bool value)
        {
            Addbtn.Enabled = value;
            Updatebtn.Enabled = value;
            Clearbtn.Enabled = !value;
            Savebtn.Enabled = !value;
        }
        

        private void Addbtn_Click(object sender, EventArgs e)
        {
            enable(true);
            DID.Enabled = true;
            DID.Focus();
            btnEnable(false);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            enable(true);
            DID.Enabled = false;
            City.Focus();
            btnEnable(false);

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            btnEnable(true);
            enable(false);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            btnEnable(true);
            enable(false);

        }
    }
}
