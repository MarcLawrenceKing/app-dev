using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod();
        }
    }
}
