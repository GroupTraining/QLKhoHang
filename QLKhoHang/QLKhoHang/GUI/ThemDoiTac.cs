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
    public partial class ThemDoiTac : Form
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        Bus bus = new Bus();
        public ThemDoiTac()
        {
            InitializeComponent();
        }

        private void ThemDoiTac_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            comboBoxEx_group.Items.Add("[Chọn kiểu đối tác]");
            comboBoxEx_group.Items.Add("Khách hàng");
            comboBoxEx_group.Items.Add("Nhà cung cấp");
            comboBoxEx_group.SelectedIndex = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm đối tác này chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(bus.add_company(txt_id.Text, txt_name.Text, txt_address.Text, txt_phonenumber.Text, txt_email.Text, txt_message.Text, comboBoxEx_group.SelectedItem.ToString()) == 1)
                {
                    MessageBox.Show("Thêm thành công !!");
                    txt_id.Text = "";
                    txt_name.Text = "";
                    txt_address.Text = "";
                    txt_phonenumber.Text = "";
                    txt_email.Text = "";
                    txt_message.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm không thành công !!");
                }
            }
        }
    }
}
