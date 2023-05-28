using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loaibanh
    {
        private string manhom;
        private string tennhom;

        public string Manhom { get => manhom; set => manhom = value; }
        public string Tennhom { get => tennhom; set => tennhom = value; }
        public Loaibanh()
        {

        }

        public Loaibanh(string manhom, string tennhom)
        {
            this.manhom = manhom;
            this.tennhom = tennhom;
        }
    }
}
