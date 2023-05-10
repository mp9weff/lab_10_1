using System.Xml.Serialization;
using System.IO;
using System;

namespace lab_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // створити екземпляр класу Person
            Person person = new Person("John", new DateTime(1990, 1, 1));

            // створити серіалізатор
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            // створити потік файлу для запису серіалізованого об'єкта
            using (FileStream fileStream = new FileStream("person.xml", FileMode.Create))
            {
                // serialize the object to the file stream
                serializer.Serialize(fileStream, person);
            }

            // серіалізуємо об'єкт у файловий потік
            using (FileStream fileStream = new FileStream("person.xml", FileMode.Open))
            {
                // десеріалізація об'єкта з файлового потоку
                Person deserializedPerson = (Person)serializer.Deserialize(fileStream);

                // надрукувати десеріалізований об'єкт
                Console.WriteLine(deserializedPerson);
            }
        }
    }
}
