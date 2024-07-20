/*
  * Author: Michael Corleone
  * Date: 07/20/2024
  * Assignment: CIS214 Performance Assessment - Inheritance & Overriding
  * Description: Base class for Animal objects
*/

namespace InheritanceAndOverriding
{
  public class Animal
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public override string ToString()
    {
      return $"Animal: {Name}, Age: {Age}";
    }
  }
}
