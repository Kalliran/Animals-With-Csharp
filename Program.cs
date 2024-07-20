/*
  * Author: Michael Corleone
  * Date: 07/20/2024
  * Assignment: CIS214 Performance Assessment - Inheritance & Overriding
  * Description: Main application class
*/
using System;

namespace InheritanceAndOverriding
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Your Name - Week 5 PA Inheritance and Overriding");

      // Create instances of Animal and Cat
      Animal myAnimal = new Animal("Generic Animal", 5);
      Cat myCat = new Cat("Whiskers", 3, "Tabby");

      // Print initial properties
      PrintAnimal(myAnimal);
      PrintAnimal(myCat);

      // Update properties
      myAnimal.Name = "Updated Animal";
      myAnimal.Age = 6;
      myCat.Name = "Updated Whiskers";
      myCat.Age = 4;
      myCat.Breed = "Siamese";

      // Print updated properties
      PrintAnimal(myAnimal);
      PrintAnimal(myCat);
    }

    static void PrintAnimal(Animal animal)
    {
      Console.WriteLine(animal.ToString());
    }
  }
}
