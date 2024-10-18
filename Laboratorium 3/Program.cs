namespace Laboratorium_3;

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

    public static void Zadanie1()
    {
        decimal balans = 56;
        bool isCreditCardValid = false;
        decimal price = 45;
        bool canPay;

        canPay = balans >= price && isCreditCardValid;

        Console.WriteLine(canPay);
    }

    public static void Zadanie2()
    {
        double a = 5;
        double b = 1;
        double c = 3;
        bool isTriangle;

        isTriangle = a + b > c && b + c > a && c + a > b; // twierdzenie o nierówności trójkąta

        Console.WriteLine(isTriangle);
    }

    public static void Zadanie3()
    {
        double cx = 2.56;
        double cy = 4.6;
        double cradius = 5;
        double x = 6.4;
        double y = 2.234;
        bool isOutside;

        // (x - a)^2 + (y - b)^2 = r^2
        isOutside = Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) <= Math.Pow(cradius, 2);

        Console.WriteLine(isOutside);
    }

    public static void Zadanie4()
    {
        int rx = 56;
        int ry = 34;
        int width = 23;
        int height = 12;
        int x = 23;
        int y = 11;
        bool isOnBorder;

        isOnBorder =
            // Górna i dolna krawędź
            ((y == ry || y == ry - height) && x >= rx && x <= rx + width)
            // Lewa i prawa krawędź
            || ((x == rx || x == rx + width) && y <= ry && y >= ry - height);

        Console.WriteLine(isOnBorder);
    }

    public static void Zadanie5()
    {
        double x = 1.34;
        double a = 2.5;
        double b = -0.5;
        double c = 1.5;
        double delta = Math.Pow(b, 2) - 4 * a * c;
        double epsilon = 1e-10;

        if (Math.Abs(delta) <= epsilon)
        {
            Console.WriteLine($"x_1 = x_2 = {-b / (2 * a)}");
        }
        else if (delta > epsilon)
        {
            double sqrtDelta = Math.Sqrt(delta);

            Console.WriteLine($"x_1 = {(-b - sqrtDelta) / (2 * a)}");
            Console.WriteLine($"x_2 = {(-b + sqrtDelta) / (2 * a)}");
        }
        else
        {
            Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
        }
    }

    public static void Zadanie6()
    {
        int code = 16;
        int quantity = 21;
        decimal price = 3.5m;
        decimal sellPrice;

        sellPrice = 0m;

        if (code < 10)
        {
            sellPrice = price;
        }
        else if (code <= 15)
        {
            sellPrice = price * 0.95m;
        }
        else
        {
            if (quantity <= 10)
            {
                sellPrice = price * 1.05m;
            }
            else if (quantity <= 20)
            {
                sellPrice = price;
            }
            else if (quantity < 100)
            {
                decimal discountMultiplier = (decimal)quantity / 10 / 100 + 1;

                sellPrice = Math.Round(price * discountMultiplier, 2);
            }
            else
            {
                sellPrice = price * 0.90m;
            }
        }

        Console.WriteLine($"Price: {sellPrice}");
    }
}
