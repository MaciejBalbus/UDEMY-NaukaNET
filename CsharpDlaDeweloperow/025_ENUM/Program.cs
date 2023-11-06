internal class Program
{
    enum Gender: byte
    {
        Facet = 1,
        Kobieta = 2
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj kim jestes 1-facet,2-kobieta");
        string wprowadzonaWartosc;
        wprowadzonaWartosc = Console.ReadLine();

        Gender userGender = (Gender)Enum.Parse(typeof(Gender), wprowadzonaWartosc);

        if (userGender == Gender.Facet) Console.WriteLine("Podajesz sie za faceta");
        else if (userGender == Gender.Kobieta) Console.WriteLine("Podajesz sie za kobiete");
        else Console.WriteLine("Podano nieprawidłowe Dane");
    }
}