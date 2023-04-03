using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());
            SqEquation Solve = new SqEquation(a, b, c);
            Solve.CalculateRoots();
            Console.ReadKey(true);
        }

    }
}
