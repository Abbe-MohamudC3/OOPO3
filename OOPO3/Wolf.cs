using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Wolf : Animal
    {
        public double Length { get; set; }

        public Wolf(string name, double length, int age, string description) :
            base(name, age, description)
        {
            Length = length;
        }

        public override void DoSound()
        {
            Console.WriteLine("wuuuuuuuuu....");
        }

        public override string Stats()
        {
            return base.Stats() + $", Length: {Length}";
        }
        public override string ToString()
        {
            return $"Name: {Name}, Length: {Length}, Age: {Age}, Description: {Description}";
        }
    }
}
