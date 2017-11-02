using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Mammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog()
        {
            Name = "Rex";
            Age = 7;
            Color = "Brown";

        }

        public void Bark()
        {
            Console.WriteLine("two plus two is four, minus one that's three, quick maths");

        }
        public int CalcDogYears()
        {
            var humanYears = Age * 7;
                return humanYears;
        }
    }
}
