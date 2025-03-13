namespace ConsoleMenueUtils
{
    public class ConsoleMenue
    {
        public static void RenderMenue(string[] options, int selectedIndex)
        {
            for (int count = 0; count < options.Length; count++)
            {
                if (count == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(options[count]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine(options[count]);
            }

        }
        public static int UpdateSelection(int currentSelection, ConsoleKey key, string[] options)
        {
            switch (key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    return currentSelection == 0 ? 0 : --currentSelection;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    return currentSelection == options.Length - 1 ? options.Length - 1 : ++currentSelection;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.D1:
                    return currentSelection = 0;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                case ConsoleKey.End:
                case ConsoleKey.Escape:
                    return currentSelection = options.Length - 1;
                default:
                    return currentSelection;
            }

        }

    }

}
