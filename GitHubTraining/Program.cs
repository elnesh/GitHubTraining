using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTraining
{
    class Program
    {
        public static int CalculateAvgYear(List<Car> cars)
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
            List<Car> cars = new List<Car>();

            cars.Add(new Car("Mazda", 2016, "Blue"));
            cars.Add(new Car("Nissan", 2010, "Red"));
            cars.Add(new Car("Bentley", 1950, "Red"));
            cars.Add(new Car("Toyota", 2012, "White"));

            int avarage = CalculateAvgYear(cars);

            Console.WriteLine(avarage);
        }
    }
}
