using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nguyen_Khac_Minh_Quan
{
    class Menu
    {
        private Draw pen;
        private int[,] menu;
        private int x = 0, y = 0;
        private ConsoleColor bg, fg;

       

        public void SelectMenu()
        {
            string[] selectMenu = { "1. Nhap day so", "2.Sap xep tang dan", "3. Sap xep giam dan", "4. In ket qua", "5. Demo", "6.Thoat" };
        }
        public void Draw()
        {

            int y_ = y;
            Console.ForegroundColor = fg;
            //pen.drawRec(2,2, 32, 29, ConsoleColor.DarkGray);

            for (int i = 0; i < 3; i++)
            {
                int xL = x;
                int yT = y + (i * pen.Height);
                for (int j = 0; j < 3; j++)
                {

                    xL = x + (j * pen.Width);
                    if (menu[i, j] == 1)
                    {
                        pen.drawRec(xL, yT, xL + pen.Width, yT + pen.Height, fg);
                    }
                }
                y_++;
            }

        }
        public void Clear()
        {
            int y_ = y;
            Console.ForegroundColor = bg;

            for (int i = 0; i < 3; i++)
            {
                int xL = x;
                int yT = y + (i * pen.Height);
                for (int j = 0; j < 3; j++)
                {
                    xL = x + (j * pen.Width);
                    if (menu[i, j] == 1)
                    {
                        pen.drawRec(xL, yT, xL + pen.Width, yT + pen.Height, bg);
                    }
                }
                y_++;
            }

        }
        public int Y
        {
            set
            {
                Clear();
                y = value;
                Draw();
            }
            get
            {
                return y;
            }
        }
        public int X
        {
            set
            {
                Clear();
                x = value;
                Draw();
            }
            get
            {
                return x;
            }
        }
    }
}
