using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLDH
{
    public partial class FormCheckIn : Form
    {
        Bus bus;
        public FormCheckIn()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            txtMSSV.Focus();
            Init();
            LoadCBChuongTrinh();
        }

        private void Init() 
        {
            foreach (Control pnl in this.Controls)
            {
                if (pnl is GroupBox)
                {
                    foreach (Control txt in pnl.Controls)
                    {
                        if (txt is TextBox || txt is ComboBox)
                            txt.Enabled = false;
                    }
                }
            }
        }

        private void LoadThongTinCbGioiTinh()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedItem = "Nam";
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (cbGioiTinh.Items.Count == 0)
                LoadThongTinCbGioiTinh();
            string HoSV = "", TenSV = "", GioiTinh = "", QueQuan = "", TonGiao = "", DanToc = "", MaCD = "", MaKhoa = "";
            DateTime NgaySinh = DateTime.Now;
            List<SinhVien> lstSV = new List<SinhVien>();
            if (txtMSSV.Text != null)
            {
                try
                {
                    lstSV = bus.XemThongTinSinhVien(txtMSSV.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #region Lấy thông tin ra biến
                try
                {
                    HoSV = lstSV[0].HoSV.ToString();
                    TenSV = lstSV[0].TenSV.ToString();
                    GioiTinh = lstSV[0].GioiTinh.ToString();
                    NgaySinh = (DateTime)lstSV[0].NgaySinh;
                    QueQuan = lstSV[0].QueQuan.ToString();
                    TonGiao = lstSV[0].TonGiao.ToString();
                    DanToc = lstSV[0].DanToc.ToString();
                    MaCD = lstSV[0].MaCD.ToString();
                    MaKhoa = lstSV[0].MaKhoa.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin nhập vào không hợp lệ\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMSSV.Focus();
                    txtMSSV.Text = txtMSSV.Text.Substring(0, txtMSSV.TextLength - 1);
                    TraVeThongTinLenControl(HoSV, TenSV, GioiTinh, QueQuan, MaCD, MaKhoa);
                }
                #endregion

                #region Trả thông tin ra control form
                TraVeThongTinLenControl(HoSV, TenSV, GioiTinh, QueQuan, MaCD, MaKhoa);
                #endregion
            }
        }
        
        private void TraVeThongTinLenControl(string HoSV, string TenSV, string GioiTinh, string QueQuan, string MaCD, string MaKhoa)
        {                txtHoSV.Text = HoSV;
                txtTenSV.Text = TenSV;
                if (GioiTinh == "nam" || GioiTinh == "Nam")
                    cbGioiTinh.SelectedItem = "Nam";
                else
                    cbGioiTinh.SelectedItem = "Nữ";
                txtQueQuan.Text = QueQuan;
                try { txtChiDoan.Text = bus.LayTenCDTuMaCD(MaCD); }
                catch (Exception) { }
                try { txtKhoa.Text = bus.LayTenKhoaTuMaKhoa(MaKhoa); }
                catch (Exception) { }
        }

        private void txtMaCT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadCbCapDo() 
        {
            cbCapDo.Items.Add("Cấp Chi");
            cbCapDo.Items.Add("Cấp Khoa");

            cbCapDo.SelectedItem = "Cấp Chi";
        }

        private void LoadCBChuongTrinh() 
        {
            try
            {
                cbTenChuongTrinh.DataSource = bus.LayTenCT();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void cbTenChuongTrinh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCbCapDo();
            try
            {
                string MaCT = bus.LayMaCTTuTenCT(cbTenChuongTrinh.SelectedItem.ToString());
                List<ChuongTrinh> lst = bus.LayThongTinChuongTrinh(MaCT);
                txtTenCT.Text = lst[0].TenCT.ToString();
                cbCapDo.SelectedItem = lst[0].CapDo.ToString();
                txtThoiGian.Text = lst[0].ThoiGian.ToString();
            }
            catch (Exception)
            {   
                throw;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bus.ThemThongTinCheckIn(bus.LayMaCTTuTenCT(cbTenChuongTrinh.SelectedItem.ToString()), txtMSSV.Text);
                MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
