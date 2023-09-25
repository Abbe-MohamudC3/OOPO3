using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Pelican : Bird
    {
        public string EyeClour { get; set; }

        public Pelican(string name, double whingspan, int age, string description, string eyecolour) :
            base(name, whingspan, age, description)
        {
            EyeClour = eyecolour;
        }
        public override string Stats()
        {
            return base.Stats() + $", eye colour: {EyeClour}";
        }


    }
}
