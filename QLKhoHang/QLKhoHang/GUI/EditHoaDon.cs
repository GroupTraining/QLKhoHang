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
    public partial class EditHoaDon : Form
    {
        Bus data = new Bus();
        public EditHoaDon()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = data.getDataHD();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void EditHoaDon_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBoxHD.Items.Add("[Kiểu Hóa Đơn]");
            comboBoxHD.Items.Add("Xuất ra");
            comboBoxHD.Items.Add("Nhập vào");
            comboBoxHD.SelectedItem = "[Kiểu Hóa Đơn]";
        }
    }
}
