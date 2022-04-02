using ImageInConsole.Processor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "1.jpg");
            var bitmap = ImageProcessor.GetBitmap(path);
            var screen = ImageProcessor.GetScreen(bitmap);
            var data = ImageProcessor.GetColors(bitmap);

            int index = 0;

            for(int width = 0; width < screen.Height; width++)
            {
                for(int height = 0; height < screen.Width; height++)
                {
                    Console.ForegroundColor = data[index];
                    Console.BackgroundColor = data[index];

                    if(data[index] == ConsoleColor.Magenta)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write(".");
                    index++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
