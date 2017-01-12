using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_SinhVien
    {
        DataAdapter da;
        public DAO_SinhVien() 
        {
            da = new DataAdapter();
        }

        public List<SinhVien> XemThongTinSinhVien(string MSSV)
        {
            string sql = @"SELECT * FROM SinhVien WHERE MSSV LIKE N'%" + MSSV + "%'";
            List<SinhVien> lstSV = new List<SinhVien>();
            string mssv, hosv, tensv, gioitinh, quequan, tongiao, dantoc, macd, makhoa;
            DateTime ngaysinh;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read()) 
                {
                    mssv = MSSV;
                    hosv = dr[1].ToString();
                    tensv = dr[2].ToString();
                    gioitinh = dr[3].ToString();
                    ngaysinh = (DateTime)dr[4];
                    quequan = dr[5].ToString();
                    tongiao = dr[6].ToString();
                    dantoc = dr[7].ToString();
                    macd = dr[8].ToString();
                    makhoa = dr[9].ToString();

                    lstSV.Add(new SinhVien(mssv, hosv, tensv, gioitinh, ngaysinh, quequan, tongiao, dantoc, macd, makhoa));
                }
                da.Disconnet();
                return lstSV;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<SinhVien> XemToanBoSinhVien()
        {
            string sql = @"SELECT * FROM SinhVien";
            List<SinhVien> lstSV = new List<SinhVien>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                string MSSV = "", HoSV = "", TenSV = "", GioiTinh = "", QueQuan = "", TonGiao = "", DanToc = "", MaCD = "", MaKhoa = "";
                DateTime today = DateTime.Now;
                DateTime NgaySinh = Convert.ToDateTime(today.ToShortDateString());
                while (dr.Read())
                {
                    MSSV = dr[0].ToString();
                    HoSV = dr[1].ToString();
                    TenSV = dr[2].ToString();
                    GioiTinh = dr[3].ToString();
                    NgaySinh = (DateTime)dr[4];
                    QueQuan = dr[5].ToString();
                    TonGiao = dr[6].ToString();
                    DanToc = dr[7].ToString();
                    MaCD = dr[8].ToString();
                    MaKhoa = dr[9].ToString();

                    lstSV.Add(new SinhVien(MSSV, HoSV, TenSV, GioiTinh, NgaySinh, QueQuan, TonGiao, DanToc, MaCD, MaKhoa));
                }
                da.Disconnet();
                return lstSV;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int ThemSinhVien(SinhVien sv)
        {
            string sql = @"INSERT INTO SinhVien VALUES ( N'" + sv.MSSV + "', N'" + sv.HoSV + "', N'" + 
                sv.TenSV + "', N'" + sv.GioiTinh + "', N'" + sv.NgaySinh + "', N'" + sv.QueQuan + "', N'" +
                sv.TonGiao + "', N'" + sv.DanToc + "', N'" + sv.MaCD + "', '" + sv.MaKhoa + "')";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int XoaSinhVien(string MaSV)
        {
            string sql = @"DELETE SinhVien FROM SinhVien WHERE MSSV = N'" + MaSV + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int SuaSinhVien(SinhVien sv)
        {
            string sql = @"UPDATE SinhVien SET HoSV = N'" + sv.HoSV + "', TenSV = N'" + sv.TenSV + "', GioiTinh = N'" +
                sv.GioiTinh + "', NgaySinh = N'" + sv.NgaySinh + "', QueQuan = N'" + sv.QueQuan + "', TonGiao = N'" +
                sv.TonGiao + "', DanToc = N'" + sv.DanToc + "', MaChiDoan = N'" + sv.MaCD + "', MaKhoa = N'" + sv.MaKhoa +
                "' WHERE MSSV = N'" + sv.MSSV + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
