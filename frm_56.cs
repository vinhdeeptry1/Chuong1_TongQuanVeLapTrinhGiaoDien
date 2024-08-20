using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212493_VLCVinh_Chuong1_1
{
    public partial class frm_56 : Form
    {
        public frm_56()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbNam.Checked)
            //    MessageBox.Show("Giới tính của bạn là Nam", "Thông báo");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbNu.Checked)
            //    MessageBox.Show("Giới tính của bạn là Nữ", "Thông báo");
        }

        private void btnCFirm_Click(object sender, EventArgs e)
        {
            if (rbNam.Checked)
            {
                MessageBox.Show("Giới tính của bạn là Nam", "Thông báo");
            }
            else
            {
                MessageBox.Show("Giới tính của bạn là Nữ", "Thông báo");
            }
        }

        private void frm_56_Load(object sender, EventArgs e)
        {

        }
    }
}
