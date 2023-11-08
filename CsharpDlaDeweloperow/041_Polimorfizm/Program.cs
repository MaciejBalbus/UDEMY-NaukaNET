using Polimorfizm;
class Program
{
    private static void Main(string[] args)
    {
        Ksztalt[] ksztalty = { new Kolo(), new Prostokont(), new Trojkat(),new NiePolimorficzny() };

        foreach (Ksztalt ksztalt in ksztalty)
        {
            ksztalt.Rysuj();
        }
        
    }
}