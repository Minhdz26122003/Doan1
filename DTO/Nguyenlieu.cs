using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguyenlieu
    {
        private string manguyenlieu;
        private string tennguyenlieu;
        private int soluong;
        private float dongia;

        public string Manguyenlieu { get => manguyenlieu; set => manguyenlieu = value; }
        public string Tennguyenlieu { get => tennguyenlieu; set => tennguyenlieu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }

        public Nguyenlieu()
        {

        }

        public Nguyenlieu(string manguyenlieu, string tennguyenlieu, int soluong, float dongia)
        {
            this.manguyenlieu = manguyenlieu;
            this.tennguyenlieu = tennguyenlieu;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
