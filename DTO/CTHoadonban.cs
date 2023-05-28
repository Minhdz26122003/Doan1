using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoadonban
    {
        private string maHDB;
        private string mamon;
        private string tenmon;
        private int soluong;
        private float dongia;
        private float giamgia;
        private float thanhtien;

        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string Mamon { get => mamon; set => mamon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public float Giamgia { get => giamgia; set => giamgia = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }

      
    }
}
