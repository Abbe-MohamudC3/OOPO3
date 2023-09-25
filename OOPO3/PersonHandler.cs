using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class PersonHandler
    {
        
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
            return person;
            
        }

        public void SetAge(Person person, int age) {person.Age = age;}
        public int GetAge(Person person) { return person.Age; } 
        public void SetFirstName(Person person, String fname) { person.FName = fname; }
        public String GetFirstName(Person person) { return person.FName;}
        public void SetLastName(Person person, String lname) { person.LName = lname; }
        public String GetLastName(Person person) { return person.LName;}
        //public Person GetPerson(Person person) { return person;}
        public void SetHeight(Person person,  double height) { person.Height = height;}
        public double GetHeight(Person person) { return person.Height;}
        public void SetWeight(Person person, double weight) { person.Weight = weight;}  
        public double GetWeight(Person person) {return person.Weight; }  
    }

}
