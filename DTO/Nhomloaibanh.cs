using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhomloaibanh
    {
        private string Manhom;
        private string Tennhom;

        public string Manhom1 { get => Manhom; set => Manhom = value; }
        public string Tennhom1 { get => Tennhom; set => Tennhom = value; }

        public Nhomloaibanh()
        {

        }

        public Nhomloaibanh(string manhom, string tennhom)
        {
            Manhom = manhom;
            Tennhom = tennhom;
        }
    }
}
