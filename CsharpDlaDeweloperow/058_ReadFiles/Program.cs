using System;
namespace _058_ReadFiles
{
    internal class Program
    {
        static void LadujPlik()
        {
            var dokument1 = File.ReadAllText(@"pliki/dokument1.txt");
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

            LadujPlik();

            Console.WriteLine("Hello, World!");
        }
    }
}
