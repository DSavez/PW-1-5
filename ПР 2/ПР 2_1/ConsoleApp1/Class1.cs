using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SqEquation
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public SqEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void CalculateRoots()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);}
else{Console.WriteLine("Действительных корней нет");}
          //  Console.ReadKey();
        }
    }
}
