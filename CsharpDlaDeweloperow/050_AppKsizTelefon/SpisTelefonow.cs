using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_AppKsizTelefon
{
    internal class SpisTelefonow
    {
        private List<Kontakt> spisTel = new List<Kontakt>();

        public void Dodaj(Kontakt kontakt)
        {
            var SkanSpisTel =spisTel.Where(c =>c.Nazwa==kontakt.Nazwa&&c.Numer==kontakt.Numer).ToList();

            if(SkanSpisTel.Count==0 ) 
            {
                this.spisTel.Add(kontakt);
            }
            else
            {
                Console.WriteLine("Kontakt juz jest na liscie");
            }
        }

        public void WypiszKontakty()
        {
            foreach (var kontakt in spisTel)
            {
                Console.WriteLine(kontakt);
            }
        }

        public void WypiszKontaktyPoNumerze(string numer)
        {
            var SkanSpisTel = spisTel.Where(c => c.Numer == numer).ToList();

            if (SkanSpisTel.Count == 0)
            {
                Console.WriteLine("Nic nie znaleziono");
            }
            else
            {
                foreach (var kontakt in SkanSpisTel)
                {
                    Console.WriteLine(kontakt);
                }

            }
        }

        public void WypiszKontaktyPoFrazie(string fraza)
        {
            var SkanSpisTel = spisTel.Where(c => c.Nazwa.Contains(fraza)).ToList();

            if (SkanSpisTel.Count == 0)
            {
                Console.WriteLine("Nic nie znaleziono");
            }
            else
            {
                foreach (var kontakt in SkanSpisTel)
                {
                    Console.WriteLine(kontakt);
                }

            }
        }


    }
}
