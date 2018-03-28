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
    public partial class frmDsHdxuat : Form
    {
        Bus bus = new Bus();
        public frmDsHdxuat()
        {
            InitializeComponent();

            dataGridView1.DataSource = bus.get_DsHD("Xuất ra");
        }
    }
}
