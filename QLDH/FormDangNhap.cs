using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QLDH
{
    public partial class FormDangNhap : Form
    {
        Bus bus;
        public FormDangNhap()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus.KiemTraTaiKhoan(txtUserName.Text, txtPass.Text) == true)
                {
                    this.Close();
                    Program.kiemtradangnhap = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
                throw;
            }
        }
    }
}
