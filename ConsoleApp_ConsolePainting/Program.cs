using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_ConsolePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            while (true)
            {
                ConsoleColor color = (ConsoleColor)rd.Next(16);
                BackgroundColor = color;
                Clear();
                Thread.Sleep(500);
            }
        }
    }
}
