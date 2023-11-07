using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyWprowadzenie
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;

        private DateTime DzienUrodzin;

        public static int LiczbaInstancji = 0;

        private string numerKontaktowy;
        public string NumerKontaktowy
        {
            get { return numerKontaktowy; }
            set 
            { 
                if(value.Length<9) Console.WriteLine("Nieprawidłowa wartosc Numeru Kontaktowego");
                else numerKontaktowy = value;
            }
        }

        //public string NumerKontaktowy {  get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Console.WriteLine("PierwszyKonstruktor");
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            LiczbaInstancji++;
        }

        public Osoba(DateTime dataUrodzenia, string imie, string nazwisko): this(imie,nazwisko)
        {
            Console.WriteLine("DrugiKonstruktor");
            this.setDzienUrodzin(dataUrodzenia);
        }

        public void setDzienUrodzin(DateTime data)
        {
            if (data > DateTime.Now)
            {
                Console.WriteLine("Podano błędne dane");
            }
            else
            {
                DzienUrodzin = data;
            }
        }

        public DateTime getDzienUrodzin() => DzienUrodzin;
        public void przywitanie()
        {
            Console.WriteLine($"Czesc jestem {this.Imie} i urzodziłem sie {this.getDzienUrodzin()}");
        }


    }
}
