using System;

class Program
{
    public static void Main(string[] args)
    {
        double n = 3.14159, area;

        double raio = double.Parse(Console.ReadLine());

        area = n * (raio * raio);

        Console.WriteLine($"A={area:0.0000}");

    }
}