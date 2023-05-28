using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dsbanh
    {
        private string mamon;
        private string tenmon;
        private string manhom;
        private int soluong;
        private float dongia;

        public string Mamon { get => mamon; set => mamon = value; }

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Manhom { get => manhom; set => manhom = value; }
      
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }

        public Dsbanh()
        {

        }

        public Dsbanh(string mamon, string tenmon, string manhom, int soluong, float dongia)
        {
            this.mamon = mamon;
            this.tenmon = tenmon;
            this.manhom = manhom;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
