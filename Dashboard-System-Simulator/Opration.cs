using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Opration
    {
        public static void Login(List<string> usernames, List<string> passwords, string user, string pass, ref string currentuser, int index = 0)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Login Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Username: ");
            user = Console.ReadLine();
            Console.Write("Password: ");
            pass = Console.ReadLine();
            Console.ResetColor();
            if (Tool.ToExist(usernames, user) == true)
            {
                index = usernames.IndexOf(user);
                if (user == usernames[index] && pass == passwords[index])
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Welcome");
                    Console.ResetColor();
                    currentuser = user;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password is invalid!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("UserName is invalid!");
                Console.ResetColor();
            }



        }

    }
}
