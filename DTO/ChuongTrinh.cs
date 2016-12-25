using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuongTrinh
    {
        private string mact;

        public string MaCT
        {
            get { return mact; }
            set { mact = value; }
        }

        private string tenct;

        public string TenCT 
        {
            get { return tenct; }
            set { tenct = value; } 
        }

        private string capdo;

        public string CapDo
        {
            get { return capdo; }
            set { capdo = value; }
        }

        private string thoigian;

        public string ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        public ChuongTrinh(string Mact, string Tenct, string Capdo, string Thoigian) 
        {
            mact = Mact;
            tenct = Tenct;
            capdo = Capdo;
            thoigian = Thoigian;
        }
    }
}
