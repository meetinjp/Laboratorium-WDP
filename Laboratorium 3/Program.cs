namespace Laboratorium_3;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie1();
        // Zadanie2();
        // Zadanie3();
        Zadanie4();
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
}
