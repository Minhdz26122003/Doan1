using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string Manhanvien;
        private string Tennhanvien;
        private string Gioitinh;
        private string Diachi;
        private string SDT;

        public string Manhanvien1 { get => Manhanvien; set => Manhanvien = value; }
        public string Tennhanvien1 { get => Tennhanvien; set => Tennhanvien = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        public NhanVien()
        {

        }

        public NhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string sDT)
        {
            Manhanvien = manhanvien;
            Tennhanvien = tennhanvien;
            Gioitinh = gioitinh;
            Diachi = diachi;
            SDT = sDT;
        }
    }
}
