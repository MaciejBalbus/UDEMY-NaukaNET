using Interface;
using System;


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**************Dziedziczenie*****************");

        PlikExcel plikExcel = new PlikExcel();
        plikExcel.Utworzony = DateTime.Now;
        plikExcel.PlikNazwa = "Plik-Excel";
        plikExcel.GenerujRaport();

        PlikWord plikWord = new PlikWord();
        plikWord.Utworzony = DateTime.Now;
        plikWord.PlikNazwa = "Plik-Word";
        plikWord.Drukuj();
    }
}