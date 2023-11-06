internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dataUrodzenia;
        string daneWejsciowe;

        Console.WriteLine("Podaj date urodzenia");
        daneWejsciowe = Console.ReadLine(); 
        dataUrodzenia=DateTime.Parse(daneWejsciowe);
        Console.WriteLine(dataUrodzenia);

        TimeSpan timeSpan = DateTime.Now - dataUrodzenia;
        Console.WriteLine("Zyjesz już: "+ timeSpan.Days+" dni");

    }
}