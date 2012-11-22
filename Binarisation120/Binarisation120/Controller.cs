using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Binarisation120
{
    class Controller
    {
        Color[,] colorMatrix;

        public Controller(Bitmap bmp)
        {
            colorMatrix = new Color[bmp.Width, bmp.Height];

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorMatrix[i, j] = bmp.GetPixel(i, j);
                }
        }
    }
}
