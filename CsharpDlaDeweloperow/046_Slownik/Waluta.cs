using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    public class Waluta
    {
        public string KrotkaNazwa {  get; set; }
        public string DlugaNazwa { get; set; }
        public double Przelicznik {  get; set; }

        public Waluta(string krotkaNazwa,string dlugaNazwa,double Przelicznik) 
        {
            this.KrotkaNazwa = krotkaNazwa;
            this.DlugaNazwa = dlugaNazwa;
            this.Przelicznik = Przelicznik;        
        }

    }
}
