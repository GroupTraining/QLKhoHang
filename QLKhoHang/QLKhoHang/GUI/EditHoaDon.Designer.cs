namespace QLKhoHang.GUI
{
    partial class EditHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMaHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(2, 98);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(646, 163);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(113, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Ngày";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(303, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Kiểu Hóa Đơn";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(510, 17);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Số Lượng";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(179, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // comboBoxHD
            // 
            this.comboBoxHD.DisplayMember = "Text";
            this.comboBoxHD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHD.FormattingEnabled = true;
            this.comboBoxHD.ItemHeight = 14;
            this.comboBoxHD.Location = new System.Drawing.Point(384, 19);
            this.comboBoxHD.Name = "comboBoxHD";
            this.comboBoxHD.Size = new System.Drawing.Size(108, 20);
            this.comboBoxHD.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Location = new System.Drawing.Point(561, 19);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(73, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Location = new System.Drawing.Point(356, 59);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(489, 59);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(12, 19);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "MaHD";
            // 
            // txtMaHD
            // 
            // 
            // 
            // 
            this.txtMaHD.Border.Class = "TextBoxBorder";
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(56, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(67, 20);
            this.txtMaHD.TabIndex = 10;
            // 
            // EditHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.comboBoxHD);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "EditHoaDon";
            this.Text = "EditHoaDon";
            this.Load += new System.EventHandler(this.EditHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxHD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHD;
    }
}