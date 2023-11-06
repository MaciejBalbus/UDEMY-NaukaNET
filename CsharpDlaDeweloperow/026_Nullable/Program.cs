internal class Program
{
    private static void Main(string[] args)
    {
        int? numer = null;
        Console.WriteLine("Numer to: " + (numer.HasValue ? numer.Value.ToString(): ""));
    }
}