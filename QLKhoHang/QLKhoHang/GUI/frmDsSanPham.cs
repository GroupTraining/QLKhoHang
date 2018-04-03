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
    public partial class frmDsSanPham : Form
    {
        Bus bus = new Bus();
        public frmDsSanPham()
        {
            InitializeComponent();
            dataGridView1.DataSource = bus.get_DsSP();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsSP(txtGiatri.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
