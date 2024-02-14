namespace _052_Cwiczenie9
{
    internal class Program
    {
        public class TemperatureConverter
        {
            public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
            {
                fahrenheit = 32 + (9.0 / 5.0) * celsius;
            }

            public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
            {
                celsius = (fahrenheit - 32) * (5.0 / 9.0);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
