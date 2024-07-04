using System;

namespace Exs._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Animal animal = new Animal();
            animal.Voice();
            
            Animal[] animals = new Animal[3];

            
            Cat cat = new Cat();
            cat.Name = "Barsik";
            
            
            Cow cow = new Cow();
            cow.Name = "Burenka";
            
            
            Dog dog = new Dog();
            dog.Name = "Собака SUKAblyat";
            

            
            
            
            animals[0] = cat;
            animals[1] = cow;
            animals[2] = dog;
            
            
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Voice();
            }

            Console.ReadKey();
        }
    }
}