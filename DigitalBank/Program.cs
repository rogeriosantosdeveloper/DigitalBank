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

            Console.WriteLine("Will there be an initial deposit? S / N");
            string initialDepo = Console.ReadLine().ToLower();

            Bank bank = new Bank();

            bank.InitialMoney(initialDepo);

            Console.WriteLine(bank);
            Console.WriteLine();

            Console.WriteLine("Enter the value for deposit");
            double deposit = double.Parse(Console.ReadLine());
            bank.Deposit(deposit);
            Console.WriteLine();


            Console.WriteLine("Account data updated: ");
            Console.WriteLine(bank);
            Console.WriteLine();

            Console.WriteLine("Enter the value for withdraw");
            double withdraw = double.Parse(Console.ReadLine());
            bank.Withdrawal(withdraw);
            Console.WriteLine();

            Console.WriteLine("Account data updated: ");
            Console.WriteLine(bank);
            Console.WriteLine();
        }
    }
}
    