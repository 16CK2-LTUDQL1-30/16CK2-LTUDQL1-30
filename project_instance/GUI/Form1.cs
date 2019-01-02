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

namespace GUI
{
    public partial class frmQuanLyVeXe : Form
    {
        public frmQuanLyVeXe()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmQuanLyVeXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();//thoát chương trình
            }
        }

        private void dtgvDSChuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbDSChuyenXe_Enter(object sender, EventArgs e)
        {
            UserBUS.Instance.Load_DSChuyen(dtgvDSChuyen);
        }
    }
}
