using System.Security.Principal;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the account number: ");
            int acNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insert your name: ");
            string name = Console.ReadLine();

            new AccountService(new Account(acNumber, name)).init();
        }
    }
}
    