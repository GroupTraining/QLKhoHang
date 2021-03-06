﻿using System;
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
            frmThemloaisp loaisp = new frmThemloaisp();
            loaisp.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemsp sp = new frmThemsp();
            sp.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.ThemDoiTac dt = new GUI.ThemDoiTac();
            dt.Show();
        }

        private void thêmHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.ThemHoaDon hd = new GUI.ThemHoaDon();
            hd.Show();
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

        private void sửaXóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSanPham upsp = new UpdateSanPham();
            upsp.Show();
        }

        private void thêmHóaĐơnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHoaDonChiTiet hdct = new ThemHoaDonChiTiet();
            hdct.Show();
        }

        private void sửaXóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditHoaDon hd = new EditHoaDon();
            hd.Show();
        }
    }
}
