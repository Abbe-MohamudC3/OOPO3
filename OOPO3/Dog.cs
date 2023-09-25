using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Dog : Animal
    {
        public string Colour { get; set; }

        public Dog(string name, string colour, int age, string description) :
            base(name, age, description)
        {
            Colour = colour;
        }

        public override void DoSound()
        {
            Console.WriteLine("woof woof");
        }

        public override string Stats()
        {
            return base.Stats() + $", colour: {Colour}";
        }
        public override string ToString()
        {
            return $"Name: {Name}, Colour: {Colour}, Age: {Age}, Description: {Description}";
        }
    }


}
