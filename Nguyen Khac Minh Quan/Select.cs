
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nguyen_Khac_Minh_Quan
{
    class Select
    {
        //private Menu SelectMenu;
        string[] selectMenu = { "1. Nhap day so", "2.Sap xep tang dan", "3. Sap xep giam dan", "4. In ket qua", "5. Demo", "6.Thoat" };
        public void Run()
        {
            int n = 7;
            int menu;
            int[] myNumbers;
            myNumbers = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Moi Nhap N voi N >= 5 va N<= 5");
                myNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Day N khi chua sap xep");
            Console.WriteLine("N=" + n);
            for (int i = 0; i <= n - 1; i++) // sap xep
            {
                Console.Write("|{0}|", myNumbers[i]);
            }
            for (int k = 1; k <= n; k++)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\nHe thong bat dau sap xep lan {0}", k);
                for (int j = 1; j < n; j++)
                {
                    Array.Sort(myNumbers, 0, k);

                }
                for (int i = 0; i <= n - 1; i++)
                {

                    Console.Write("|{0}|", myNumbers[i]);

                }
            }
            Console.WriteLine("\nDay N sau khi sap xep");
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write("|{0}|", myNumbers[i]);
            }
        }
    
        
 
    }
}
