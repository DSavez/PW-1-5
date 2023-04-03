using System;
using System.Drawing;

namespace PW3_1
{
    class programm
    {
        static void Main()
        {
            Console.WriteLine("Введите длину");
            int lenght= Convert.ToInt32(Console.ReadLine());
            MyintList list= new MyintList(lenght);
            
            
           

        }
    }
    class MyintList
    {
        public MyintList(int lenght)
        {
            int[] result = new int[lenght];
            Random random = new Random();
            int sum = 0;
            int middleIndex = result.Length / 2;
            for (int i=0;i<result.Length;i++)
            {
                result[i] = random.Next(20);
                sum += result[i] * result[i];
                Console.WriteLine( i+1 + ": " + result[i]);
            }
           
         
            int disp = Convert.ToInt32(sum) / result.Length;
            int sko =disp/result.Length;
            Console.WriteLine("Дисперсия: " + disp);
            Console.WriteLine("СКО: " + sko);
            double median;
            if (result.Length % 2 == 0)
            {
                // если число элементов в массиве четное, то медиана 
                // равна среднему значению двух элементов, находящихся посередине 
                median = (result[middleIndex - 1] + result[middleIndex]) / 2.0;
            }
            else
            {
                // если число элементов в массиве нечетное, то медиана 
                // равна элементу, находящемуся посередине 
                median = result[middleIndex];
            }

            // выводим медиану на экран 
            Console.WriteLine("Медиана: " + median);


        }

    }


}
