﻿using System;
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
        }
    }
}