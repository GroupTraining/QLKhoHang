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
    public partial class UpdateSanPham : Form
    {
        Bus bus = new Bus();
        public UpdateSanPham()
        {
            InitializeComponent();
            dataGridViewSP.DataSource = bus.get_DsSP();
            dataGridViewSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa  thông tin Sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.UpdateSP(textMasp.Text, textTensp.Text, textSl.Text, textGia.Text, dateNgay.Text, textGhichu.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                textMasp.Text = "";
                textTensp.Text = "";
                textSl.Text = "";
                textGia.Text = "";
                textGhichu.Text = "";
                dataGridViewSP.Refresh();
                dataGridViewSP.DataSource = bus.get_DsSP();
                dataGridViewSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.delSP(textMasp.Text);
                MessageBox.Show("Xóa thành công!!");
                dataGridViewSP.DataSource = bus.get_DsSP();
            }
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMasp.Enabled = false;
            int rowindex = dataGridViewSP.CurrentCell.RowIndex;
            int columnindex = dataGridViewSP.CurrentCell.ColumnIndex;
            textMasp.Text = dataGridViewSP.Rows[rowindex].Cells[0].Value.ToString();
            textTensp.Text = dataGridViewSP.Rows[rowindex].Cells[1].Value.ToString();
            textSl.Text = dataGridViewSP.Rows[rowindex].Cells[4].Value.ToString();
            textGia.Text = dataGridViewSP.Rows[rowindex].Cells[5].Value.ToString();
            dateNgay.Text = dataGridViewSP.Rows[rowindex].Cells[3].Value.ToString();
            textGhichu.Text = dataGridViewSP.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmThemsp themsp = new frmThemsp();
            themsp.Show();
        }
    }
}
