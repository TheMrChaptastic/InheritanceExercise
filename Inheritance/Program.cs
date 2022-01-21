using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird tropicbird = new Bird("White-tailed tropicbird" , "White");
            Console.WriteLine($"{tropicbird.Name}: Organs? {tropicbird.HasOrgans}. Is An Animal? {tropicbird.IsAnAnimal}." +
                $"\nColor: {tropicbird.FeatherColor}. Kingdom: {tropicbird.Kingdom}. Class: {tropicbird.AnimalClassName}.");
            tropicbird.Fly();
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile kingCobra = new Reptile("King Cobra" , "Black");
            Console.WriteLine($"{kingCobra.Name}: Organs? {kingCobra.HasOrgans}. Is An Animal? {kingCobra.IsAnAnimal}." +
                $"\nColor: {kingCobra.ScaleColor}. Kingdom: {kingCobra.Kingdom}. Class: {kingCobra.AnimalClassName}.");
            kingCobra.Slither();
        }
    }
}
