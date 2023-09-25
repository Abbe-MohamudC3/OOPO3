using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Swan : Bird 
    {
        public string FeatherSize { get; set; }

        public Swan(string name, double whingspan, int age, string description, string feathersize) :
            base(name, whingspan, age, description)
        {
            FeatherSize = feathersize;
        }
        public override string Stats()
        {
            return base.Stats() + $", feather size: {FeatherSize}";
        }
    }
}
