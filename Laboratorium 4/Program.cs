﻿namespace Laboratorium_4;

class Program
{
    static void Main()
    {
        Zadanie6();
    }

    static void Zadanie1()
    {
        double[] factors = { 2.4, 1.9, -0.5 };

        if (factors.Length < 3)
        {
            Console.WriteLine("Nie można obliczyć równania, nie ma wszystkich współczynników.");

            return;
        }

        if (factors.Length > 3)
        {
            Console.WriteLine(
                "Nie można obliczyć równania, zostało podane zbyt wiele współczynników."
            );

            return;
        }

        double x = 2.3;
        double a = factors[0];
        double b = factors[1];
        double c = factors[2];

        Console.WriteLine(a * Math.Pow(x, 2) + b * x + c);
    }

    static void Zadanie2()
    {
        double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };

        for (int i = arr.Length - 1; i >= 0; --i)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void Zadanie3()
    {
        int sum = 0;

        while (int.TryParse(Console.ReadLine(), out int value))
        {
            sum += value;
        }

        Console.WriteLine($"Suma: {sum}");
    }

    static void Zadanie4()
    {
        double[,] arr =
        {
            { 1.1, 3.5, 2.56 },
            { 1.4, 34, 7 },
            { 1.5, 56, 2.6 },
        };
        double b = 4.1;

        foreach (var number in arr)
        {
            if (number <= b)
            {
                continue;
            }

            Console.WriteLine(number);
        }
    }

    static void Zadanie5()
    {
        int height = 0;

        do
        {
            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out height);

            if (height < 0)
            {
                Console.WriteLine("Wpisałeś liczbę ujemną!");
            }
        } while (height <= 0);

        for (int n = 1; n <= height; ++n)
        {
            Console.WriteLine(new string('#', n));
        }
    }

    static void Zadanie6()
    {
        Console.Write("n = ");

        int n = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("values = {");

        string[] input = (Console.ReadLine() ?? "").Split(',');
        double[] values = new double[n];

        for (int i = 0, j = 0; i < input.Length && n > 0; ++i)
        {
            if (i == input.Length - 1 && input[i].EndsWith('}'))
            {
                input[i] = input[i][..^1];
            }

            if (double.TryParse(input[i], out double val))
            {
                values[j++] = val;
            }
        }

        foreach (var x in values)
        {
            Console.WriteLine(x);
        }
    }
}
