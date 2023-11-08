using System;

internal class Program
{

    public abstract class Vehicle
    {
        public string Model { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the car: {this.Model}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the car: {this.Model}");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {this.Model}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {this.Model}");
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}