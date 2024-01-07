namespace DigitalBank
{
    internal class Bank
    {
        private string _name;
        public string InitialName { get; }
        public int AcNumber {  get; set; }
        public double Balance { get; set; }

        private const int FixTax = 5;


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
                if (_name != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }   
        
        public string InitialDepo(string initialdepo)
        {
            if (initialdepo.Equals("s") || initialdepo.Equals("n"))
            {
                return initialdepo;
            } else
            {
                while (!initialdepo.Equals("s", StringComparison.OrdinalIgnoreCase) || !initialdepo.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Will there be an initial deposit? S / N");
                    initialdepo = Console.ReadLine();

                    return initialdepo;
                }
            }
            

            return initialdepo;
        }


        public override string ToString()
        {
            return "Account: " + AcNumber + " Name: " + Name + " Balance: R$" + Balance;
        }


    }
}
