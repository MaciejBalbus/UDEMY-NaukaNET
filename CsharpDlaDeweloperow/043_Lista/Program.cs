using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

internal class Program
{
    static void PokarzElementy(List<int> lista)
    {
        Console.WriteLine("***Lista***");
        foreach (int element in lista) 
        {
            Console.Write($"{element},");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        List<int> intList = new List<int>() { 6,8,125,3,60,15,150,7,589 };
        PokarzElementy(intList);

        Console.WriteLine("Podaj liczbe");
        string strDaneWejsciowe = Console.ReadLine();
        int intDaneWejsciowe =int.Parse(strDaneWejsciowe);
        intList.Add(intDaneWejsciowe);
        PokarzElementy(intList);

        Console.WriteLine("RemoveRange");
        intList.RemoveRange(1, 2);
        PokarzElementy(intList);

        Console.WriteLine("Sort");
        intList.Sort();
        PokarzElementy(intList);
    }
}