using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Opration
    {
        //--------------------------------
        // Login method
        //--------------------------------
        public static void Login(List<string> usernames, List<string> passwords, string user, string pass, ref string currentuser, int index = 0)
        {
        Again:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Login Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Username: ");
            user = Console.ReadLine().ToLower().Trim();
            Console.Write("Password: ");
            pass = Console.ReadLine().Trim();
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
                    goto Again;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username is invalid or not exist!");
                Console.ResetColor();
            }
        }
    }
}
