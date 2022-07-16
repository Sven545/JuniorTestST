using System;
using System.Collections.Generic;

namespace JuniorTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car car1 = new Car() { Model = "A", Color = "CC" };
            Car car2 = new Car() { Model = "A", Color = "BB" };
            Car car3 = new Car() { Model = "B", Color = "BB" };
            Car car4 = new Car() { Model = "B", Color = "CC" };
            Car car5 = new Car() { Model = "B", Color = "AA" };
            Car car6 = new Car() { Model = "B", Color = "AA" };

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetHashCode());
            }

            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car5.Equals(car6));
        }
    }
}
