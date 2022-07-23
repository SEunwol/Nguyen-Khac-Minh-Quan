using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Nguyen_Khac_Minh_Quan
{
    class Program
    {
            private static int x = 0;
            private static int y = 0;
            private static ArrayList myNumber = new ArrayList();

            static void Main(string[] args)
            {
                Reprint();

                MenuOrginal();

                var readKeys = new Task(ReadKeys);
                readKeys.Start();

                var tasks = new[] { readKeys };

                Task.WaitAll(tasks);

                Console.CancelKeyPress += (sender, e) =>
                {
                    Environment.Exit(0);
                };
                

            }
            private static int Y = 2;
            private static void MenuOrginal()
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("+---------+---------+");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("1.Nhap lai day so");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("2.Sap xep tang dan");
                Console.WriteLine("3.Sap xep giam dan");
                Console.WriteLine("4.In ket qua");
                Console.WriteLine("5.Demo sx tang dan");
                Console.WriteLine("6.Thoat");
                Console.WriteLine("+---------+---------+");
            }
            private static void Menu()
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Menu:");
                Console.WriteLine("+---------+---------+");
                Console.WriteLine("1.Nhap lai day so");
                Console.WriteLine("2.Sap xep tang dan");
                Console.WriteLine("3.Sap xep giam dan");
                Console.WriteLine("4.In ket qua");
                Console.WriteLine("5.Demo sx tang dan");
                Console.WriteLine("6.Thoat");
                Console.WriteLine("+---------+---------+");
            }
            private static void Menu4()
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Menu:");
                Console.WriteLine("+---------+---------+");
                Console.WriteLine("1.Nhap lai day so");
                Console.WriteLine("2.Sap xep tang dan");
                Console.WriteLine("3.Sap xep giam dan");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("4.In ket qua");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("5.Demo sx tang dan");
                Console.WriteLine("6.Thoat");
                Console.WriteLine("+---------+---------+");
            }
        private static void ReadKeys()
        {
            // điều hướng bằng mũi tên
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 2)
                        {
                            switch (Y)
                            {
                                case 3:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("1.Nhap lai day so");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 4:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("2.Sap xep tang dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 5:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3.Sap xep giam dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 6:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("4.In ket qua");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 7:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("5.Demo sx tang dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 8:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("6.Thoat");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (Y != 7)
                        {
                            switch (Y)
                            {
                                case 2:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("2.Sap xep tang dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 3:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3.Sap xep giam dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 4:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("4.In ket qua");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 5:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("5.Demo sx tang dan");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 6:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("6.Thoat");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                            }
                        }
                        break;
                    // chọn chạy  lệnh bằng phím
                    case ConsoleKey.Enter:
                        switch (Y)
                        {
                            case 2:
                                Reprint();
                                break;
                            case 3:
                                Sort();
                                Menu4();
                                Y = 5;
                                break;
                            case 4:
                                Reverse();
                                Y = 5;
                                Menu4();
                                break;
                            case 5:
                                Ketqua();
                                Thread.Sleep(1000);
                                Console.WriteLine("\nBam phim bat ky de quay tro lai menu");
                                Console.ReadLine();
                                Y = 2;
                                MenuOrginal();
                                break;
                            case 6:
                                Demo();
                                Thread.Sleep(1000);
                                Console.WriteLine("\nBam phim bat ky de quay tro lai menu");
                                Console.ReadLine();
                                Y = 2;
                                MenuOrginal();
                                break;
                            case 7:
                                System.Environment.Exit(0);
                                break;
                        }
                        break;
                    }
                }
        }
            private static int[] sorted = new int[12];
            private static void Reprint()
            {
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                again:
                Console.Clear();

                int n = 7;
               
                for (int i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine("Moi Nhap N vi tri {0}",i);
                    int t = int.Parse(Console.ReadLine());
                    myNumber.Add(t);
            }

                for (int i = 3; i == 0; i--)
                    {
                        
                        Console.WriteLine("Screen will clear in {0}", i);
                        Thread.Sleep(1000);
                    }
                    Console.CursorVisible = false;

                    MenuOrginal();
            }
            private static void Demo()
            {
                int n = 7;
                for (int k = 1; k <= n; k++)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("\nHe thong bat dau sap xep lan {0}", k);
                    for (int j = 1; j < n; j++)
                    {
                        myNumber.Sort(0,k,null);

                    }
                    Console.Write("+---+---+---+---+---+---+---+\n");
                    for (int i = 0; i <= n - 1; i++)
                    {
                        if (i < 6)
                        {
                            Console.Write("| {0} ", myNumber[i]);
                        }
                        else if (i == 6)
                        {
                            Console.Write("| {0} |", myNumber[i]);
                        }
                    }
                    Console.Write("\n+---+---+---+---+---+---+---+");
                }
            }
            private static void Ketqua()
            {
                int n = 7;
                Console.Clear();
                Console.Write("+---+---+---+---+---+---+---+\n");
                for (int i = 0; i <= n - 1; i++)
                {
                    if(i < 6)
                    {
                        Console.Write("| {0} ", myNumber[i]);
                    }
                    else if(i == 6)
                    {
                        Console.Write("| {0} |", myNumber[i]);
                    }
                }
                Console.Write("\n+---+---+---+---+---+---+---+");
            }
            private static void Sort()
            {
                myNumber.Sort();
            }
            private static void Reverse()
            {
                myNumber.Sort();
                myNumber.Reverse();    
            }
        
     }
}
