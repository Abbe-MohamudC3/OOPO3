using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Wolfman : Wolf , IPerson
    {
        public Wolfman(string name, double length, int age, string description) :
            base(name, length, age, description)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Wuuhaaaa...");
        }
    }
}
