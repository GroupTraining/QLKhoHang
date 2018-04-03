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
    public partial class ThemHoaDonChiTiet : Form
    {
        Bus bus = new Bus();
        DataDiagramDataContext data = new DataDiagramDataContext();
        public ThemHoaDonChiTiet()
        {
            InitializeComponent();
        }

        private void ThemHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thêm hóa đơn chi tiết này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.Add_HDCT(txt_mahdct.Text,txt_mahd.Text,txt_masp.Text,Convert.ToInt32(txt_sl.Text),Convert.ToInt32(lbl_amount.Text) )== 1)
                {
                    MessageBox.Show("Thêm thành công !!");
                    txt_mahdct.Text = "";
                    txt_mahd.Text = "";
                    txt_masp.Text = "";
                    txt_sl.Text = "";
                    lbl_amount.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm không thành công !!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_sl_TextChanged(object sender, EventArgs e)
        {
            if (txt_masp.Text != "")
            {
                var sp = data.SanPhams.Single(p => p.MaSP == txt_masp.Text);
                lbl_amount.Text = Convert.ToString(sp.Gia * Convert.ToInt32(txt_sl.Text));
            }
            else
            {
                lbl_amount.Text = "";
            }
        }
    }
}
