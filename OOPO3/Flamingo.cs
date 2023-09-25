using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Flamingo : Bird
    {
        public string FeatherClour { get; set; }

        public Flamingo(string name, double whingspan, int age, string description, string featherClour) :
            base(name, whingspan, age, description)
        {
            FeatherClour = featherClour;
        }
        public override string Stats()
        {
            return base.Stats() + $", Feather colour: {FeatherClour}";
        }
        public override string ToString()
        {
            return $"Name: {Name}, Wingspan: {WingSpan}, Age: {Age}, Description: {Description}, Feather colour: {FeatherClour}";

        }


    }
}
