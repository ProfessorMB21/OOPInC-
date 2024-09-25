using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInC_.Week1
{
    internal class Task3
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Bupe", 20);
            Console.WriteLine($"Hello, Name: {person.Name}, Age: {person.Age}");
        }
    }

    internal struct Person
    {
        public string Name { get; }
        public int Age { get; }
        public Person(string name, int age) { Name = name; Age = age; }
    }
}
