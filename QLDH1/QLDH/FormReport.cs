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
    public partial class FormReport : Form
    {
        Bus bus;
        public FormReport()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPnl.Controls.Clear();
            for (int i = 0; i < bus.DanhSachChuongTrinhSVThamGia(txtMSSV.Text).Count; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 30);
                btn.Name = i.ToString();
                btn.Text = bus.LayTenCTTuMaCT(bus.DanhSachChuongTrinhSVThamGia(txtMSSV.Text)[i]);
                flowLayoutPnl.Controls.Add(btn);
            }
            int soLanThamGia = bus.DanhSachChuongTrinhSVThamGia(txtMSSV.Text).Count ;
            lblTongDiem.Text = (soLanThamGia * 5).ToString();
        }

 
    }
}
