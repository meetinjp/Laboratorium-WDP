using System.Collections.Immutable;

namespace Laboratorium_5;

class Program
{
    static void Main()
    {
        // Menu.Display();
        Console.WriteLine(Zadanie5());
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

    /// <summary>Zadanie 4</summary>
    static double QuadraticEquation()
    {
        ImmutableArray<char> names = ImmutableArray.Create('x', 'a', 'b', 'c');
        int i = 0;
        double[] values = new double[4];

        do
        {
            Console.Write($"Podaj wartość {names[i]}: ");

            if (!double.TryParse(Console.ReadLine(), out double arg))
            {
                continue;
            }

            values[i++] = arg;
        } while (i < names.Length && i < values.Length);

        return QuadraticEquation(values[0], values[1], values[2], values[3]);
    }

    static decimal Zadanie5()
    {
        int code = 2;
        decimal price = 10;
        decimal tax =
            code == 0
                ? price * 0.08m
                : (
                    code == 1 ? price * 0.23m
                    : code == 2 ? price * 0.17m
                    : price * 0.12m
                );

        return tax;
    }
}
