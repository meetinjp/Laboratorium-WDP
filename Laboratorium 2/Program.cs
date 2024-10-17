namespace Laboratorium_2
{
    internal class Program
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

        public static void Zadanie1()
        {
            int number = 5;
            int cyfraSetek;
            int cyfraDziesiątek;
            int cyfraJedności;

            cyfraSetek = number / 100; // "w zmiennej number jest liczba mniejsza od 1000"
            cyfraDziesiątek = number / 10 % 10;
            cyfraJedności = number % 10;

            Console.WriteLine($"Cyfra setek: {cyfraSetek}");
            Console.WriteLine($"Cyfra dziesiątek: {cyfraDziesiątek}");
            Console.WriteLine($"Cyfra jedności: {cyfraJedności}");
        }

        public static void Zadanie2()
        {
            double degree = 45;
            double sinValue;
            double radians = degree * (Math.PI / 180);

            sinValue = Math.Sin(radians);

            Console.WriteLine(sinValue);
        }

        public static void Zadanie3()
        {
            double area = 189;
            double radius = area >= 0 ? Math.Sqrt(189 / Math.PI) : 0;

            Console.WriteLine(radius);
        }

        public static void Zadanie4()
        {
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y;

            y = a * Math.Pow(x, 2) + b * x + c;

            Console.WriteLine(y);
        }

        public static void Zadanie5()
        {
            int a = 12;
            int b = 11;
            int c = 29;
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);

            Console.WriteLine($"Max = {max}\n\nMin = {min}");
        }

        public static void Zadanie6()
        {
            double time = 150.2; // czas w minutach
            int hours;
            int minutes;
            int seconds;

            hours = (int)time / 60;
            minutes = (int)time % 60;
            seconds = (int)Math.Round(time % Math.Max(minutes, 1) * 60);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
