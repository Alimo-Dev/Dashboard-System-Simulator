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
            List<string> FullNames = new List<string>();
            List<string> Emails = new List<string>();
            List<string> PhoneNumbers = new List<string>();

            string CurrentUser = null, user = null, pass = null, Fname = null, Phone = null, Email = null;
            int InputOpration = 0, index = 0;

            //--------------------------------
            // Add basic value
            //--------------------------------

            Usernames.Add("test");
            Passwords.Add("1234");
            FullNames.Add("test testian");
            Emails.Add("test@gmail.com");
            PhoneNumbers.Add("0990");
            Usernames.Add("admin");
            Passwords.Add("123");
            FullNames.Add("admin adminian");
            Emails.Add("admin@gmail.com");
            PhoneNumbers.Add("0991");

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
                            Opration.Login(Usernames, Passwords, user, pass, ref CurrentUser, index);
                            break;

                        case 2:
                            Console.Clear();
                            Opration.Register(Usernames, Passwords, FullNames, Emails, PhoneNumbers, user, pass, Fname, Email, Phone, ref CurrentUser);
                            break;

                        case 3:
                            Console.Clear();
                            Opration.Exit();
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    InputOpration = 0;
                    Menu.ProfileMenu();
                    InputOpration = int.Parse(Console.ReadLine());

                    switch (InputOpration)
                    {
                        case 1:
                        show:
                            Console.Clear();
                            Opration.ShowProfile(Usernames, Passwords, FullNames, Emails, PhoneNumbers, CurrentUser, index);
                            char Operation = char.Parse(Console.ReadLine());
                            if (Operation == 'n')
                            {
                                goto show;
                            }
                            break;


                        case 2:
                            Console.Clear();
                            Opration.EditProfile(Usernames, Passwords, FullNames, Emails, PhoneNumbers, CurrentUser, index, user, pass, Fname, Email, Phone);
                            break;

                        case 5:
                            Console.Clear();
                            Opration.Exit();
                            break;
                    }
                }
            }
        }
    }
}
