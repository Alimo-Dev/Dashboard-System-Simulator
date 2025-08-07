using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Main Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Login \n2.Register \n3.Exit");
            Console.WriteLine("<<--------------->>");
            Console.Write("Input Opration: ");
            Console.ResetColor();
        }
        public static void ProfileMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Profile Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Show Profile \n2.Change Password \n3.Delet Account \n4.Log Out \n5.Exit");
            Console.WriteLine("<<--------------->>");
            Console.Write("Input Opration: ");
            Console.ResetColor();
        }
    }
}
