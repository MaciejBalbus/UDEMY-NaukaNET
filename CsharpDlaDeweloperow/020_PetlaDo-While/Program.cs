internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Aby zakaczyc wpisz \"x\"");
        string daneWejsciowe;

        do
        {
            daneWejsciowe = Console.ReadLine();
            Console.WriteLine($"ECHO:{daneWejsciowe}");
        }while(daneWejsciowe!="x");
    }
}