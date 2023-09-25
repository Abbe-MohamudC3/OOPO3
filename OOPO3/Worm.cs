using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Worm : Animal
    {
        public bool IsPoisoness { get; set; }

        public Worm(string name, bool ispoisoness, int age, string description) :
            base(name, age, description)
        {
            IsPoisoness = ispoisoness;
        }

        public override void DoSound()
        {
            Console.WriteLine("shhh ... ");
        }
        public override string Stats()
        {
            return base.Stats() + (IsPoisoness ? ", poisness" : ", not poisness");
        }


    }
}
