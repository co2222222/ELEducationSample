using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEducationSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("Enter a 1st value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2nd value");
            int b = Convert.ToInt32(Console.ReadLine());
            c.Add(a, b);
            c.Divide(a, b);
            c.Multiply(a, b);
            c.Subtract(a, b);
        }
    }
}
