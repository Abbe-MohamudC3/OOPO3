using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, int nrofspikes, int age, string description) :
            base(name, age, description)
        {
            NrOfSpikes = nrofspikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("nii nii");
        }

        public override string Stats()
        {
            return base.Stats() + $", number of spikes: {NrOfSpikes}";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number of spikes: {NrOfSpikes}, Age: {Age}, Description: {Description}";

        }
    }
}
