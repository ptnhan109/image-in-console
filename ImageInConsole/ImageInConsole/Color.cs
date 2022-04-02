using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImageInConsole
{
    public class ColorImage
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public ColorImage(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public ConsoleColor ToConsoleColor()
        {
            int minSpace = 255 * 3;
            int minIndex = 0;
            var consoleColors = ((ConsoleColor[])Enum.GetValues(typeof(ConsoleColor))).ToList();
            for(int i = 0; i < consoleColors.Count; i++)
            {
                var colorConsole = consoleColors[i].ToColor();
                int space = Math.Abs(Red - colorConsole.Red) 
                    + Math.Abs(Blue - colorConsole.Blue) 
                    + Math.Abs(Red - colorConsole.Red);
                if(space < minSpace)
                {
                    minSpace = space;
                    minIndex = i;
                }
            }

            return consoleColors[minIndex];
        }
    }
}
