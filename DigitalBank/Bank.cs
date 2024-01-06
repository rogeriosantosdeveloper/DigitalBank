namespace DigitalBank
{
    internal class Bank
    {
        private string _name;
        private string _initialmoney;
        public int AcNumber {  get; private set; }
        public double Balance { get; private set; }

        private const int FixTax = 5;


        public Bank()
        {

        }

        public Bank (string name, int acnumber, string initialMoney, double balance)
        {
            _name = name;
            _initialmoney = initialMoney;
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
        
        public string InitialMoney
        {
            get { return _initialmoney; }
            set
            {
                while (_initialmoney.ToLower() != "s" || _initialmoney.ToLower() != "n") {
                    Console.WriteLine("Informe se deseja realizar depósito inicial!");
                }
            }
        }
    
        private double AccountOperation (double balance)
        {
            return balance;
        } 
    

    }
}
