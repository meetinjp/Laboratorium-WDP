namespace Laboratorium_5;

class Program
{
    static void Main()
    {
        // Menu.Display();
        Console.WriteLine(QuadraticEquation(2.0, 1.0, 2.0, 3.0));
    }

    /// <summary>Zadanie 1</summary>
    static void Print(double number)
    {
        Console.WriteLine($"Wartość argumentu = {number}");
    }

    /// <summary>Zadanie 2</summary>
    static double CircleArea(double radius)
    {
        if (radius < 0)
        {
            return double.NaN;
        }

        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>Zadanie 3</summary>
    static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
    {
        return a * Math.Pow(x, 2) + b * x + c;
    }
}
