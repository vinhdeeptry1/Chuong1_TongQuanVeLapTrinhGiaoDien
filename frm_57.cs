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
    public partial class frm_57 : Form
    {
        public frm_57()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
            {
                this.btnButton.ForeColor = Color.Red;
            }
            else
            {
                this.btnButton.ForeColor = Color.Blue;
            }
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
            {
                this.btnButton.BackColor = Color.LightCyan;
            }
            else
            {
                this.btnButton.BackColor = Color.Khaki;
            }
        }

        private void rbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbFlat.Checked)
            {
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
            }
        }

        private void rbPopUp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
