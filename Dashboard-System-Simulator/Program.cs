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

            string CurrentUser = null;
            int InputOpration = 0;

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

                }
            }
        }
    }
}
