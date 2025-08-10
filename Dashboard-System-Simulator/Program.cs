using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------
            // Variable and list declarations
            //--------------------------------

            List<string> Usernames = new List<string>();
            List<string> Passwords = new List<string>();

            string CurrentUser = null, user = null, pass = null;
            int InputOpration = 0, index = 0;

            //--------------------------------
            // Add basic value
            //--------------------------------

            Usernames.Add("test");
            Passwords.Add("1234");
            Usernames.Add("admin");
            Passwords.Add("123");

            //--------------------------------
            // Application
            //--------------------------------

            while (true)
            {
                if (CurrentUser == null)
                {
                    Menu.MainMenu();
                    InputOpration = int.Parse(Console.ReadLine());

                    switch (InputOpration)
                    {
                        case 1:
                            Console.Clear();
                            Opration.Login(Usernames,Passwords,user,pass,ref CurrentUser,index);

                            break;

                        case 2:
                            Console.Clear();
                            break;

                        case 3:
                            Console.Clear();
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    Menu.ProfileMenu();
                }
            }
        }
    }
}
