namespace Laboratorium_3;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie1();
        Zadanie2();
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
}
