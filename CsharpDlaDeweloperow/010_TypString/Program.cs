using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string wiadomosc1;
        wiadomosc1 = "jakas wiadomosc";
        Console.WriteLine(wiadomosc1);

        string? wiadomosc2 = null;
        Console.WriteLine(wiadomosc2);

        string wiadomosc3 = string.Empty;
        Console.WriteLine(wiadomosc3);

        string tekst = "On powiedzial \"Czesc\"";
        Console.WriteLine(tekst);

        string katalogWindows = "C:\\windows\\i_takDalej\\i_takDalej";
        Console.WriteLine(katalogWindows);

        string fontsFolder = @"D:\root\fonts";
        Console.WriteLine(fontsFolder);

        string rezultatConcat = string.Concat(tekst, " dopisany string", " kolejny string");
        Console.WriteLine(rezultatConcat);

        string rezultatConcat2 = tekst + " dopisany string" + " kolejny string";
        Console.WriteLine(rezultatConcat2);

        string interpolowany = $"{tekst} i dalsza czesc";
        Console.WriteLine(interpolowany);

        StringBuilder strBuilder = new StringBuilder("Poczatek");
        strBuilder.Append(" dodano");
        strBuilder.Append(" i znowu dodano");
        strBuilder.Append(" i jeszcze dodano");
        Console.WriteLine(strBuilder);
        //lub 
        string rezultat = strBuilder.ToString();
        Console.WriteLine(rezultat);
    }
}