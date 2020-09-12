using System;
using System.Collections.Generic;
using System.Text;

namespace CreateStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =  { "Михаил", "Иван", "Степан", "Анастасия", "София", "Мария", "Василий", "Пётр", "Елизавета", "Валерия" };
            string[] fam =  { "Смирнов", "Иванов", "Кузнецов", "Соколова", "Попова", "Лебедева", "Козлов", "Новиков", "Морозова", "Волкова" };
            string[] city =  { "Казань", "Москва", "Питер", "Нижний Новгород", "Великий Новгород", "Калининград", "Самара", "Владивосток 2000", "Ульяновск", "Можайск" };
            string[] numb =  { "499 118-69-26", "499 132-00-61", "495 249-53-63", "499 261-33-33", "495 261-33-33", "499 261-33-33", "495 322-02-42", "499 323-21-61", "499 330-47-70", "495 333-35-36" };
            int[] ages = new int[] { 19, 20, 21, 22, 23, 24, 25, 18, 16, 10 };
            int[] gend = new int[] { 0, 0, 2, 1, 1, 3, 2, 0, 2, 1, 3 };

            for (int i = 0; i <= names.Length - 1; i++)
            {
                Manager p = new Manager(i + 1, names[i], fam[i], ages[i], (Manager.Genders)gend[i], numb[i], city[i]);
                Console.WriteLine(p.ToString());
            }
        }

        class Person
        {
            public string firstName;
            public string lastName;
            public int age, number;
            public Genders gender;

            public Person(int _number, string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
                number = _number;
            }

            public override string ToString()
            {
                return "№"+ number+ " " + firstName + " " + lastName + " (" + gender + "), возраст: " + age;
            }

            public enum Genders : int { Мужской, Женский, Транс_М_Ж, Транс_Ж_М };
            
        }
        class Manager : Person
        {
            string phoneNumber, officeLocation;
            
            public Manager(int _number, string _firstName, string _lastName, int _age, Genders _gender, string _phoneNumber, string _officeLocation) : base(_number, _firstName, _lastName, _age, _gender)
            {
                phoneNumber = _phoneNumber; 
                officeLocation = _officeLocation;
                
            }
            public override string ToString()
            {
                return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
            }
        }
    }
}
