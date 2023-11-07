using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlasyWprowadzenie;
using ModyfikatoryDostepu;

internal class Program
{
    private static void Main(string[] args)
    {
        Osoba kowalski = new Osoba(new DateTime(1978, 09, 02),"Jan","Kowalski");

        //Property 
        kowalski.NumerKontaktowy = "123456789";
        Console.WriteLine(kowalski.NumerKontaktowy);


        Console.WriteLine($"Dane Kowalskiego:\nimie: {kowalski.Imie}\nnazwisko: {kowalski.Nazwisko}\nData urodzenia: {kowalski.getDzienUrodzin()}");

        kowalski.przywitanie();


        Console.WriteLine($"Ilosc osob {Osoba.LiczbaInstancji}");

        Console.WriteLine("**************Dziedziczenie*****************");

        PlikExcel plikExcel = new PlikExcel();
        plikExcel.Utowrzony=DateTime.Now;
        plikExcel.Nazwa = "Plik-Excel";
        plikExcel.GenerujRaport();

        PlikWord plikWord = new PlikWord();
        plikWord.Utowrzony = DateTime.Now;
        plikWord.Nazwa = "Plik-Word";
        plikWord.Drukuj();

        Class1 test = new Class1();
        test.WlasciwoscPublic= "Wlasciwosc";

        //Plik plik = new Plik();





    }
}
