using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_AppKsizTelefon
{
    internal class Kontakt
    {
        public string? Nazwa { get ; set; }
        public string? Numer { get; set;}


        public Kontakt(string nazwa = "Brak",string numer = "Brak")
        { 
            this.Nazwa = nazwa;
            this.Numer = numer;
        }
        public void pobierzKontakt()
        {
            Console.WriteLine("Podaj nazwe Kontaktu");
            this.Nazwa= Console.ReadLine();
            Console.WriteLine("Podaj numer Kontaktu");
            this.Numer = Console.ReadLine();
        }
    }
}
