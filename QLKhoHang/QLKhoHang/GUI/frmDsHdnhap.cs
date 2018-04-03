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
    public partial class frmDsHdnhap : Form
    {
        Bus bus = new Bus();
        public frmDsHdnhap()
        {
            InitializeComponent();

            dataGridView1.DataSource = bus.get_DsHD("Nhập vào");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_DsHD("Nhập vào", textBox1.Text);
        }
    }
}
