using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PlikWord:IPlik
    {
        public string PlikNazwa { get; set; }
        public int Rozmiar { get; set; }
        public DateTime Utworzony { get; set; }
        public void Kompresuj()
        {
            Console.WriteLine("Kompresja Worda");
        }

        public void Drukuj()
        {
            Console.WriteLine($"{PlikNazwa} drukowanie..");
        }
}
}
