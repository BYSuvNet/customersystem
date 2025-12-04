namespace CustomerSystem.UI;

public static class Menu
{
    public static int Show(string title, string[] options)
    {
        Console.Clear();

        Console.WriteLine($"--- {title} ---");
        Console.WriteLine();

        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        Console.WriteLine("Välj från listan och tryck enter. 0 för att gå tillbaka.");

        string? input = Console.ReadLine();
        if (int.TryParse(input, out int choice))
        {
            if (choice == 0)
            {
                return -1;
            }
            else if (choice >= 1 && choice <= options.Length)
            {
                return choice - 1;
            }
        }

        Console.WriteLine("Något gick fel med ditt val!");
        Console.ReadKey(true);
        return -1;
    }
}