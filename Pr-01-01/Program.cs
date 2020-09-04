using System;


namespace Pr_01_01
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;
      public Genders gender;

      public Person(string _firstName, string _lastName, int _age, Genders _gender)
      {
        firstName = _firstName; lastName =
        _lastName; age = _age; gender = _gender;
      }
      public enum Genders : int { Male, Female }; 
      
      public override string ToString()
      {
        return firstName + " " + lastName + " (" + gender + "), age " + age;
      }
    }

    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
      Console.WriteLine(p.ToString());
    }
  }
}
