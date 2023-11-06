internal class Program
{
    private static void Main(string[] args)
    {
        string[] samochody = { "Volvo", "BMW", "Mazda" };
        Console.WriteLine(samochody[2]);

        int dlugoscTab = samochody.Length;
        Console.WriteLine("Długosc tablicy Samochodow to: " + dlugoscTab);

        samochody[2] = "Tesla";
        Console.WriteLine("Ostatni element tablicy to: " + samochody[samochody.Length - 1]);



        
    }
}