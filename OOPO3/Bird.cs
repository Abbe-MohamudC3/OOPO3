using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Bird : Animal 
    {
        public double WingSpan { get; set; }

        public Bird(string name, double whingspan, int age, string description) :
            base(name, age, description)
        {
            WingSpan = whingspan;
        }

        public override void DoSound()
        {
            Console.WriteLine("jrii jrii ... jrii");
        }
        public override string Stats()
        {
            return base.Stats() + $", Wingspan: {WingSpan}";
        }
    }
}
