using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TaiKhoan
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public TaiKhoan(string Tk, string Mk)
        {
            id = Tk;
            pass = Mk;
        }
    }
}
