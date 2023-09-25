using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class Person
    {
        private int age; 
        private string fName;
        private string lName;
        private double height { get; set; } 
        private double weight {  get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än 0.");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Förnamn ska inte vara mindre än 2 eller mer 10 tecken långt.");
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Efternamn får inte vara mindre än 3 eller mer 15 tecken långt.");
                }
                lName = value;
            }
        }

        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
