internal class Program
{
    private static void Main(string[] args)
    {
        string[] samochody = { "Volvo", "BMW", "Mazda" };

        try
        {
            Console.WriteLine("W bloku try");
            samochody[2] = "Tesla";
            int zero = 0;
            int zmienna = 1 / zero;
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("W bloku catch dla IndexOutOfRangeException");
        }
        catch(Exception ex) 
        {
            Console.WriteLine("W bloku catch dla pozostałych wyjatkow");
        }
        finally 
        {
            Console.WriteLine("W bloku finally");
        }

        Console.WriteLine("Poza try-catch-finally");



    }
}