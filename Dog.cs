using System;

namespace Exs._1
{
    public class Dog: Animal
    {
        public override void Voice()
        {
            Console.WriteLine(Name);
            Console.WriteLine("ГАВ ГАВ ЕБАТЬ ТВОЙ РОТ");
        }
    }
}