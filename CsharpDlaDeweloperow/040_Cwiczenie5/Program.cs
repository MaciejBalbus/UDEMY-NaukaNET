using System;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Square : IShape
{
    public double Bok { get; set; }

    public Square(double bok)
    { this.Bok = bok; }

    public double CalculateArea()
    { return Bok * Bok; }

    public double CalculatePerimeter()
    { return Bok * 4; }
}

public class Circle : IShape
{
    public double Promien;

    public Circle(double promien)
    { this.Promien = promien; }

    public double CalculateArea()
    { return Promien * Promien * 3.1415; }

    public double CalculatePerimeter()
    { return Promien * 2 * 3.1415; }
}
    // TODO: Uzupełnij implementację klasy Circle, aby implementowała interfejs IShape
    // i posiadała pola, konstruktor(y) oraz implementacje metod CalculateArea i CalculatePerimeter.

class Program
{
    



    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}