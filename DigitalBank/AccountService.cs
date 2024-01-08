namespace DigitalBank
{
    internal class AccountService (Account account)
    {
        public void init()
        {
            Console.WriteLine("Will there be an initial deposit? S / N");
            string initialDepo = Console.ReadLine().ToLower();
            InitialDepo(initialDepo);

            InitialMoney(initialDepo);

            Console.WriteLine(account);
            Console.WriteLine();

            Console.WriteLine("Enter the value for deposit");
            double deposit = double.Parse(Console.ReadLine());
            Deposit(deposit);
            Console.WriteLine();


            Console.WriteLine("Account data updated: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.WriteLine("Enter the value for withdraw");
            double withdraw = double.Parse(Console.ReadLine());
            Withdrawal(withdraw);
            Console.WriteLine();

            Console.WriteLine("Account data updated: ");
            Console.WriteLine(account);
            Console.WriteLine();
        }
        public string InitialDepo(string initialdepo)
        {
            if (initialdepo.Equals("s") || initialdepo.Equals("n"))
            {
                account.ResponseDepo = initialdepo;
            }
            else
            {
                while (!initialdepo.Equals("s") && !initialdepo.Equals("n"))
                {
                    Console.WriteLine("Will there be an initial deposit? S / N");
                    initialdepo = Console.ReadLine();
                }
                InitialMoney(initialdepo);
            }
            return initialdepo;
        }

        public double InitialMoney(string initialValue)
        {
            if (initialValue.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the value for deposit: ");
                account.Balance = double.Parse(Console.ReadLine());

                while (account.Balance <= 0)
                {
                    Console.WriteLine("Enter the positive or more than 0 value for deposit: ");
                    account.Balance = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                return 0;
            }
            return account.Balance;
        }

        public double Deposit(double deposit)
        {
            while (deposit <= 0)
            {
                Console.WriteLine("Enter the positive or more than 0 value for deposit: ");
                deposit = double.Parse(Console.ReadLine());
            }
            return account.Balance += deposit;
        }

        public double Withdrawal(double withdrawal)
        {
            account.Balance -= Account.FixedFee;
            while (withdrawal > account.Balance)
            {
                Console.WriteLine("The amount exceeds the balance in the account. Please provide a smaller value: ");
                withdrawal = double.Parse(Console.ReadLine());
            }
            account.Balance -= withdrawal;
            return account.Balance;
        }
    }
}
