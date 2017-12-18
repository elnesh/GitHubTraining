using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTraining
{
    public class Car
    {
        public string Model;
        public int Year;
        public string Color;

        public Car (string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }

        public Car()
        {
            Model = "";
            Year = 0;
            Color = "";
        }
    }
}
