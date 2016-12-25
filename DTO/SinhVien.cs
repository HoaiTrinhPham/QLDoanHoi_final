using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SinhVien
    {
        private string  mssv;

        public string  MSSV
        {
            get { return mssv; }
            set { mssv = value; }
        }

        private string hosv;

        public string HoSV
        {
            get { return hosv; }
            set { hosv = value; }
        }

        private string tensv;

        public string TenSV
        {
            get { return tensv; }
            set { tensv = value; }
        }

        private string gioitinh;

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        private DateTime ngaysinh;

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private string quequan;

        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }

        private string tongiao;

        public string TonGiao
        {
            get { return tongiao; }
            set { tongiao = value; }
        }

        private string dantoc;

        public string DanToc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }

        private string macd;

        public string MaCD
        {
            get { return macd; }
            set { macd = value; }
        }

        private string makhoa;

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }

        public SinhVien(string Mssv, string Hosv, string Tensv, string Gioitinh, DateTime Ngaysinh, string Quequan, string Tongiao, string Dantoc, string Macd, string Makhoa) 
        {
            mssv = Mssv;
            hosv = Hosv;
            tensv = Tensv;
            gioitinh = Gioitinh;
            ngaysinh = Ngaysinh;
            quequan = Quequan;
            tongiao = Tongiao;
            dantoc = Dantoc;
            macd = Macd;
            makhoa = Makhoa;
        }
    }
}
