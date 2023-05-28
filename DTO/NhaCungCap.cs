using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string Mancc;
        private string Tenncc;
        private string Diachi;
        private string SDT;


        public string Mancc1 { get => Mancc; set => Mancc = value; }
        public string Tenncc1 { get => Tenncc; set => Tenncc = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        public NhaCungCap()
        {

        }

        public NhaCungCap(string mancc, string tenncc, string diachi, string sDT)
        {
            Mancc = mancc;
            Tenncc = tenncc;
            Diachi = diachi;
            SDT = sDT;
        }
    }
}
