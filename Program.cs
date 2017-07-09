using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Point
{
    public double X;
    public double Y;
    public double r;

    public void X_axis()
    {
        if (X == 0)
            Console.WriteLine("Точка лежит на оси абсцисс");
        else
            Console.WriteLine("Точка не лежит на оси абсцисс");
    }
    public void Y_axis()
    {
        if (Y == 0)
            Console.WriteLine("Точка лежит на оси ординат");
        else
            Console.WriteLine("Точка не лежит на оси ординат");
    }
    public void Displacement(int n, int m)
    {
        Console.WriteLine("Координаты точки до смещения: ({0};{1})", X, Y);
        Console.WriteLine("Координаты точки после смещения: ({0};{1})", X + n, Y + m);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point P1 = new Point();
        Console.WriteLine("Введите абсциссу точки");
        P1.X = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ординату точки");
        P1.Y = int.Parse(Console.ReadLine());
        P1.X_axis();
        P1.Y_axis();
        P1.r = Math.Sqrt(Math.Pow(P1.X, 2) + Math.Pow(P1.Y, 2));
        Console.WriteLine("Расстояние от точки до начала координат равно " + P1.r);
        Console.WriteLine("\nВведите смещение по горизонтали");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите смещение по вертикали");
        int m = int.Parse(Console.ReadLine());
        P1.Displacement(n, m);
        Console.ReadKey();
    }
}