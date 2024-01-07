namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Insert the account number: ");
            int acNumber = int.Parse(Console.ReadLine());
            bank.AcNumber = acNumber;

            Console.WriteLine("Insert your name: ");
            bank.Name = Console.ReadLine();

            Console.WriteLine("Will there be an initial deposit? S / N");
            string initialDepo = Console.ReadLine().ToLower();
            bank.InitialDepo(initialDepo);

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
    