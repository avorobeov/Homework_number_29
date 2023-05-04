using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_29
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBar(40, 10, ConsoleColor.Red, 2, '_');

            Console.ReadLine();
        }

        private static void DrawBar(int percentFilling, int maxValue, ConsoleColor color, int position,char symbol)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            double divisor = 100.0;
            int filling = Convert.ToInt32(maxValue * (percentFilling / divisor));

            for (int i = 0; i < filling; i++)
            {
                bar += '#';
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = filling; i < maxValue; i++)
            {
                bar += symbol;
            }

            Console.Write(bar + ']');
        }
    }
}
