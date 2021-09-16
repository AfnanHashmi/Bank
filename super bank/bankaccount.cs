using System;
using System.Collections.Generic;
using System.Text;

namespace super_bank
{
    public class bankaccount
    {
        public string Name;
        public string PhoneNumber;
        public string Address;
        public string DOB;
        public double Balance;
        private static int accountnumber = 0123456789;

        public bankaccount() { }

        public void MakeWithdrawal(double amount)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not Enough Funds");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
        public void MakeDiposit(double amount)
        {
            Balance = Balance + amount;
        }
    }
}
