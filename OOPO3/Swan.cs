using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Swan : Bird 
    {
        public string TailLength { get; set; }

        public Swan(string name, double wingspan, int age, string description, string taillength) :
            base(name, wingspan, age, description)
        {
            TailLength = taillength;
        }
        public override string Stats()
        {
            return base.Stats() + $", Tail length: {TailLength}";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Wingspan: {WingSpan}, Age: {Age}, Description: {Description}, Tailsize: {TailLength}";
        }
    }
}
