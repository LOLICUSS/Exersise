using System;

namespace Exs._1
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Voice()
        {
            Console.WriteLine("ОНО звучит как:");
        }
    }
}