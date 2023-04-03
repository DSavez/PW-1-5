using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sit=true;
            int n=1;
Seth set = new Seth(n);
            while (sit == true)          
            {
                Console.WriteLine("Введите число "+n);
                n = Convert.ToInt16(Console.ReadLine());
                sit=set.SetNumber(n);
                n++;
                if (n == 0) { n = 1; sit = true; }
            }
            Console.ReadKey(true);
        }
    }
}
