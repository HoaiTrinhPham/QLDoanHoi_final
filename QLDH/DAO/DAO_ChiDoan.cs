using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_ChiDoan
    {
        DataAdapter da;
        public DAO_ChiDoan() 
        {
            da = new DataAdapter();
        }

        public string LayTenCDTuMaCD(string MaCD)
        {
            string sql = @"SELECT ChiDoan FROM ChiDoan WHERE MaChiDoan = N'" + MaCD + "'";
            string TenCD = "";
            try
            {
                da.Connect();
                TenCD = da.ExecuteScalar(sql).ToString();
                da.Disconnet();
                return TenCD;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<string> LoadTenChiDoan()
        {
            string sql = @"SELECT ChiDoan FROM ChiDoan";
            List<string> lstChiDoan = new List<string>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read()) 
                {
                    lstChiDoan.Add(dr[0].ToString());
                }
                da.Disconnet();
                return lstChiDoan;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaKhoaTuMaCD(string MaCD) 
        {
            string sql = @"SELECT MaKhoa FROM ChiDoan WHERE MaChiDoan = N'" + MaCD + "'";
            string MaKhoa = "";
            try
            {
                da.Connect();
                MaKhoa = da.ExecuteScalar(sql).ToString();
                da.Disconnet();
                return MaKhoa;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string LayMaCDTuTenCD(string TenCD)
        {
            string sql = @"SELECT MaChiDoan FROM ChiDoan WHERE ChiDoan = N'" + TenCD + "'";
            string MaCD = "";
            try
            {
                da.Connect();
                MaCD = da.ExecuteScalar(sql).ToString();
                da.Disconnet();
                return MaCD;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
 