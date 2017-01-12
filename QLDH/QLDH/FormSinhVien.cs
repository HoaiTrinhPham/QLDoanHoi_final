using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace QLDH
{
    public partial class FormSinhVien : Form
    {
        Bus bus;

        public FormSinhVien()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            Init();
            LoadSinhVienToDataGrid();
        }
       
        private void btn_ThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                string MaCD = bus.LayMaCDTuTenCD(cbChiDoan.SelectedItem.ToString());
                string MaKhoa = bus.LayMaKhoaTuMaCD(MaCD);
                bus.ThemSinhVien(new SinhVien(txtMSSV.Text, txtHoSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(), dateTimePicker1.Value, cbQueQuan.SelectedItem.ToString(), cbTonGiao.SelectedItem.ToString(), cbDanToc.SelectedItem.ToString(), MaCD, MaKhoa));
                MessageBox.Show("Thêm sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVienToDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init()
        {
            #region Load cbGioiTinh
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedItem = "Nam";
            #endregion

            #region Load cbChiDoan
            try
            {
                cbChiDoan.DataSource = bus.LoadTenChiDoan();
            }
            catch (Exception)
            {

                MessageBox.Show("Load chi đoàn thất bại\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            #endregion

            #region Load cbTonGiao
            cbTonGiao.Items.Add("Không");
            cbTonGiao.Items.Add("Phật giáo");
            cbTonGiao.Items.Add("Thiên Chúa giáo");
            cbTonGiao.Items.Add("Tôn giáo khác");

            cbTonGiao.SelectedItem = "Không";
            #endregion

            #region Load quê quán
            string[] queQuan = {"Hà Nội", "TP HCM", "Cần Thơ", "Đà Nẵng", "Hải Phòng", "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", 
            "Bạc Liêu", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng",
            "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", 
            "Hải Dương", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", 
            "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Quảng Bình", 
            "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên",
            "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái", "Phú Yên"};
            for (int i = 0; i < queQuan.Length; i++)
            {
                cbQueQuan.Items.Add(queQuan[i].ToString());
            }
            cbQueQuan.SelectedItem = "Hà Nội";
            #endregion

            #region Load dân tộc
            cbDanToc.Items.Add("Kinh");
            cbDanToc.Items.Add("Tày");
            cbDanToc.Items.Add("Thái");
            cbDanToc.Items.Add("Mường");
            cbDanToc.Items.Add("Khơ Me");
            cbDanToc.Items.Add("H'Mông");
            cbDanToc.Items.Add("Nùng");
            cbDanToc.Items.Add("Hoa");
            cbDanToc.Items.Add("Dao");
            cbDanToc.Items.Add("Khác");

            cbDanToc.SelectedItem = "Kinh";
            #endregion

            dateTimePicker1.Value = DateTime.Now;
        }

        private void LoadSinhVienToDataGrid() 
        {
            try
            {
                dtg_SinhVien.DataSource = bus.XemToanBoSinhVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Load thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void dtg_SinhVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dtg_SinhVien.SelectedRows)
            {
                txtMSSV.Text = dr.Cells[0].Value.ToString();
                txtHoSV.Text = dr.Cells[1].Value.ToString();
                txtTenSV.Text = dr.Cells[2].Value.ToString();
                if (dr.Cells[3].ToString() == "Nam" || dr.Cells.ToString() == "nam")
                    cbGioiTinh.SelectedItem = "Nam";
                else
                    cbGioiTinh.SelectedItem = "Nữ";
                dateTimePicker1.Value = (DateTime)dr.Cells[4].Value;
                cbQueQuan.SelectedItem = dr.Cells[5].Value.ToString();
                cbTonGiao.SelectedItem = dr.Cells[6].Value.ToString();
                cbDanToc.SelectedItem = dr.Cells[7].Value.ToString();
                try{cbChiDoan.SelectedItem = bus.LayTenCDTuMaCD(dr.Cells[8].Value.ToString());}
                catch (Exception){}
                try
                {
                    cbChiDoan.SelectedItem = bus.LayTenKhoaTuMaKhoa(bus.LayMaKhoaTuMaCD(dr.Cells[8].Value.ToString()));
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        private void cbTonGiao_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlg = MessageBox.Show("Bạn muốn xóa sinh viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlg == DialogResult.OK)
                    bus.XoaSinhVien(txtMSSV.Text);
                MessageBox.Show("Xóa sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVienToDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa sinh viên thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {
            try
            {
                string MaCD = bus.LayMaCDTuTenCD(cbChiDoan.SelectedItem.ToString()) ;
                string MaKhoa = bus.LayMaKhoaTuMaCD(MaCD);
                bus.SuaSinhVien(new SinhVien(txtMSSV.Text, txtHoSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(), dateTimePicker1.Value, cbQueQuan.SelectedItem.ToString(), cbTonGiao.SelectedItem.ToString(), cbDanToc.SelectedItem.ToString(), MaCD, MaKhoa));
                MessageBox.Show("Cập nhật sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVienToDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật sinh viên thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
