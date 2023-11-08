using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Ksztalt
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public virtual void Rysuj()
        {
            Console.WriteLine("Rysuje kształt");
        }
    }

    class Kolo:Ksztalt
    {
        public override void Rysuj()
        {
            Console.WriteLine("Rysuje Koło");
        }
    }

    class Prostokont:Ksztalt
    {
        public override void Rysuj()
        {
            Console.WriteLine("Rysuje Prostokat");
        }
    }

    class Trojkat:Ksztalt
    {
        public override void Rysuj()
        {
            Console.WriteLine("Rysuje trojkat");
        }
    }

    class NiePolimorficzny : Ksztalt
    {
        public  void Rysuj()
        {
            Console.WriteLine("Rysuje NiePolimorficzny");
        }
    }




}


