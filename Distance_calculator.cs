using System;

namespace ConsoleApp1
{
    class Distance_calculator
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            double distance;

            Console.Write("Введите координату x первой точки: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y первой точки: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату x второй точки: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y второй точки: ");
            y2 = int.Parse(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow((double)x2 - (double)x1, 2) + Math.Pow((double)y2 - (double)y1, 2));

            Console.WriteLine($"Расстояние между точками: {distance}");
        }
    }
}
