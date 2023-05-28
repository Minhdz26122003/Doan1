using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        private string Makhachhang;
        private string Tenkhachhang;
        private string diachi;
        private string sDT;

       
        public string Diachi { get => diachi; set => diachi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Tenkhachhang1 { get => Tenkhachhang; set => Tenkhachhang = value; }
        public string Makhachhang1 { get => Makhachhang; set => Makhachhang = value; }
        public Khachhang()
        {

        }

        public Khachhang(string makhachhang, string tenkhachhang, string diachi, string sDT)
        {
            Makhachhang = makhachhang;
            Tenkhachhang = tenkhachhang;
            this.diachi = diachi;
            this.sDT = sDT;
        }
    }
}
