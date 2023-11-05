internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj roku urodzenia");
        string s_dataUrodzenia;
        s_dataUrodzenia = Console.ReadLine();

        int i_dataUrodzenia = int.Parse(s_dataUrodzenia);

        bool czyUserDorosly = (DateTime.Now.Year -i_dataUrodzenia) >18;

        if (czyUserDorosly)
        {
            Console.WriteLine("Witaj");
        }
        else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)  
        {
            Console.WriteLine("Mamy dzisiaj niedziele");
        }
        else
        {
            Console.WriteLine("Brak dostepu");
        }

        Console.WriteLine("PaPa");
    }
}