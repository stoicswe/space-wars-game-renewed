using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class GameWindow
    {
        public static readonly string _GAME_TITLE = "Space Wars";

        private ConsoleColor consoleColor;
        private int windowHeight;
        private int windowWidth;

        public GameWindow()
        {
            consoleColor = ConsoleColor.White;
            windowHeight = 50;
            windowWidth = 60;
            this.apply();
        }

        public void apply()
        {
            try
            {
                Console.Title = _GAME_TITLE;
                Console.ForegroundColor = this.consoleColor;
                Console.WindowHeight = this.windowHeight;
                Console.WindowWidth = this.windowWidth;
            } catch (Exception e) { }
        }

        public void apply(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
            Console.ForegroundColor = this.consoleColor;
        }

        public void apply(int windowWidth, int windowHeight)
        {
            this.windowWidth = windowWidth;
            this.windowHeight = windowHeight;
            this.apply();
        }
    }
}
