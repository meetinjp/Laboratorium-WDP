namespace Laboratorium_5;

public static class Menu
{
    private static string[] _menuItems = new string[6];
    private const int Add = 0;
    private const int RemoveLast = 1;
    private const int Find = 2;
    private const int TotalCost = 3;
    private const int PrintAll = 4;
    private const int Exit = 5;
    private static List<string> _names = new List<string>();
    private static List<decimal> _prices = new List<decimal>();

    public static void Display()
    {
        SetupMenu();
        PrintMenu(2);

        int option = 0;

        while ((option = SelectOptionFromKeyboard()) != Exit)
        {
            ProcessOption(option);
        }

        Console.Clear();
    }

    private static void ProcessOption(int selectedOptionIndex)
    {
        Console.Clear();

        switch (selectedOptionIndex)
        {
            case Add:
                Console.Write("Input product name: ");

                string productName = Console.ReadLine() ?? "";

                if (!string.IsNullOrEmpty(productName))
                {
                    _names.Add(productName);
                }

                Console.Write("Input product price: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal productPrice))
                {
                    _prices.Add(productPrice);

                    break;
                }

                Console.WriteLine("Invalid price!");
                Console.WriteLine("Product not added!");
                _names.Remove(productName);

                break;
            case RemoveLast:
                break;
            case Find:
                break;
            case TotalCost:
                break;
            case PrintAll:
                for (int i = 0; i < _names.Count && i < _prices.Count; ++i)
                {
                    Console.WriteLine($"{i + 1}. {_names[i]} - {_prices[i]}");
                }

                break;
            default:
                break;
        }

        if (selectedOptionIndex != Exit)
        {
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadLine();
        }
    }

    private static void SetupMenu()
    {
        _menuItems[Add] = "1. Add";
        _menuItems[RemoveLast] = "2. Remove last";
        _menuItems[Find] = "3. Find";
        _menuItems[TotalCost] = "4. Total cost";
        _menuItems[PrintAll] = "5. Print all";
        _menuItems[Exit] = "6. Exit";
    }

    private static int SelectOptionFromKeyboard()
    {
        int selectedOptionIndex = 0;

        do
        {
            PrintMenu(selectedOptionIndex);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (--selectedOptionIndex < 0)
                    {
                        selectedOptionIndex = _menuItems.Length - 1;
                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (++selectedOptionIndex >= _menuItems.Length)
                    {
                        selectedOptionIndex = 0;
                    }

                    break;
                case ConsoleKey.Enter:
                    return selectedOptionIndex;
                default:
                    break;
            }
        } while (true);
    }

    private static void PrintMenu(int selectedOptionIndex = 0)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < _menuItems.Length; i++)
        {
            if (i == selectedOptionIndex)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(_menuItems[i]);
        }

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
