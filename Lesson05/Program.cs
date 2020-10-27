using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doggo();
            CreatePerson();
        }

        private static void Doggo()
        {
            Dogs dog = new Dogs
            {
                Name = "Charlie",
                Breed = "Golden Retriever"
            }; 
            

            Console.Write($"The dog's name is {dog.Name} and he is a {dog.Breed}. The dog says ");
            dog.Bark();
        }

        private static void CreatePerson()
        {
            Person person1 = new Person("Aude", 19, "audenana@gmail.com");
            Person person2 = new Person("Alix", 21);

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
