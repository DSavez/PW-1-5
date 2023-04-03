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
            Car car_1 = new Car(180, "Toyota Rav 4");
            Car car_2 = new Car(200, "Toyota Rav 5");
            Car car_3 = new Car(210, "Audi A6");
            Car car_4 = new Car(300, "BMW E34 Ильи Мэддисона");

            car_1.Output(180, "Toyota Rav 4");
            


            Dictionary<double, string> speed = new Dictionary<double, string>();
            speed.Add(car_1.maxSpeed, car_1.Name);
            speed.Add(car_2.maxSpeed, car_2.Name);
            speed.Add(car_3.maxSpeed, car_3.Name);
            speed.Add(car_4.maxSpeed, car_4.Name); double name = speed.Keys.Max(); Console.WriteLine("Самая быстрая машина - " + speed[name] + ", летящая со скоростью " + name + " км/ч" + ". У кого-то были сомнения?");
            Console.ReadLine();
        }
    }
    class Car
    {
        public double maxSpeed;
        public string Name; 
        public Car(double maxSpeed, string Name)
        {
            this.Name = Name;
            this.maxSpeed = maxSpeed;
        }
        public void Output(double maxSpeed, string Name)
        {   
            Console.WriteLine($"{maxSpeed} км/ч     {Name}");
        }

    }
}