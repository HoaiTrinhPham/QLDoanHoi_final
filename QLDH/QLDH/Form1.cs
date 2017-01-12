using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuongTrinh_Click(object sender, EventArgs e)
        {
            FormChuongTrinh fci = new FormChuongTrinh();
            fci.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn fci = new FormCheckIn();
            fci.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien fci = new FormSinhVien();
            fci.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormReport frp = new FormReport();
            frp.Show();
        }
    }
}
