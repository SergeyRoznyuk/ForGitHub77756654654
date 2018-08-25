using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!!!");

            Man man = new Man();

            man.name = "Sergey";
            man.age = 31;

            man.Show();

            //Console.WriteLine("I am {0} years old. But is not elder that my best friend.", age);

            Console.Read();
        }
    }
}
