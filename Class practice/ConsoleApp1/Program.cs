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
            Dog dog1 = new Dog();
            dog1.Age = 7;
            dog1.Name = "Muki";
            dog1.Color = "Red";

            Console.WriteLine("Koera värv: " + dog1.Color + "\nKoera nimi: " + dog1.Name + "\nKoera vanus: " + dog1.Age);

            Dog dog2 = new Dog();
            Console.WriteLine("Andke teise koerale nime: ");
            dog2.Name = Console.ReadLine();
            Console.WriteLine("Andke " + dog2.Name + "'le karva värvi.");
            dog2.Color = Console.ReadLine();
            Console.WriteLine("Kui vana " + dog2.Name + " on? ");
            dog2.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Koera värv: " + dog2.Color + "\nKoera nimi: " + dog2.Name + "\nKoera vanus: " + dog2.Age);

            Dog dog3 = new Dog();
            Console.WriteLine(dog3.Name + "\n" + dog3.Age + "\n" + dog3.Color);
            dog3.Bark();


            Console.WriteLine("Rex'i tegelik vanus on: " + dog3.CalcDogYears());
            Cat cat1 = new Cat();

            Console.WriteLine(cat1.action);



            Console.ReadLine();
        }
    }
}
