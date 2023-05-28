using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonban
    {
        private string maHDB;
        private string makhach;
        private string manhanvien;
        private DateTime ngay;
        private float tongtien;

        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string Makhach { get => makhach; set => makhach = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }

     
    }
}
