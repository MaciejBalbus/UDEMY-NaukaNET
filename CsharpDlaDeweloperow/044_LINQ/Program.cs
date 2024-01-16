using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using KlasyWprowadzenie;
using System.Linq;

class Program
{
    static List<Osoba> GetZatrudnieni()
    {
        List<Osoba> zatrudnieni = new List<Osoba>()
        {
            new Osoba(new DateTime(1990,2,2),"Bill","Ącki"),
            new Osoba(new DateTime(1995,6,3),"Jan","Kowalski"),
            new Osoba(new DateTime(1996,4,3),"Bob","Wojciechowski"),
            new Osoba(new DateTime(2001,2,2),"Janusz","Potrzebowski"),
            new Osoba(new DateTime(2000,2,2),"Alojzy","Trumfel"),
            new Osoba(new DateTime(2005,2,2),"Bob","On"),
            new Osoba(new DateTime(2003,2,2),"Jem","Dzem")
        };
        return zatrudnieni;
    }


    private static void Main(string[] args)
    {
        List<Osoba>zatrudnieni = GetZatrudnieni();

        //Robimy z petli foreach LINQ a potem dodajemy Lambda;

        //List<Osoba> zatrudnieniMlodzi = new List<Osoba>();
        //foreach(Osoba ex in zatrudnieni) 
        //    if(ex.getDzienUrodzin() > new DateTime(2000,1,1)) 
        //        zatrudnieniMlodzi.Add(ex);
        //bool saMlodzi(Osoba pracownik)
        //{
        //    return pracownik.getDzienUrodzin() > new DateTime(2000, 1, 1);
        //}
        List<Osoba> zatrudnieniMlodzi = zatrudnieni.Where(e=>e.getDzienUrodzin()> new DateTime(2000, 1, 1)).ToList();

        //bool maImieBob(Osoba pracownik)
        //{
        //    return pracownik.Imie == "Bob";
        //}

        Osoba bob = zatrudnieniMlodzi.FirstOrDefault(e=>e.Imie=="Bob");
        bob.przywitanie();

        //foreach (Osoba ex in zatrudnieniMlodzi)
        //    ex.przywitanie();

        Console.WriteLine("************Lab************");

        zatrudnieni[3].przywitanie();
        zatrudnieniMlodzi[0].przywitanie();

        zatrudnieni[3].Imie = "Nadymka";

        Console.WriteLine("Zmiana tylko w jednej liscie na Nadymka");

        zatrudnieni[3].przywitanie();
        zatrudnieniMlodzi[0].przywitanie();

        Console.WriteLine("************EndLab************");
        Console.WriteLine($"Dlugosc listy zatrudnieniMlodzi {zatrudnieniMlodzi.Count}");
        






        Console.WriteLine("Koniec Programu");
    }
}