namespace QLKhoHang.GUI
{
    partial class frmThemsp
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
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTHÊM = new System.Windows.Forms.Button();
            this.dgvThemSP = new System.Windows.Forms.DataGridView();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(10, 34);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(82, 13);
            this.lbMaSP.TabIndex = 0;
            this.lbMaSP.Text = "MÃ SẢN PHẨM";
            this.lbMaSP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(248, 34);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(88, 13);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "TÊN SẢN PHẨM";
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Location = new System.Drawing.Point(512, 33);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(67, 13);
            this.lbMaLoaiSP.TabIndex = 2;
            this.lbMaLoaiSP.Text = "MÃ LOẠI SP";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(711, 33);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(37, 13);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "NGÀY";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(21, 125);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(63, 13);
            this.lbSoLuong.TabIndex = 4;
            this.lbSoLuong.Text = "SỐ LƯỢNG";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(275, 127);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(25, 13);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "GIÁ";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(512, 127);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(52, 13);
            this.lbGhiChu.TabIndex = 6;
            this.lbGhiChu.Text = "GHI CHÚ";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(98, 26);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(119, 20);
            this.txtMaSP.TabIndex = 7;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(342, 27);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(119, 20);
            this.txtTenSP.TabIndex = 8;
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(588, 26);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(104, 20);
            this.txtMaLoaiSP.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 120);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(119, 20);
            this.txtSoLuong.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(332, 120);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(119, 20);
            this.txtGia.TabIndex = 11;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(752, 27);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgay.TabIndex = 13;
            // 
            // btnTHÊM
            // 
            this.btnTHÊM.Location = new System.Drawing.Point(439, 198);
            this.btnTHÊM.Name = "btnTHÊM";
            this.btnTHÊM.Size = new System.Drawing.Size(75, 31);
            this.btnTHÊM.TabIndex = 14;
            this.btnTHÊM.Text = "THÊM";
            this.btnTHÊM.UseVisualStyleBackColor = true;
            // 
            // dgvThemSP
            // 
            this.dgvThemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemSP.Location = new System.Drawing.Point(98, 267);
            this.dgvThemSP.Name = "dgvThemSP";
            this.dgvThemSP.Size = new System.Drawing.Size(778, 201);
            this.dgvThemSP.TabIndex = 15;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(588, 127);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(104, 20);
            this.txtGhiChu.TabIndex = 16;
            // 
            // frmThemsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 480);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dgvThemSP);
            this.Controls.Add(this.btnTHÊM);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbMaLoaiSP);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.lbMaSP);
            this.Name = "frmThemsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnTHÊM;
        private System.Windows.Forms.DataGridView dgvThemSP;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}