using System;
using System.Collections.Generic;
using System.Text;

namespace lab_10_1
{
    [Serializable]
     public class Person
        {
            private string name;
            private DateTime birthYear;

            //властивості
            public string Name
            {
                get { return name; }
            }
            public DateTime BirthYear
            {
                get { return birthYear; }
            }

            //констркутор за замовчуванням та з параметрами
            public Person()
            {

            }
            public Person(string name, DateTime birthYear)
            {
                this.name = name;
                this.birthYear = birthYear;
            }

            //методи
            public int Age()
            {
                int age = DateTime.Now.Year - birthYear.Year;
                return (age);
            }

            public void Input()
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter birth year: ");
                birthYear = System.Convert.ToDateTime(Console.ReadLine());
            }

            //Зміна імені
            public void ChangeName(string newName)
            {
                name = newName;
            }

            //Метод ToString() повертає рядок з інформацією про ім'я, рік народження та вік людини.
            public override string ToString()
            {
                return $"Name: {name}, Birth Year: {birthYear.ToString("yyyy")}, Age: {Age()}";
            }

            //Порівняння на ім'я
            public void OutPut()
            {
                Console.WriteLine("Information about this people: ");
                Console.WriteLine(ToString());
            }

            public static bool operator ==(Person person1, Person person2)
            {
                return (person1.name == person2.name);
            }

            public static bool operator !=(Person person1, Person person2)
            {
                return !(person1 == person2);
            }

        }
    }
