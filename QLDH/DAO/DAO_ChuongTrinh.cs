using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_ChuongTrinh
    {
        DataAdapter da;
        public DAO_ChuongTrinh()
        {
            da = new DataAdapter();
        }
        public List<ChuongTrinh> LayThongTinChuongTrinh(string MaCT)
        {
            string sql = @"SELECT * FROM ChuongTrinh WHERE MaChuongTrinh LIKE '%" + MaCT + "%'";
            List<ChuongTrinh> lstCT = new List<ChuongTrinh>();

            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                string TenCT, TGBD, CapDo;
                while (dr.Read()) 
                {
                    TenCT = dr[1].ToString();
                    TGBD = dr[3].ToString();
                    CapDo = dr[2].ToString();

                    lstCT.Add(new ChuongTrinh(MaCT, TenCT, CapDo, TGBD));
                }
                da.Disconnet();
                return lstCT;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<string> LayTenCT() 
        {
            string sql = @"SELECT TenCT FROM ChuongTrinh";
            List<string> lstCT = new List<string>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read()) 
                {
                    lstCT.Add(dr[0].ToString());
                }
                da.Disconnet();
                return lstCT;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaCTTuTenCT(string TenCT) 
        {
            string sql = @"SELECT MaChuongTrinh FROM ChuongTrinh WHERE TenCT = N'" + TenCT + "'";
            try
            {
                da.Connect();
                string MaCT = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return MaCT;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayTenCTTuMaCT(string MaCT)
        {
            string sql = @"SELECT TenCT FROM ChuongTrinh WHERE MaChuongTrinh = N'" + MaCT + "'";
            try
            {
                da.Connect();
                string TenCT = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return TenCT;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ChuongTrinh> XemChuongTrinh() 
        {
            string sql = @"SELECT * FROM ChuongTrinh";
            List<ChuongTrinh> lstCT = new List<ChuongTrinh>();
            string MaCT, TenCT, CapDo, ThoiGian;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaCT = dr[0].ToString();
                    TenCT = dr[1].ToString();
                    CapDo = dr[2].ToString();
                    ThoiGian = dr[3].ToString();

                    lstCT.Add(new ChuongTrinh(MaCT, TenCT, CapDo, ThoiGian));
                }
                da.Disconnet();
                return lstCT;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int ThemThongTinCheckIn(string MaCT, string MSSV)
        {
            string sql = @"INSERT INTO ThamGiaChuongTrinh VALUES ('" + MaCT + "', '" + MSSV + "')";
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

        public int XoaChuongTrinh(string MaCT) 
        {
            string sql = @"DELETE ChuongTrinh WHERE MaChuongTrinh = N'" + MaCT + "'";
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

        public int ThemChuongTrinh(ChuongTrinh ct)
        {
            string sql = @"INSERT INTO ChuongTrinh VALUES( N'" + ct.MaCT + "', N'" + ct.TenCT + "', N'" + ct.CapDo + "', N'" + ct.ThoiGian + "')";
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

        public int CapNhatChuongTrinh(ChuongTrinh ct)
        {
            string sql = @"UPDATE ChuongTrinh SET TenCT = N'" + ct.TenCT + "', CapDoCT = N'" + ct.CapDo + "', ThoiGianBD = N'" + ct.ThoiGian + "' WHERE MaChuongTrinh = N'" + ct.MaCT + "'";
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

        public List<string> DanhSachChuongTrinhSVThamGia(string MaSV) 
        {
            string sql = @"SELECT MaChuongTrinh FROM DiemDanh WHERE MSSV LIKE N'%" + MaSV + "%'";
            List<string> lstDSThamGia = new List<string>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read()) 
                {
                    lstDSThamGia.Add(dr[0].ToString());
                }
                da.Disconnet();
                return lstDSThamGia;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int DemCTSVThamGia(string MSSV)
        {
            string sql = @"SELECT COUNT(*) FROM DiemDanh WHERE MSSV = N'" + MSSV + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteScalar(sql);
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
