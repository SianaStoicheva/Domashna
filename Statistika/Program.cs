namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi broi: ");
            int n = int.Parse(Console.ReadLine());

            List<string> peopleOver30 = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Vuvedi informaciq {i + 1}:");
                Console.Write("Ime: ");
                string name = Console.ReadLine();
                Console.Write("Vuzrast: ");
                int age = int.Parse(Console.ReadLine());

                if (age > 30)
                {
                    peopleOver30.Add($"{name}, {age} ");
                }
            }

            peopleOver30.Sort();

            Console.WriteLine("Hora nad 30 godini:");
            foreach (var person in peopleOver30)
            {
                Console.WriteLine(person);
            }
        }
    }
}
