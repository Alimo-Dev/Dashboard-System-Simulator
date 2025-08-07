using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public virtual void Run()
        {
            Console.WriteLine("Run");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
}
