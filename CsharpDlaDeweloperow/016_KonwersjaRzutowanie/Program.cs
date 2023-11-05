internal class Program
{
    private static void Main(string[] args)
    {
        byte WartoscBitowa = 111;
        int WartoscInt = WartoscBitowa;
        byte WartoscBitowa2 = (byte)WartoscInt;
        double WartoscDouble = 3.5;
        int WartoscInt2 = (int)WartoscDouble;

        string ciagString = WartoscInt2.ToString();


        Console.WriteLine("Podaj rok uroczenia");

        string userInput = Console.ReadLine();
        int rokUrodzenia;

        if(int.TryParse(userInput,out rokUrodzenia))
        {
            int wiek = DateTime.Now.Year - rokUrodzenia;
            Console.WriteLine("Twój wiek to: " + wiek);
        }
        else
        {
            Console.WriteLine("Nieprawidłowe dane wejsciowe");
        }
    }
}