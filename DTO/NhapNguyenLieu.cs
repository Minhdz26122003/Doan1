using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapNguyenLieu
    {
        public string maphieunhap;
        public string mancc;
        private string manhanvien;
        public DateTime ngaynhap;
        public float tongtien;


        public string Maphieunhap { get { return maphieunhap; } set { maphieunhap = value; } }
        public string Mancc { get { return mancc; } set { mancc = value; } }
        public DateTime Ngaynhap { get { return ngaynhap; } set { ngaynhap = value; } }
        public float Tongtien { get { return tongtien; } set { tongtien = value; } }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
    }
}
