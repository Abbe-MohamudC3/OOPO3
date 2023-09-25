
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

            PersonHandler handler = new PersonHandler();
            //var personer = new List<Person>() 
            /*{ 
                handler.CreatePerson(23,"Anna","Kallesson", 1.65, 65),
                handler.CreatePerson(63,"Kalle","Johansson", 1.82, 92)
            };*/

           /* foreach (var person in personer)
            {
                 Console.WriteLine($"Personen " +
                $"{handler.GetFirstName(person)} {handler.GetLastName} är {handler.GetAge(person)} år, + " +
                $"{handler.GetHeight(person)} lång och väger {handler.GetWeight(person)} kg.");
            }*/
           
            var animals = new List<Animal>();
            {
                new Bird("tutu", 1.5, 3, "cute");
                new Dog("Wofboy", "brown", 5, "kind");

            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

        }
    }
}