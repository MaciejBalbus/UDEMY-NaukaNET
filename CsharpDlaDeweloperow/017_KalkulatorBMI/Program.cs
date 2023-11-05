internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("****************BMI****************");

        double masaDouble;
        double wzrostDouble;
        string daneWejsciowe;

        Console.WriteLine("Podaj swoją mase ciała w kilogramach");
        daneWejsciowe = Console.ReadLine();

        if(!double.TryParse(daneWejsciowe, out masaDouble))
        {
            Console.WriteLine("Podano nieprawidłowe dane");
            return; 
        }

        Console.WriteLine("Podaj swoj wzrost w metrach");
        daneWejsciowe = Console.ReadLine();

        if (!double.TryParse(daneWejsciowe, out wzrostDouble))
        {
            Console.WriteLine("Podano nieprawidłowe dane");
            return;
        }

        double BMI = masaDouble / (wzrostDouble * wzrostDouble);

        Console.WriteLine("Twoj BMI wynosi: " + BMI);

        if (BMI < 18.5) Console.WriteLine("Niedowaga");
        else if (BMI < 24.9) Console.WriteLine("Waga normalna");
        else if (BMI < 29.9) Console.WriteLine("Nadwaga");
        else if (BMI < 34.9) Console.WriteLine("Nadwaga");
        else Console.WriteLine("Ty grubasku");   
    }
}