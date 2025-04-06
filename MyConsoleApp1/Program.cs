using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Program
    {
        static void Greet() // greet feature
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
        }
        static void Main(string[] args)
        {
            Greet();
        }
    }
}
