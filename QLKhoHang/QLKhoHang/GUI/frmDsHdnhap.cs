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
using DAL;

namespace QLKhoHang.GUI
{
    public partial class frmDsHdnhap : Form
    {
        DataDiagramDataContext dl = new DataDiagramDataContext();
        Bus bus = new Bus();
        public frmDsHdnhap()
        {
            InitializeComponent();

            var query = (from n in dl.DoiTacs where n.KieuDoiTac == "Nhà cung cấp" select n.MaDoiTac).Distinct();
            foreach (string item in query)
            {
                cbMancc.Items.Add(item);
            }

            dataGridView1.DataSource = bus.get_DsHD("Nhập vào");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsHD("Nhập vào", textBox1.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void cbMancc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsHD("Nhập vào", cbMancc.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
