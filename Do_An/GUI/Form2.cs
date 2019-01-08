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

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Result { get; set; }

        private void btn2HuyVe_Click(object sender, EventArgs e)
        {
            string idGhe = Result;
            string sdt = tb2Sdt.Text;
            if(UserBUS.Instance.HuyVe(idGhe, sdt))
            {
                MessageBox.Show("Hủy thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hủy thất bại,số điện thoại sai");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbViTriGhe2.Text = Result;
            tbViTriGhe2.ReadOnly = true;
        }
    }
}
