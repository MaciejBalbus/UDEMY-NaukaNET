
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imie");

        string? name = Console.ReadLine();

        Console.WriteLine("Witaj " + name);

        string jakisTekst = "jakisTekst";

        char znak = 'j';
        char znakUnicode = '\u006A';

        bool czyGotowy = true;

        DateTime teraz = DateTime.Now;
        DateTime dzienUrodzin = new DateTime(1978, 9, 2);


        byte bajt = 200;

        float zmiennaFloat = 1.5f;
        decimal zmiennaDziesietna = 1.5M;
        double zmiennaRzeczywista = 1.5;  //nie wymaga literki double jest domyslne;

        Console.WriteLine(jakisTekst);
        Console.WriteLine(znak);
        Console.WriteLine(znakUnicode);
        Console.WriteLine(czyGotowy);
        Console.WriteLine(teraz);
        Console.WriteLine("Urodził się w: " + dzienUrodzin);

        Console.WriteLine(bajt);
        Console.WriteLine(zmiennaFloat);
        Console.WriteLine(zmiennaDziesietna);
        Console.WriteLine(zmiennaRzeczywista);

    }
}