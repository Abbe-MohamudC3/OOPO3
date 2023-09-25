
namespace OOPO3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

           // Person person = new Person();   
           // person.Age = 25;
          //  person.FName = "Test";
            //person.LName = "Testsson";
            

           // Console.WriteLine($" {person.Age} {person.FName} {person.LName}");

           /* PersonHandler handler = new PersonHandler();
            var personer = new List<Person>() 
            { 
                handler.CreatePerson(23,"Anna","Kallesson", 1.65, 65),
                handler.CreatePerson(63,"Kalle","Johansson", 1.82, 92)
            };

             foreach (var person in personer)
             {
                  Console.WriteLine($"Personen " +
                 $"{handler.GetFirstName(person)} {handler.GetLastName} är {handler.GetAge(person)} år, + " +
                 $"{handler.GetHeight(person)} lång och väger {handler.GetWeight(person)} kg.");
             } */

            // F13: Vi lägger till det i classen Bird och resten ärver därifrån 
            // F14: på samma sätt i classen Animal, resten av classerna ärver


            var animals = new List<Animal>();
            {

                animals.Add(new Dog("tutu", "white", 3, "lovely"));
                animals.Add(new Bird("simi", 1.2, 2, "tiny"));
                animals.Add(new Horse("lale", "Black", 11, "fast"));

            };
          

            Console.WriteLine("Animal List:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                if(animal is IPerson) { (animal as IPerson).Talk(); }
                else { animal.DoSound(); }  
            }

            var dogs = new List<Dog>();
            {

                dogs.Add(new Dog("talle", "white", 3, "lovely"));
                dogs.Add(new Dog("nisse", "Brown", 2, "tiny"));
                //dogs.Add(new Horse("jowe", "Black", 11, "fast"));

            };

            // F9: De tillhör olika object
            // F10: Listan ska vara Animal. :) hade själv inte problem först och upptäckte sedan att jag hade en 
            //      Animal Lista.


            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }





        }
    }
}