using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Program
    {
        static void Main_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Login / Register Menu:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Login \n2.Register \n3.Exit");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            int Opration = 0;
            while (Opration != 3)
            {
            }
        }
    }
}
