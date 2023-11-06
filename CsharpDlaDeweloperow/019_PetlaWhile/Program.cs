internal class Program
{
    private static void Main(string[] args)
    {
        string[] samochody = { "Volvo", "BMW", "Mazda" };

        int i = 0;
        while (i < samochody.Length)
        {
            Console.WriteLine(samochody[i]);

            if (samochody[i] == "BMW")
            {
                Console.WriteLine("PaPa");
                break;
            }
            i++;
        }
    }
}