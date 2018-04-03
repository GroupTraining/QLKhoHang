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
    public partial class frmThemloaisp : Form
    {
        Bus bus = new Bus();
        public frmThemloaisp()
        {
            InitializeComponent();
        }
        

        private void frmThemloaisp_Load_1(object sender, EventArgs e)
        {
            dgvLoaiSanPham.DataSource = bus.get_LoaiSP();
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnTHÊM_Click_1(object sender, EventArgs e)
        {
            try
            {
                bus.Add_LoaiSP(txtMaLoaiSP.Text, txtTenLoaiSP.Text, txtMoTa.Text);
                dgvLoaiSanPham.Refresh();
                dgvLoaiSanPham.DataSource = bus.get_LoaiSP();
                dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
