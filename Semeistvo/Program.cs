using System;

namespace Semeistvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi nomer na horata:");
            int N = int.Parse(Console.ReadLine());
            List<Person> family = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Vuvedi informaciq {i + 1}:");
                Console.Write("Ime: ");
                string name = Console.ReadLine();
                Console.Write("Vuzrast: ");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person() { Name = name, Age = age };
                family.Add(person);
            }

            family.Sort();

            Console.WriteLine("Hora v lista:");
            foreach (Person person in family)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
