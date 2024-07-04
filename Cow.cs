using System;

namespace Exs._1
{
    public class Cow: Animal
    {
        public override void Voice()
        {
            Console.WriteLine(Name);
            Console.WriteLine("МУУУУУ");
        }
    }
}