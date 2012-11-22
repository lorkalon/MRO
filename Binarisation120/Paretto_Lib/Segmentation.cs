using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MRO_Lib;                           

namespace Paretto_Lib
{
    public class Segmentation
    {
        Color[,] bitmap;
        int width;
        int height;
        
        struct Segment
        {
            int x1;
            int x2;
            int y1;
            int y2;
        }


        public Segmentation(Bitmap bmp)
        {
            width = bmp.Width;
            height = bmp.Height;
            bitmap = new Color[width, height];

           for(int i = 0; i<width; i++)
               for (int j = 0; j < height; j++)
               {
                   bitmap[i, j] = bmp.GetPixel(i, j);
               }

           Segment v_arrow = new Segment();
           Segment h_arrow = new Segment();
           Segment v_scale = new Segment();
           Segment h_scale = new Segment();
           Segment points = new Segment();

        }

        void SelectVerticalArrow()
        {
 
        }

        void SelectHorisontalArrow()
        { 

        }

        void SelectPointsArea()
        {
 
        }

        public Bitmap GetSeparatedImage()
        {
            SelectVerticalArrow();  //можно делать одновременно
            SelectHorisontalArrow();
            SelectPointsArea();
            return new Bitmap(10, 10);
        }


    }
}
