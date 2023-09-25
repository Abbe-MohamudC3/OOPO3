using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        protected Animal(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"{Name}, {Age},{Description}";
        }

      

    }
}
