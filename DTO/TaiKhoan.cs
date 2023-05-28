using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string taikhoan;
        public string matkhau;
        private int maquyen;
        public string manhanvien;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }             

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public int Maquyen { get => maquyen; set => maquyen = value; }

        public TaiKhoan()
        {

        }

        public TaiKhoan(string taikhoan, string matkhau, int maquyen, string manhanvien)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.Maquyen = maquyen;
            this.manhanvien = manhanvien;
        }
    }
}
