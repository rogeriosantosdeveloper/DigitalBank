namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {

            string initialDepo; 
            int acNumber;
            double balance;

            Bank bank = new Bank();

            Console.WriteLine("Insert the account number: ");
            acNumber = int.Parse(Console.ReadLine());
            bank.AcNumber = acNumber;

            Console.WriteLine("Insert your name: ");
            bank.Name = Console.ReadLine();

            Console.WriteLine("Will there be an initial deposit? S / N");
            initialDepo = Console.ReadLine();
            bank.InitialDepo(initialDepo);

            if(initialDepo == "s")
            {
                Console.WriteLine("Enter the initial balance: ");
                bank.Balance = double.Parse(Console.ReadLine());
                balance = bank.Balance;

            } else
            {
                balance = 0;    
            }

            Console.WriteLine(bank);




        }
    }
}
    