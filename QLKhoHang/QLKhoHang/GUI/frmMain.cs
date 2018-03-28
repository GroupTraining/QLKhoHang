using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhoHang.GUI;

namespace QLKhoHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsSanPham dssp = new frmDsSanPham();
            dssp.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsKh dskh = new frmDsKh();
            dskh.Show();
        }

        private void thêmLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLloaisp loaisp = new frmQLloaisp();
            loaisp.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLsp sp = new frmQLsp();
            sp.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLkh kh = new frmQLkh();
            kh.Show();
        }

        private void thêmĐốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLnhacc nhacc = new frmQLnhacc();
            nhacc.Show();
        }

        private void thêmHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLhoadonnhap hdnhap = new frmQLhoadonnhap();
            hdnhap.Show();
        }

        private void thêmHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLhoadonxuat hdxuat = new frmQLhoadonxuat();
            hdxuat.Show();
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsNhacc Nhacc = new frmDsNhacc();
            Nhacc.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsHdnhap Dsnhap = new frmDsHdnhap();
            Dsnhap.Show();
        }

        private void danhSáchHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsHdxuat Dsxuat = new frmDsHdxuat();
            Dsxuat.Show();
        }

        private void danhSáchHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsHangtonkho DsHangtonkho = new frmDsHangtonkho();
            DsHangtonkho.Show();
        }
    }
}
