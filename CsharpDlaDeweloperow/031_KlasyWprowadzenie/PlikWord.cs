using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyWprowadzenie
{
    internal class PlikWord :Plik
    {
        public override void Kompresuj()
        {
            Console.WriteLine("Kompresja Worda");
        }
        public void Drukuj()
        {
        Console.WriteLine($"{Nazwa} drukowanie..");
        }
}
}
