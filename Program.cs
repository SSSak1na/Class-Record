using AccessEncapsulationRecord.Models;

namespace AccessEncapsulationRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Animal animal= new Animal("Male");
            Console.WriteLine(" " + " ");
            Dog dog= new Dog("Dog", "Golden Retriever", "Female");
        }
    }
}