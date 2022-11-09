namespace _5_практическая
{
    internal static class tortHelpers
    {

        public static int Arrow()
        {

            int posi = 1;

            ConsoleKeyInfo key = Console.ReadKey();
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                posi--;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {

                posi++;

            }



            Console.SetCursorPosition(0, posi);
            Console.WriteLine("=>");
            return posi;
        }
    }
}