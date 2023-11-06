internal class Program
{
    private static void Main(string[] args)
    {
        string[] samochody = { "Volvo", "BMW", "Mazda" };

        foreach(string samochod in samochody)
        {
            Console.WriteLine(samochod);
            if(samochod =="BMW")
            {
                Console.WriteLine("PaPa");
                break;
            }
        }
    }
}