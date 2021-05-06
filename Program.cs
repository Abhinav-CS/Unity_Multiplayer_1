using System;

namespace FPS_GAME_SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FPS GAME SERVER";

            Server.Start(50, 26950);

            Console.ReadKey();
        }
    }
}
