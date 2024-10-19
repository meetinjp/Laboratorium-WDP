namespace Laboratorium_2;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie1();
        // Zadanie2();
        // Zadanie3();
        // Zadanie4();
        // Zadanie5();
        Zadanie6();
    }

    static void Zadanie1()
    {
        int number = 5;
        int hundreds = number / 100;
        int tens = number / 10 % 10;
        int ones = number % 10;

        Console.WriteLine($"Cyfra setek: {hundreds}");
        Console.WriteLine($"Cyfra dziesiątek: {tens}");
        Console.WriteLine($"Cyfra jedności: {ones}");
    }

    static void Zadanie2()
    {
        double degrees = 45;
        double radians = degrees * (Math.PI / 180);
        double sinValue = Math.Sin(radians);

        Console.WriteLine(sinValue);
    }

    static void Zadanie3()
    {
        double area = 189;
        double radius = area >= 0 ? Math.Sqrt(189 / Math.PI) : 0;

        Console.WriteLine(radius);
    }

    static void Zadanie4()
    {
        double x = 0.45;
        double a = 1.5;
        double b = 3.2;
        double c = 4;
        double y = a * Math.Pow(x, 2) + b * x + c;

        Console.WriteLine(y);
    }

    static void Zadanie5()
    {
        int a = 12;
        int b = 11;
        int c = 29;
        int max = Math.Max(Math.Max(a, b), c);
        int min = Math.Min(Math.Min(a, b), c);

        Console.WriteLine($"Max = {max}\n");
        Console.WriteLine($"Min = {min}");
    }

    static void Zadanie6()
    {
        double timeInMinutes = 150.2;
        int hours = (int)timeInMinutes / 60;
        int minutes = (int)timeInMinutes % 60;
        int seconds = (int)Math.Round(timeInMinutes % Math.Max(minutes, 1) * 60);

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }
}
