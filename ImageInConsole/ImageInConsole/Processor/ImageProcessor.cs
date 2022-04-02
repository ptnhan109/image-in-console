using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageInConsole.Processor
{
    public class ImageProcessor
    {
        public static Bitmap GetBitmap(string path)
            => new Bitmap(path);

        public static Screen GetScreen(Bitmap bitmap)
            => new Screen()
            {
                Height = bitmap.Height,
                Width = bitmap.Width
            };

        public static List<ConsoleColor> GetColors(Bitmap bitmap)
        {
            var data = new List<ConsoleColor>();
            for(int width = 0; width < bitmap.Height; width++)
            {
                for(int height = 0; height < bitmap.Width; height++)
                {
                    var bitmapColor = bitmap.GetPixel(height, width).ToColor();
                    data.Add(bitmapColor.ToConsoleColor());
                }
            }

            return data;
        }

    }
}
