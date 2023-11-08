
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class PlikExcel:IPlik
    {
        public string PlikNazwa { get; set; }
        public int Rozmiar { get; set; }
        public DateTime Utworzony { get; set; }
        public void Kompresuj()
        {
            Console.WriteLine("Kompresja Excela");
        }

        public void GenerujRaport()
        {
            Console.WriteLine($"{PlikNazwa} raport..");
        }
    }
}
