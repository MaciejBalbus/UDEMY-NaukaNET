using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyWprowadzenie
{
    internal class PlikExcel:Plik
    {
        public override void Kompresuj()
        {
            Console.WriteLine("Kompresja Excela");
        }
        public void GenerujRaport()
        {
            //string prop = PrivateProp;
            string prop2 = ProtectedProp;
            Console.WriteLine($"{Nazwa} raport..");
        }
    }
}
