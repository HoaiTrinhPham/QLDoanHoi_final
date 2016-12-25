using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Khoa
    {
        private string makhoa;

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }

        private string tenkhoa;

        public string TenKhoa
        {
            get { return tenkhoa; }
            set { tenkhoa = value; }
        }

        public Khoa(string Makhoa, string Tenkhoa)
        {
            makhoa = Makhoa;
            tenkhoa = Tenkhoa;
        }
    }
}
