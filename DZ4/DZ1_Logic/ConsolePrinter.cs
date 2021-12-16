using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class ConsolePrinter:IPrinter
    {
        private ConsoleColor consoleColor;
        public ConsolePrinter(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }

        public void printWeather(Weather[] weathers)
        {
            Console.ForegroundColor = consoleColor;
            for (int i = 0; i < weathers.Length; i++)
                Console.WriteLine(weathers[i].ToString());
            Console.ResetColor();
        }
    }
}
