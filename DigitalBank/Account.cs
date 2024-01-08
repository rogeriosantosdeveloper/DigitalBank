namespace DigitalBank
{
    internal class Account (int acnumber, string name)
    {
        private int AcNumber => acnumber;
        public double Balance;
        public string ResponseDepo;
        private string? Name => ValidateNameLenght(name);
        public static int FixedFee = 5;

        private string? ValidateNameLenght(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            if(name.Length > 1) 
            {
                return name;
            }
            return name;
        }

        public override string ToString()
        {
            return "Account: " + AcNumber + " Name: " + Name + " Balance: R$" + Balance.ToString("F2");
        }
    }
}