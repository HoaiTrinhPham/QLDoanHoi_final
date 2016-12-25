using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class Bus
    {
        #region Tài khoản
        public bool KiemTraTaiKhoan(string TK, string MK) 
        {
            return new DAO_TaiKhoan().KiemTraTaiKhoan(TK, MK);
        }
        #endregion

        #region Sinh viên
        public List<SinhVien> XemThongTinSinhVien(string MSSV) 
        {
            return new DAO_SinhVien().XemThongTinSinhVien(MSSV);
        }

        public List<SinhVien> XemToanBoSinhVien()
        {
            return new DAO_SinhVien().XemToanBoSinhVien();
        }

        public int ThemSinhVien(SinhVien sv)
        {
            return new DAO_SinhVien().ThemSinhVien(sv);
        }

        public int XoaSinhVien(string MaSV)
        {
            return new DAO_SinhVien().XoaSinhVien(MaSV);
        }

        public int SuaSinhVien(SinhVien sv) 
        {
            return new DAO_SinhVien().SuaSinhVien(sv);
        }
        #endregion

        #region Chi đoàn
        public string LayTenCDTuMaCD(string MaCD)
        {
            return new DAO_ChiDoan().LayTenCDTuMaCD(MaCD);
        }

        public List<string> LoadTenChiDoan() 
        {
            return new DAO_ChiDoan().LoadTenChiDoan();
        }

        public string LayMaKhoaTuMaCD(string MaCD) 
        {
            return new DAO_ChiDoan().LayMaKhoaTuMaCD(MaCD);
        }

        public string LayMaCDTuTenCD(string TenCD) 
        {
            return new DAO_ChiDoan().LayMaCDTuTenCD(TenCD);
        }
        #endregion

        #region Khoa
        public string LayTenKhoaTuMaKhoa(string MaKhoa) 
        {
            return new DAO_Khoa().LayTenKhoaTuMaKhoa(MaKhoa);
        }

        public string LayMaKhoaTuTenKhoa(string TenKhoa) 
        {
            return new DAO_Khoa().LayMaKhoaTuTenKhoa(TenKhoa);
        }
        #endregion

        #region Chương trình
        public List<ChuongTrinh> LayThongTinChuongTrinh(string MaCT) 
        {
            return new DAO_ChuongTrinh().LayThongTinChuongTrinh(MaCT);
        }

        public List<string> LayTenCT() 
        {
            return new DAO_ChuongTrinh().LayTenCT();
        }

        public string LayMaCTTuTenCT(string TenCT) 
        {
            return new DAO_ChuongTrinh().LayMaCTTuTenCT(TenCT);
        }

        public int ThemThongTinCheckIn(string MaCT, string MSSV)
        {
            return new DAO_ChuongTrinh().ThemThongTinCheckIn(MaCT, MSSV);
        }

        public List<ChuongTrinh> XemChuongTrinh() 
        {
            return new DAO_ChuongTrinh().XemChuongTrinh();
        }

        public int XoaChuongTrinh(string MaCT)
        {
            return new DAO_ChuongTrinh().XoaChuongTrinh(MaCT);
        }

        public int ThemChuongTrinh(ChuongTrinh ct)
        {
            return new DAO_ChuongTrinh().ThemChuongTrinh(ct);
        }

        public int CapNhatChuongTrinh(ChuongTrinh ct) 
        {
            return new DAO_ChuongTrinh().CapNhatChuongTrinh(ct);
        }

        public List<string> DanhSachChuongTrinhSVThamGia(string MaSV) 
        {
            return new DAO_ChuongTrinh().DanhSachChuongTrinhSVThamGia(MaSV);
        }

        public string LayTenCTTuMaCT(string MaCT) 
        {
            return new DAO_ChuongTrinh().LayTenCTTuMaCT(MaCT);
        }

        public int DemCTSVThamGia(string MSSV)
        {
            return new DAO_ChuongTrinh().DemCTSVThamGia(MSSV);
        }
        #endregion
    }
}
