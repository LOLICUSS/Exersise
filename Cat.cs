using System;

namespace Exs._1
{
    public class Cat: Animal
    {
        public override void Voice()
        {   
            Console.WriteLine(Name);
            Console.WriteLine("МЯЯЯУУУ");
        }
    }
}