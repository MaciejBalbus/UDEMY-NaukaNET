using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   KlasyWprowadzenie
{
    internal abstract class Plik
    {
        public string Nazwa { get; set; }
        public string Rozmiar { get; set; }
        public DateTime Utowrzony { get; set; }
        protected string ProtectedProp { get; set; }
        private string PrivateProp  { get; set; }
        public abstract void Kompresuj();
    }
}
