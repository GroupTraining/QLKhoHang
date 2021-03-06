﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QLKhoHang.GUI
{
    public partial class frmDsHdxuat : Form
    {
        DataDiagramDataContext dl = new DataDiagramDataContext();
        Bus bus = new Bus();
        public frmDsHdxuat()
        {
            InitializeComponent();
            var query = (from n in dl.DoiTacs where n.KieuDoiTac == "Khách hàng" select n.MaDoiTac).Distinct();
            foreach (string item in query)
            {
                cbMakh.Items.Add(item);
            }

            dataGridView1.DataSource = bus.get_DsHD("Xuất ra");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsHD("Xuất ra",textBox1.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void cbMakh_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsHD("Xuất ra", cbMakh.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
