namespace CustomerSystem.UI;

public static class ArrowMenu
{
    public static int Show(string title, string[] options, string? exitOption = null)
    {
        int currentSelection = 0;
        Console.CursorVisible = false;

        int totalOptions = options.Length + (string.IsNullOrEmpty(exitOption) ? 0 : 1);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"[ {title} ]");

            for (int i = 0; i < totalOptions; i++)
            {
                string optionText = i < options.Length ? options[i] : exitOption!;
                if (i == currentSelection)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"> {optionText}");
                    Console.ResetColor();
                }
                else Console.WriteLine($"  {optionText}");
            }

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentSelection = (currentSelection - 1 + totalOptions) % totalOptions;
                    break;
                case ConsoleKey.DownArrow:
                    currentSelection = (currentSelection + 1) % totalOptions;
                    break;
                case ConsoleKey.Enter:
                    if (currentSelection == options.Length) return -1;
                    else return currentSelection;
                case ConsoleKey.Escape:
                    return -1;
            }
        }
    }
}