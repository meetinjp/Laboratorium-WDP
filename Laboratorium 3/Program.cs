namespace Laboratorium_3;

class Program
{
    static void Main()
    {
        Zadanie3();
    }

    static void Zadanie1()
    {
        decimal balance = 56m;
        bool isCreditCardValid = false;
        decimal price = 45m;
        bool canPay = balance >= price && isCreditCardValid;

        Console.WriteLine(canPay);
    }

    static void Zadanie2()
    {
        double a = 5;
        double b = 1;
        double c = 3;
        // Twierdzenie o nierówności trójkąta
        bool isTriangle = a + b > c && b + c > a && c + a > b;

        Console.WriteLine(isTriangle);
    }

    static void Zadanie3()
    {
        double cx = 2.56;
        double cy = 4.6;
        double cradius = 5;
        double x = 6.4;
        double y = 2.234;
        // Równanie okręgu
        bool isOutside = Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) > Math.Pow(cradius, 2);

        Console.WriteLine(isOutside);
    }

    static void Zadanie4()
    {
        int rx = 56;
        int ry = 34;
        int width = 23;
        int height = 12;
        int x = 23;
        int y = 11;
        bool isOnBorder =
            // Górna i dolna krawędź
            ((y == ry || y == ry - height) && x >= rx && x <= rx + width)
            // Lewa i prawa krawędź
            || ((x == rx || x == rx + width) && y <= ry && y >= ry - height);

        Console.WriteLine(isOnBorder);
    }

    static void Zadanie5()
    {
        double a = 2.5;
        double b = -0.5;
        double c = 1.5;
        double delta = Math.Pow(b, 2) - 4 * a * c;
        double epsilon = 1e-10;

        if (Math.Abs(delta) <= epsilon)
        {
            Console.WriteLine($"x_1 = x_2 = {-b / (2 * a)}");

            return;
        }

        if (delta > epsilon)
        {
            double sqrtDelta = Math.Sqrt(delta);

            Console.WriteLine($"x_1 = {(-b - sqrtDelta) / (2 * a)}");
            Console.WriteLine($"x_2 = {(-b + sqrtDelta) / (2 * a)}");

            return;
        }

        Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
    }

    static void Zadanie6()
    {
        int code = 4;
        int quantity = 11;
        decimal price = 3.5m;
        decimal sellPrice = price;
        decimal discountMultiplier = 1.00m;

        if (code >= 10 && code <= 15)
        {
            discountMultiplier = 0.95m;
        }
        else if (code >= 16)
        {
            if (quantity <= 10)
            {
                discountMultiplier = 1.05m;
            }
            else if (quantity > 20 && quantity < 100)
            {
                discountMultiplier -= Math.Floor((decimal)quantity / 10) / 100;
            }
            else if (quantity >= 100)
            {
                discountMultiplier = 0.90m;
            }
        }

        sellPrice = Math.Round(price * discountMultiplier, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine($"Price: {sellPrice}");
    }

    static void Zadanie7()
    {
        int decimalNumber = 11;
        string[] tens = { "", "X", "XX" };
        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        if (decimalNumber >= 1 && decimalNumber <= 20)
        {
            Console.WriteLine(tens[decimalNumber / 10] + units[decimalNumber % 10]);

            return;
        }

        if (decimalNumber == 0)
        {
            Console.WriteLine("Rzymianie nie znali zera!");

            return;
        }

        Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
    }

    static void Zadanie8()
    {
        char hex = '9';

        if (hex >= '0' && hex <= '9')
        {
            Console.WriteLine(hex - '0');

            return;
        }

        hex = char.ToUpper(hex);

        if (hex >= 'A' && hex <= 'F')
        {
            Console.WriteLine(hex - 'A' + 10);

            return;
        }

        Console.WriteLine("To nie jest cyfra szesnastkowa");
    }
}
