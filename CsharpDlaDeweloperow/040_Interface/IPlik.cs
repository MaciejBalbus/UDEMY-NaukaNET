using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPlik
    {
        string PlikNazwa { get; set; }
        int Rozmiar {  get; set; }
        DateTime Utworzony { get; set; }
        void Kompresuj();
    }
}
