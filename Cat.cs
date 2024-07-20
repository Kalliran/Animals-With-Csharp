/*
  * Author: Michael Corleone
  * Date: 07/20/2024
  * Assignment: CIS214 Performance Assessment - Inheritance & Overriding
  * Description: Derived class representing a Cat object
*/
namespace InheritanceAndOverriding
{
  public class Cat : Animal
  {
    public string Breed { get; set; }

    public Cat(string name, int age, string breed) : base(name, age)
    {
      Breed = breed;
    }

    public override string ToString()
    {
      return $"Cat: {Name}, Age: {Age}, Breed: {Breed}";
    }
  }
}
