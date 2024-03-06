using System;
using System.Data;
namespace _058_ReadFiles
{
    internal class Program
    {

        static void SkanujIDodaj()
        {
            var files = Directory.GetFiles(@"pliki/", "*.txt", SearchOption.AllDirectories);
            foreach (var file in files) 
            {
                File.AppendAllText(file, "\n\n To zostało dodane\n\n");
            }
        }

        static void GenerujFlepa()
        {
            Console.WriteLine("Podaj imie");
            var imie = Console.ReadLine();

            Console.WriteLine("Podaj jakis numer");
            var numer = Console.ReadLine();

            var szablon = File.ReadAllText(@"pliki/szablon.txt");

            var dokument = szablon.Replace("{nazwa}", imie).
                                   Replace("{orderNumber}", numer).
                                   Replace("{data}", DateTime.Now.ToString());

            File.WriteAllText($"pliki/dokument-{imie}.txt", dokument);

        }
        static void LadujPlik()
        {
            var dokument1 = File.ReadAllText(@"pliki /dokument1.txt");
            var dokument2 = File.ReadAllLines(@"pliki/dokument2.txt");

            var dokument2String =string.Join(Environment.NewLine, dokument2);


            Console.WriteLine("*************************dokument1************************");
            Console.WriteLine(dokument1);

            Console.WriteLine("\n\n\n\n*************************dokument2************************");
            Console.WriteLine(dokument2String);

        }
        static void Main(string[] args)
        {
            //string Napis = "Napis Testowy";

            //File.WriteAllText(@"pliki/myfile.txt", Napis);

            //LadujPlik();

            //GenerujFlepa();

            SkanujIDodaj();

            Console.WriteLine("Hello, World!");
        }
    }
}
