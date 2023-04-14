using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Food
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public double Price { get; set; }

        public Food(string name, int calories, double price)
        {
            Name = name;
            Calories = calories;
            Price = price;
        }
    }
}
