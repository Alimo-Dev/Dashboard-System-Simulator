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
        //--------------------------------
        // Register method
        //--------------------------------
        public static void Register(List<string> userNames, List<string> passWords, List<string> fullNames, List<string> emails, List<string> phoneNumbers, string user, string pass, string fName, string email, string phone, ref string currentUser)
        {
        Again:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Register Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Username: ");
            user = Console.ReadLine().ToLower().Trim();
            Console.Write("Full Name: ");
            fName = Console.ReadLine().ToLower().Trim();
            Console.Write("Password: ");
            pass = Console.ReadLine().Trim();
            Console.Write("Email: ");
            email = Console.ReadLine().ToLower().Trim();
            Console.Write("Phone Number: ");
            phone = Console.ReadLine().Trim();
            Console.ResetColor();

            if (Tool.ToExist(userNames, user) == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tnx For Your Registertion");
                Console.ResetColor();
                userNames.Add(user);
                passWords.Add(pass);
                fullNames.Add(fName);
                emails.Add(email);
                phoneNumbers.Add(phone);
                currentUser = user;
            }
            else
            {
                if (Tool.ToExist(emails, email) == true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("This Email Has Already Been Registered, Go To The Login Page");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Your UserName Is Already To Exist");
                    Console.ResetColor();
                    goto Again;
                }
            }
        }

        //--------------------------------
        // Exit method
        //--------------------------------

        public static void Exit()
        {
            Environment.Exit(0);
        }

        //--------------------------------
        // Show Profile method
        //--------------------------------
        public static void ShowProfile(List<string> userNames, List<string> passWords, List<string> fullNames, List<string> emails, List<string> phoneNumbers, string currentUser, int index)
        {
            index = userNames.IndexOf(currentUser);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Show Profile Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Username: {userNames[index]}");
            Console.WriteLine($"Full Name: {fullNames[index]}");
            Console.WriteLine($"Password: {passWords[index]}");
            Console.WriteLine($"Email: {emails[index]}");
            Console.WriteLine($"Phone Number: {phoneNumbers[index]}");
            Console.Write("Back(Y/N): ");
            Console.ResetColor();
        }

        //--------------------------------
        // Edit Profile method
        //--------------------------------

        public static void EditProfile(List<string> userNames, List<string> passWords, List<string> fullNames, List<string> emails, List<string> phoneNumbers, string currentUser, int index, string user = "", string pass = "", string fName = "", string email = "", string phone = "")
        {
            index = userNames.IndexOf(currentUser);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-----Edit Profile Menu-----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Username: {userNames[index]}");
            Console.Write("Username: ");
            user = Console.ReadLine().ToLower().Trim();
            Console.WriteLine($"Full Name: {fullNames[index]}");
            Console.Write("Full Name: ");
            fName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine($"Password: {passWords[index]}");
            Console.Write("Password: ");
            pass = Console.ReadLine().Trim();
            Console.WriteLine($"Email: {emails[index]}");
            Console.Write("Email: ");
            email = Console.ReadLine().ToLower().Trim();
            Console.WriteLine($"Phone Number: {phoneNumbers[index]}");
            Console.Write("Phone Number: ");
            phone = Console.ReadLine().Trim();

            Tool.AddToList(userNames, passWords,  fullNames,  emails,  phoneNumbers,  currentUser,  index,  user,  pass,  fName,  email,  phone);

            

            //Console.Write("Back(Y/N): ");
            //Console.ResetColor();
        }
    }
}
