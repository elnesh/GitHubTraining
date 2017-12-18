using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTraining
{
    class Program
    {
        public static int calculateMeanYear(List<Car> cars)
        {
            int avarage = 0;
            int sum = 0;

            foreach (Car car in cars)
            {
                sum = sum + car.Year;
            }

            avarage = sum / cars.Count;

            return avarage;
        }

        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda", 2020, "Blue");
            Car car2 = new Car("Nissan", 2010, "Red");

            List<Car> cars = new List<Car> { car1, car2};
            int avarage = calculateMeanYear(cars);

            Console.WriteLine(avarage);
        }
    }
}
