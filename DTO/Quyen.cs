using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen
    {
        private int maquyen;
        private string tenquyen;

        public int Maquyen { get => maquyen; set => maquyen = value; }
        public string Tenquyen { get => tenquyen; set => tenquyen = value; }

        public Quyen()
        {

        }

        public Quyen(int maquyen, string tenquyen)
        {
            this.maquyen = maquyen;
            this.tenquyen = tenquyen;
        }
    }
}
