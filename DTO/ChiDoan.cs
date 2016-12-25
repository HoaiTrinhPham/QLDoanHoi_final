using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiDoan
    {
        private string macd;

        public string MaCD
        {
            get { return macd; }
            set { macd = value; }
        }

        private string tencd;

        public string TenCD
        {
            get { return tencd; }
            set { tencd = value; }
        }

        private string makhoa;

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }

        private string soluong;

        public string SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public ChiDoan(string Macd, string Tencd, string Makhoa, string Soluong)
        {
            macd = Macd;
            tencd = Tencd;
            makhoa = Makhoa;
            soluong = Soluong;
        }
    }
}
