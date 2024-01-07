namespace DigitalBank
{
    internal class Bank
    {
        private string _name;
        public string InitialName { get; }
        public int AcNumber {  get; set; }
        public double Balance { get; set; }

        private string ResponseDepo;

        private const int FixedFee = 5;


        public Bank()
        {

        }

        public Bank (string initialdepo, int acnumber, double balance)
        {
            InitialName = initialdepo;
            AcNumber = acnumber;
            Balance = balance;
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
                while (!initialdepo.Equals("s") || !initialdepo.Equals("n"))
                {
                    Console.WriteLine("Will there be an initial deposit? S / N");
                    initialdepo = Console.ReadLine();

                    if (initialdepo.Equals("s") || initialdepo.Equals("n")) {
                        InitialMoney(initialdepo); break;
                    }
                }
            }
            return initialdepo;
        }

        public double InitialMoney(string initialValue)
        {
            if (initialValue.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the value for deposit: ");
                Balance = double.Parse(Console.ReadLine());
                
                if (Balance < 1)
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
            return Balance += deposit;
        }

        public double Withdrawal (double withdrawal)
        {
            return Balance = (Balance - withdrawal) - FixedFee;
        }

        public override string ToString()
        {
            return "Account: " + AcNumber + " Name: " + _name + " Balance: R$" + Balance;
        }


    }
}