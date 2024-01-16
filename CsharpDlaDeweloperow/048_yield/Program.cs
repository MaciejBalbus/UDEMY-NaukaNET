using Microsoft.VisualBasic;

namespace _048_yield
{
    internal class Program
    {

        public static IEnumerable<int> GetDate()
        {
            Console.WriteLine("GetDate start");
            var rezultat = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                rezultat.Add(i);
                Console.WriteLine("GetDate petla");
            }
            Console.WriteLine("GetDate przed return");
            return rezultat;
        }



        public static IEnumerable<int> PobierzLiczbe()
        {
            Console.WriteLine("PobierzLiczbe start");
            for (int i = 1;i<=9;i++)
            {
                Console.WriteLine("PobierzLiczbe w petli");
                yield return i;
                if (i % 3 == 0)
                    yield break;
            }
            Console.WriteLine("PobierzLiczbe end");
        }

        static void Main(string[] args)
        {
            var Liczby = PobierzLiczbe();

            foreach (int i in Liczby)
                Console.WriteLine(i);

            var Liczba = new EvenNumberGenerator();

            foreach( var i in Liczba.GenerateEvenNumbers())
            {
                Console.WriteLine($"{i}");
            }




        }
    }
}