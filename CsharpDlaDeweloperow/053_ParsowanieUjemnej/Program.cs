namespace _053_ParsowanieUjemnej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userString="";
            int liczba=0;
            Console.WriteLine("Podaj liczbę ujemną");
            userString = Console.ReadLine();

            if(CzyUjemna(userString,out liczba))
            {
                Console.WriteLine("Podana licza jest liczbą ujemną i wynosi:"+ liczba);
            }
            else
            {
                Console.WriteLine("Podany ciąg nie jest liczbą ujenmą i wynosi: " + userString);
            }
        }

        public static bool CzyUjemna(string? badanyString, out int liczba)
        {
            liczba = 0;
            if (int.TryParse(badanyString, out liczba)&&liczba<0) return true;
            return false;
        }
    }
}
