namespace QLKhoHang.GUI
{
    partial class frmThemloaisp
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
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnTHÊM = new System.Windows.Forms.Button();
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Location = new System.Drawing.Point(12, 31);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(109, 13);
            this.lbMaLoaiSP.TabIndex = 0;
            this.lbMaLoaiSP.Text = "MÃ LOẠI SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN LOẠI SẢN PHẨM";
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Location = new System.Drawing.Point(86, 161);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(41, 13);
            this.lbMoTa.TabIndex = 2;
            this.lbMoTa.Text = "MÔ TẢ";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(133, 28);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(157, 20);
            this.txtMaLoaiSP.TabIndex = 3;
            this.txtMaLoaiSP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(133, 88);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(157, 20);
            this.txtTenLoaiSP.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(133, 154);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(157, 20);
            this.txtMoTa.TabIndex = 5;
            // 
            // btnTHÊM
            // 
            this.btnTHÊM.Location = new System.Drawing.Point(120, 226);
            this.btnTHÊM.Name = "btnTHÊM";
            this.btnTHÊM.Size = new System.Drawing.Size(75, 23);
            this.btnTHÊM.TabIndex = 6;
            this.btnTHÊM.Text = "THÊM";
            this.btnTHÊM.UseVisualStyleBackColor = true;
            this.btnTHÊM.Click += new System.EventHandler(this.btnTHÊM_Click);
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(358, 31);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(354, 150);
            this.dgvLoaiSanPham.TabIndex = 7;
            this.dgvLoaiSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmThemloaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 261);
            this.Controls.Add(this.dgvLoaiSanPham);
            this.Controls.Add(this.btnTHÊM);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.txtMaLoaiSP);
            this.Controls.Add(this.lbMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaLoaiSP);
            this.Name = "frmThemloaisp";
            this.Text = "frmThemloaisp";
            this.Load += new System.EventHandler(this.frmThemloaisp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnTHÊM;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
    }
}