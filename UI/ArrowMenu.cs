namespace CustomerSystem.UI;

public static class ArrowMenu
{
    public static int Show(string title, string[] options)
    {
        int currentSelection = 0;
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"-- {title} --");

            for (int i = 0; i < options.Length; i++)
            {
                if (i == currentSelection)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"> {options[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {options[i]}");
                }
            }

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentSelection = (currentSelection - 1 + options.Length) % options.Length;
                    break;
                case ConsoleKey.DownArrow:
                    currentSelection = (currentSelection + 1) % options.Length;
                    break;
                case ConsoleKey.Enter:
                    return currentSelection;
                case ConsoleKey.Escape:
                    return -1;
            }
        }
    }
}