using System;

namespace classwork10_1
{
    class CreditCard
    {
        private string _number;
        public string HolderName { get; set; }      
        public string ValidBefore { get; set; }
        public ushort Cvc { get; set; }

        public string Number
        {
       
            get
            {
                //if (_number == null)
                //    return null;

                //string result = string.Empty;
                //for (int i=0; i < _number.Length; i++)
                //{
                //    if (i>0 && i % 4 == 0)
                //        result += " ";
                //    result += _number[i];
                //}

                return _number;
            }
            set
            {
                foreach (char ch in value)
                {
                    if (!char.IsDigit(ch))
                    {
                        throw new Exception(message: "Tak Nelzya");
                    }
                }
                _number = value;
            }
        }
        public bool IsValid()
        {
           // return ()&&()&&() lusche tak obedinit

            //return (Number == null || Number.Length < 12 || Number.Length > 26) to zhe samoe!!!!
             
            if (Number == null || Number.Length < 12 || Number.Length > 26)
            {
                return false;
            }
            
            //if (!Number.IsValid())
            //{
            //    return false;
            //}

            if (ValidBefore == null)
            {
                return false;
            }

            if (Cvc>999)
            {
                return false;
            }
            return false;
        }
        private bool CvcIsValid()
        {
            return Cvc < 1000;
        }

    }
    class Program
    {  
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.HolderName = "Sofya Borovikova";
            creditCard.Number = "4276380128086754";
            creditCard.ValidBefore = "11/22";
            creditCard.Cvc = 147;

            Console.WriteLine(creditCard.Number);

            creditCard.Number += "9";

            Console.WriteLine(creditCard.Number);
            Console.WriteLine(creditCard.IsValid()
                ? "Credit card is valid"
                : "Credit card isn`t valid"
                );

            CreditCard[] creditCards = new CreditCard[2];
            creditCards[0] = creditCard;

        }
    }
}
