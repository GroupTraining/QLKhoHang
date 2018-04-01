using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLKhoHang.GUI
{
    public partial class ThemHoaDon : Form
    {
        Bus bus = new Bus();
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            if (MessageBox.Show("Bạn  chắc chắn muốn thêm hóa đơn này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.Add_HoaDon(txt_mahd.Text,txt_madoitac.Text,time,txt_manv.Text) == 1)
                {
                    MessageBox.Show("Thêm thành công !!");
                    txt_mahd.Text = "";
                    txt_madoitac.Text = "";
                    txt_manv.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm không thành công !!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
