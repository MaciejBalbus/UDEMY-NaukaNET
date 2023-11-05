internal class Program
{
    private static void Main(string[] args)
    {
        switch(DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Poniedziałek");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Wtorek");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Środa");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Czwartek");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Piątek");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Wekend");
                break;
            default:
                Console.WriteLine("Nieznany dzień tygodnia");
                break;
        }
        
    }
}