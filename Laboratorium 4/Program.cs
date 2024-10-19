namespace Laboratorium_4;

class Program
{
    static void Main()
    {
        Zadanie3();
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
}
