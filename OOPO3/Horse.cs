using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Horse : Animal
    {
        public string Colour {  get; set; }

        public Horse(string name, string colour, int age, string description) :
            base(name, age, description)
        {
            Colour = colour;
        }

        public override void DoSound()
        {
           Console.WriteLine("Ghoof Ghoof");
        }

        public override string Stats()
        {
            return base.Stats() + $", colour: {Colour}";
        }


    }
}
