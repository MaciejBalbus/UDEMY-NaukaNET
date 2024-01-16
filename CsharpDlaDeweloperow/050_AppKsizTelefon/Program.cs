using _050_AppKsizTelefon;

internal class Program
{
    private static void Main(string[] args)
    {
        string? wybranaOpcja;
        Kontakt kontakt = new Kontakt();

        do
        {
            Console.WriteLine("*****Witaj w programie ksiażka Telefoniczna*****");
            Console.WriteLine("Wybirz dostępną opcję; x to wyjście z programu");

            Console.WriteLine("1 - Dodaj kontak");
            Console.WriteLine("2 - Wyświetl kontakt po numerze");
            Console.WriteLine("3 - Wyświetl wszystkie kontatky");
            Console.WriteLine("4 - Wyszukaj kontakty po nazwie");

            wybranaOpcja = Console.ReadLine();
            Console.Clear();

            switch (wybranaOpcja)
            {
                case "1":
                    Console.WriteLine("Wklepano 1");
                    kontakt.pobierzKontakt();
                    break;
                case "2":
                    Console.WriteLine("Wklepano 2");
                    break;
                case "3":
                    Console.WriteLine("Wklepano 3");
                    break;
                case "4":
                    Console.WriteLine("Wklepano 4");
                    break;
            }


        } while (wybranaOpcja != "x");
    }
}