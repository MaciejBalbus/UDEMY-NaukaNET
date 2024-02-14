using _050_AppKsizTelefon;

internal class Program
{
    private static void Main(string[] args)
    {
        string? wybranaOpcja;
        SpisTelefonow spisKontaktow = new SpisTelefonow();

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
                     Kontakt? kontakt = new Kontakt();
                    kontakt.PobierzKontakt();
                    spisKontaktow.Dodaj(kontakt);
                    kontakt = null;
                    break;
                case "2":
                    Console.WriteLine("Podaj wyszukiwany numer");
                    var numer = Console.ReadLine();
                    spisKontaktow.WypiszKontaktyPoNumerze(numer);
                    break;
                case "3":
                    spisKontaktow.WypiszKontakty();
                    break;
                case "4":
                    Console.WriteLine("Podaj szukana fraze");
                    var fraza = Console.ReadLine();
                    spisKontaktow.WypiszKontaktyPoFrazie(fraza);
                    break;
            }


        } while (wybranaOpcja != "x");
    }
}