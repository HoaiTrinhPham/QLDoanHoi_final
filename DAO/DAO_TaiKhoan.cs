using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DTO;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        DataAdapter da;
        public DAO_TaiKhoan()
        {
            da = new DataAdapter();
        }
        public bool KiemTraTaiKhoan(string TK, string MK) 
        {
            string sql = @"SELECT COUNT(*) FROM TaiKhoan WHERE ID = N'" + TK + "' AND Pass = N'" + MK + "'";
            bool kiemtra = false;
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                if (rt > 0)
                    kiemtra = true;
                return kiemtra;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
