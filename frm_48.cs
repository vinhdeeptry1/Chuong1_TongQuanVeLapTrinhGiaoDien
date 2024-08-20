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
    public partial class frm_48 : Form
    {
        public frm_48()
        {
            InitializeComponent();
        }

        private void cbChonNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cbChonNgoaiNgu.SelectedItem.ToString());
        }

        private void frm_48_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Nga", "Tiếng Hàn", "Tiếng Nhật" };
            this.cbChonNgoaiNgu.DataSource = datas;
        }
    }
}
