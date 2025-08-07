using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();

            Animal cat = new Cat();

            cat.Sound();
            
        }
    }
}
