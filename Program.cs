using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapka
{
    class Program
    {
        static void MapGen(int w, int h)
        {
            Console.SetWindowSize(w, h); //w - map widh, h - map height
            char[,] map = new char[w, h];
            char[] znak = { '.', '+', '.', '.', '.', '.', '.', '.', '.' };//,'-','*','/','0','9'
            Random rand = new Random();

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int index = rand.Next(znak.Length);
                    map[i, j] = znak[index];
                }
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {

                    if (map[j, i] == '.')
                    {                        
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '+')
                    {

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '-')
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '*')
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '/')
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '0')
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;

                        Console.Write(map[j, i]);
                    }
                    else if (map[j, i] == '9')
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(map[j, i]);
                    }
                }
                
            }
            //foreach (char item in map)
            //{
            //    if (item == '.')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.Write(" ");
            //    }
            //    else if (item == '+')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.Write(" ");
            //    }
            //    else if (item == '-')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //        Console.Write(" ");
            //    }
            //    else if (item == '*')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.Write(" ");
            //    }
            //    else if (item == '/')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.Write(" ");
            //    }
            //    else if (item == '0')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Magenta;
            //        Console.Write(" ");
            //    }
            //    else if (item == '9')
            //    {
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.Write(" ");
            //    }
            //}
        }
        static void Main(string[] args)
        {
            MapGen(30, 20);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
