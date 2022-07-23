using System;
using System.Collections.Generic;
using System.Text;

namespace Nguyen_Khac_Minh_Quan
{
    class Draw
    {
        const int WIDTH = 2;
        const int HEIGTH = 1;

        public void drawRec(int xLeft, int yTop, int xRight, int yBottom, ConsoleColor Color)
        {
            for (int y = yTop; y < yBottom; y++)
            {
                for (int x = xLeft; x < xRight; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = Color;
                    Console.CursorVisible = false;
                    Console.Write(' ');
                }
            }
        }
        public int Width
        {
            get
            {
                return WIDTH;
            }
        }
        public int Height
        {
            get
            {
                return HEIGTH;
            }
        }
    }
}
