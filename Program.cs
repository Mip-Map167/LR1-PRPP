using System;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры треугольника ABC:");
            Console.WriteLine("Вершина А(x1,y1):");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вершина B(x2,y2):");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вершина C(x3,y3):");
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double P = AB + BC + AC;
            Console.WriteLine("Периметр (P) треугольника ABC = " + P);
            double p = (AB + BC + AC) / 2;
            double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            Console.WriteLine("Площадь (S) треугольника ABC = " + S);
            Console.ReadLine(); // это чтобы консоль не закрывалась сразу после завершения программы - я не знаю, почему она закрывается
        }
    }
}