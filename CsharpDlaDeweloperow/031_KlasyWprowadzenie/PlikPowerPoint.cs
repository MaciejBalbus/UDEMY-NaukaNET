using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyWprowadzenie
{
    internal class PlikPowerPoint : Plik
{
        public override void Kompresuj()
        {
            Console.WriteLine("Kompresja PowerPointa");
        }

        public void Prezentuj()
            {
                Console.WriteLine($"{Nazwa} prezentacja..");
            }

    }
}
