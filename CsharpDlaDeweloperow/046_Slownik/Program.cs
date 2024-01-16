using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Slownik;
internal class Program
{
    public static Dictionary<string ,Waluta> GetWaluty()
    {
        return new Dictionary<string, Waluta>()
        {
            { "usd", new Waluta("usd","Dolar Amerykanski",1) },
            { "eur", new Waluta("eur","Euro",0.83975) },
            { "gbp", new Waluta("gbp", "Funt Brytyjski", 0.74771) },
            { "cad", new Waluta("cad", "Dolar Kanadyjski", 1.30724) },
            { "inr", new Waluta("inr", "Rupia Indyjska", 73.04) },
            { "mxn", new Waluta("mxn", "Peso Mexykanskie", 0.74771) }
        };
    }


    private static void Main(string[] args)
    {
        Dictionary<string,Waluta> waluty = GetWaluty();
        Console.WriteLine("Posaj symbol waluty");
        string daneWejsciowe= Console.ReadLine();

        Waluta wybranaWaluta;

        if (waluty.TryGetValue(daneWejsciowe, out wybranaWaluta))
            Console.WriteLine($"Wybrano {wybranaWaluta.DlugaNazwa} o przeliczniku {wybranaWaluta.Przelicznik}");
        else Console.WriteLine("Podana waluta nie istnieje");

        waluty.Remove("usd");
        waluty.TryAdd("usd", new Waluta("usd", "Dolar Amerykanski", 1));

        Console.WriteLine("*****************Cwiczenie7 * *****************");

        GradeManager gradeManager = new GradeManager();

        gradeManager.AddGrade("Kowalski", 5);
        gradeManager.RemoveGrade("Kowalski", 5);

        Console.WriteLine($"Stednia ocen Kowalski to " + gradeManager.CalculateAverageGrade("Kowalski"));





        Console.WriteLine($"Stednia ocen ziutka to " + gradeManager.CalculateAverageGrade("ziutek"));
        Console.WriteLine($"Stednia ocen jacka to " + gradeManager.CalculateAverageGrade("jacek"));

        Console.WriteLine("Ćwiczenie nr 7");






        Console.WriteLine("KoniecProgramu");
    }
}