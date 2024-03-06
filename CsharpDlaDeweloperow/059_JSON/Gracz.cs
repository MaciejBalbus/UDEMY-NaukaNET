using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_JSON
{
    internal class Gracz
    {
        public string Nazwa { get; set; }
        public int Poziom { get; set; }
        public int PunktyZycia { get; set; }
        public List<Statystyka> Statystyki { get; set; }
    }
}
