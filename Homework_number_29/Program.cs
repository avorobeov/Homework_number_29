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
            char symbolFiller = '#';
            char symbolEmptiness = '_';
            int percentFilling = 40;
            int maxValueOfCell = 10;
            int positionY = 2;

            DrawBar(percentFilling, maxValueOfCell, ConsoleColor.Red, positionY, symbolEmptiness, symbolFiller);

            Console.ReadLine();
        }

        private static void DrawBar(int percentFilling, int maxValueOfCell, ConsoleColor color, int positionY, char symbolEmptiness, char symbolFiller)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            double maxPercent = 100.0;
            int filling = Convert.ToInt32(maxValueOfCell * (percentFilling / maxPercent));

            bar = GetBar(filling, bar, symbolFiller);

            Console.SetCursorPosition(0, positionY);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            bar = GetBar(maxValueOfCell, bar, symbolEmptiness, filling);

            Console.Write(bar + ']');
        }

        private static string GetBar(int endIndex, string bar, char symbol, int startIndex = 0)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                bar += symbol;
            }

            return bar;
        }
    }
}
