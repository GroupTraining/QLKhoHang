using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLKhoHang.GUI
{
    public partial class frmThemsp : Form
    {
        Bus bus = new Bus();
        public frmThemsp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThemsp_Load(object sender, EventArgs e)
        {
            dgvThemSP.DataSource = bus.get_DsSP();


        }

        private void btnTHÊM_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Add_SanPham(txtMaSP.Text, txtTenSP.Text, txtMaLoaiSP.Text, txtSoLuong.Text, txtGia.Text, txtGhiChu.Text, dtpNgay.Text);
                dgvThemSP. Refresh();
                dgvThemSP.DataSource = bus.get_DsSP();
                MessageBox.Show("ĐÃ THÊM THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Nhập Sai Dữ Liệu. Nhập Lại!");
            }
        }
    }
}
