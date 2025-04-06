using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Program
    {
        static string Greet() 
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello " + name + "!");
            return name;
        }

        static void AgePredict(string name) 
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age)) 
            {
                Console.WriteLine("\n" + name + ", in 5 years you will be " + (age + 5) + " years old!");
            }
            else
            {
                Console.WriteLine("\nEnter your real age!");
                AgePredict(name);
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string name = Greet();
            AgePredict(name);
        }
    }
}
