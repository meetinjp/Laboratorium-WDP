namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
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
    }
}
