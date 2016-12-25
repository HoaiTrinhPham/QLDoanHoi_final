using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Khoa
    {
        DataAdapter da;
        public DAO_Khoa() 
        {
            da = new DataAdapter();
        }

        public string LayTenKhoaTuMaKhoa(string MaKhoa)
        {
            string sql = @"SELECT TenKhoa FROM Khoa WHERE MaKhoa = N'" + MaKhoa + "'";
            string TenKhoa = "";
            try
            {
                da.Connect();
                TenKhoa = da.ExecuteScalar(sql).ToString();
                da.Disconnet();
                return TenKhoa;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaKhoaTuTenKhoa(string TenKhoa)
        {
            string sql = @"SELECT MaKhoa FROM Khoa WHERE MaKhoa = N'" + TenKhoa + "'";
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
    }
}
