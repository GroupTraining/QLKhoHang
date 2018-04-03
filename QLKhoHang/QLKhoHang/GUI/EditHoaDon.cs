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
            if (MessageBox.Show("Bạn có muốn sửa  thông tin Hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.UpdateHD(txtMaHD.Text, dateTimePicker.Text, comboBoxHD.Text, txtSoLuong.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                txtMaHD.Text = "";
                txtSoLuong.Text = "";
                comboBoxHD.SelectedItem = "[Kiểu Hóa Đơn]";
                dateTimePicker.Value = DateTime.Now;

                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = data.getDataHD();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                data.DelHD(txtMaHD.Text);
                MessageBox.Show("Xóa thành công!!");
                dataGridViewX1.DataSource = data.getDataHD();
            }
        }

        private void EditHoaDon_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBoxHD.Items.Add("[Kiểu Hóa Đơn]");
            comboBoxHD.Items.Add("Xuất ra");
            comboBoxHD.Items.Add("Nhập vào");
            comboBoxHD.SelectedItem = "[Kiểu Hóa Đơn]";
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewX1.CurrentCell.RowIndex;
            int columnindex = dataGridViewX1.CurrentCell.ColumnIndex;
            txtMaHD.Text = dataGridViewX1.Rows[rowindex].Cells[0].Value.ToString();
            dateTimePicker.Text = dataGridViewX1.Rows[rowindex].Cells[2].Value.ToString();
            comboBoxHD.Text = dataGridViewX1.Rows[rowindex].Cells[3].Value.ToString();
            txtSoLuong.Text = dataGridViewX1.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ThemHoaDon hd = null;
            Check_Them:
            if (hd == null || hd.IsDisposed)
            {
                hd = new ThemHoaDon();
            }
            if (hd.ShowDialog() == DialogResult.OK)
            {
                if (ThemHoaDon.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridViewX1.DataSource = data.getDataHD();
        }
    }
}
