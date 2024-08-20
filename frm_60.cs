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
    public partial class frm_60 : Form
    {
        public frm_60()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = "";
            //for (int i = 0; i < clbMonHoc.Items.Count; i++)
            //{
            //    if (this.clbMonHoc.GetItemChecked(i) == true)
            //        s += this.clbMonHoc.Items[i].ToString() + " ,";
            //    MessageBox.Show("Danh sách môn học được chọn: " + s);
            //}

            CheckedListBox.CheckedItemCollection items;
            items = this.clbMonHoc.CheckedItems;
            string s = "";
            foreach (object ob in items)
            {
                s += ob.ToString() + ", ";
            }
            MessageBox.Show("Danh sách môn học: " + s);
        }
    }
}
