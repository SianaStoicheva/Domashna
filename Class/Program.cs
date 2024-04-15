using System;

namespace Dimashna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.name = "Pesho";
            person1.age = 20;
            person1.Persons();

            person2.name = "Gosho";
            person2.age = 18;
            person2.Persons();

            person3.name = "Stamat";
            person3.age = 43;
            person3.Persons();
        }
    }
}
