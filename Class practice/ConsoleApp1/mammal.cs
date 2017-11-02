using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mammal
    {
        public Mammal()
        {
            numOfEyes = 2;
            IsCarnivore = true;
            Breath();


        }

        //if there's only "get", then it's read olny, "set" allows you to write a value into it.

        public int Age { get; set; }
        public int numOfEyes { get; set; }
        public bool IsCarnivore { get; set; }
        public void Breath()
        {
            Console.WriteLine("I am breathing!");
        }
        public void SetAge(int age)
        {
            Console.WriteLine(age);
        }

    }
}
