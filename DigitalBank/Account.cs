namespace DigitalBank
{
    internal class Account
    {
        public int AcNumber {  get; private set; }
        public double Balance { get; private set; }

        private string ResponseDepo;
        private string _name;
        private const int FixedFee = 5;


        public Account()
        {

        }

        public Account (int acnumber, string name)
        {
            AcNumber = acnumber;
            _name = name;
        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }

        }

        public string InitialDepo(string initialdepo)
        {
            if (initialdepo.Equals("s") || initialdepo.Equals("n"))
            {
                ResponseDepo = initialdepo;
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
                Balance = double.Parse(Console.ReadLine());
                
                while(Balance <= 0)
                {
                    Console.WriteLine("Enter the positive or more than 0 value for deposit: ");
                    Balance = double.Parse(Console.ReadLine());
                }
            } else
            {
                return 0;
            }
            return Balance;
        }

        public double Deposit (double deposit)
        {
            while (deposit <= 0)
            {
                Console.WriteLine("Enter the positive or more than 0 value for deposit: ");
                deposit = double.Parse(Console.ReadLine());
            }
            return Balance += deposit;
        }

        public double Withdrawal (double withdrawal)
        {
            Balance -= FixedFee;
            while (withdrawal > Balance)
            {
                Console.WriteLine("The amount exceeds the balance in the account. Please provide a smaller value: ");
                withdrawal = double.Parse(Console.ReadLine());
            }
            Balance -= withdrawal;
            return Balance;
        }

        public override string ToString()
        {
            return "Account: " + AcNumber + " Name: " + _name + " Balance: R$" + Balance.ToString("F2");
        }
    }
}