using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BUS;
using DTO;

namespace QLDH
{
    public partial class FormChuongTrinh : Form
    {
        Bus bus;
        public FormChuongTrinh()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            LoadThongTinChuongTrinh();
            cbCapDo.Items.Add("Cấp Khoa");
            cbCapDo.Items.Add("Cấp Chi");
            cbCapDo.SelectedItem = "Cấp Chi";
        }

        private void LoadThongTinChuongTrinh() 
        {
            try
            {
                dtg_ChuongTrinh.DataSource =  bus.XemChuongTrinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Load thông tin thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongTinRaControl(string MaCT) 
        {
            try
            {
                List<ChuongTrinh> lstCT = bus.LayThongTinChuongTrinh(MaCT);
                txtMaCT.Text = lstCT[0].MaCT.ToString();
                txtTenCT.Text = lstCT[0].TenCT.ToString();
                cbCapDo.SelectedItem = lstCT[0].CapDo.ToString();
                txtThoiGianBatDau.Text = lstCT[0].ThoiGian.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Load thông tin thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_ChuongTrinh_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dtg_ChuongTrinh.SelectedRows) 
            {
                LoadThongTinRaControl(dr.Cells[0].Value.ToString());
            }
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dtg_ChuongTrinh.SelectedRows)
                {
                    bus.XoaChuongTrinh(dr.Cells[0].Value.ToString());
                }
                MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTinChuongTrinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa chương trình thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                bus.ThemChuongTrinh(new ChuongTrinh(txtMaCT.Text, txtTenCT.Text, cbCapDo.SelectedItem.ToString(), txtThoiGianBatDau.Text));
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTinChuongTrinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm chương trình thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {
            try
            {
                bus.CapNhatChuongTrinh(new ChuongTrinh(txtMaCT.Text, txtTenCT.Text, cbCapDo.SelectedItem.ToString(), txtThoiGianBatDau.Text));
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTinChuongTrinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật chương trình thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
