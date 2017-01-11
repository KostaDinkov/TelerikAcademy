using System;

namespace TelerikDefender
{
    class Pause
    {
        public static void pause()
        {
                    Console.Clear();
                    ConsoleKeyInfo pause = Console.ReadKey();
                    if (pause.Key == ConsoleKey.P)
                    {
                        Game.ConstructPlayField();
                    }
        }

    }
}
