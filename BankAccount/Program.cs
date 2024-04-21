namespace DefiniraneNaKlas
{
    internal class Program
    {
       public static void Main()
        {
            BankAccount acc = new  BankAccount();
             acc.id = 1;
            acc.Balance = 15;
            
            Console.WriteLine($"Account {acc.id}, balance {acc.Balance}");
       }
    }
}
