using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageInConsole
{
    public static class ColorExtensions
    {
        public static ColorImage ToColor(this Color color)
        => new ColorImage(color.R, color.G, color.B);

        public static ColorImage ToColor(this ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return new ColorImage(0, 0, 0);
                case ConsoleColor.DarkBlue:
                    return new ColorImage(0, 0, 128);
                case ConsoleColor.DarkGreen:
                    return new ColorImage(0, 128, 0);
                case ConsoleColor.DarkCyan:
                    return new ColorImage(0, 128, 128);
                case ConsoleColor.DarkRed:
                    return new ColorImage(128, 0, 0);
                case ConsoleColor.DarkMagenta:
                    return new ColorImage(1, 36, 86);
                case ConsoleColor.DarkYellow:
                    return new ColorImage(238, 237, 240);
                case ConsoleColor.Gray:
                    return new ColorImage(192, 192, 192);
                case ConsoleColor.DarkGray:
                    return new ColorImage(128, 128, 128);
                case ConsoleColor.Blue:
                    return new ColorImage(0, 0, 255);
                case ConsoleColor.Green:
                    return new ColorImage(0, 255, 0);
                case ConsoleColor.Cyan:
                    return new ColorImage(0, 255, 255);
                case ConsoleColor.Red:
                    return new ColorImage(255, 0, 0);
                case ConsoleColor.Magenta:
                    return new ColorImage(255, 0, 255);
                case ConsoleColor.Yellow:
                    return new ColorImage(255, 255, 0);
                case ConsoleColor.White:
                    return new ColorImage(0, 0, 0);
                default:
                    return new ColorImage(0, 0, 0);

            }
        }
    }
}
