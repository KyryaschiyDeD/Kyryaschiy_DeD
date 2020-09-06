using System;


namespace Pr_01_01
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age, por_number;
      public Genders gender;

      public Person(int _por_number, string _firstName, string _lastName, int _age, Genders _gender)
      {
        por_number = _por_number;
        firstName = _firstName; 
        lastName =_lastName; 
        age = _age; 
        gender = _gender;
      }
      public enum Genders : int { Мужской, Женский, Транс_М_Ж, Транс_Ж_М }; 
      
      public override string ToString()
      {
        return por_number + ". " + firstName + " " + lastName + " (" + gender + "), возраст: " + age;
      }
    }

    static void Main(string[] args)
    {
      string[] names = new string[] { "Михаил","Иван","Степан","Анастасия","София","Мария", "Василий","Пётр","Елизавета","Валерия" };
      string[] fam = new string[] { "Смирнов", "Иванов", "Кузнецов", "Соколова", "Попова", "Лебедева", "Козлов", "Новиков", "Морозова", "Волкова" };
      int[] ages = new int[] { 19, 20, 21, 22, 23, 24, 25, 18, 16, 10 };
      int[] gend = new int[] {0,0,2,1,1,3,2,0,2,1,3};
    for (int i=0;i<=names.Length-1; i++) { 
      Person p = new Person(i+1, names[i], fam[i], ages[i], (Person.Genders)gend[i]);
      Console.WriteLine(p.ToString());
            }
        }
  }
}
