internal class Program
{
    private static void Main(string[] args)
    {
        string daneWejsciowe="";
        double liczbaPodana;
        double sumaLiczb=0;
        int iloscLiczb=0;
        double? maxLiczba=null;

        Console.WriteLine("Apka wczytuje liczby dopóki nie podasz zera");

        do
        {
            Console.WriteLine("Podaj liczbę: ");
            daneWejsciowe = Console.ReadLine();
            
            if(double.TryParse(daneWejsciowe, out liczbaPodana) )
            {
                sumaLiczb += liczbaPodana;
                
                if (maxLiczba.HasValue) maxLiczba = (maxLiczba > liczbaPodana ? maxLiczba : liczbaPodana);
                else maxLiczba = liczbaPodana;
                iloscLiczb++;
            }else
            {
                Console.WriteLine("Podane dane nie są liczba, spróbuj ponownie");
            }

        } while (daneWejsciowe != "0");

        Console.WriteLine("Liczba maksymalna to: " + maxLiczba);
        Console.WriteLine("Suma liczb to: " + sumaLiczb);
    }
}