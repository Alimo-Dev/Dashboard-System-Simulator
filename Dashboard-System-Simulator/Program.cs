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
            int OprationNumber = 0;
            while (OprationNumber != 3)
            {
<<<<<<< HEAD
=======
                switch (OprationNumber)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                }
>>>>>>> 4af96888de349fcb6be8d95740f924e77b46f417
            }
        }
    }
}
