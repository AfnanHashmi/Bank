using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class bankaccount
    {
        public string Name;
        public string PhoneNumber;
        public string Address;
        public DateTime DOB;
        public double Balance;
        public string Gender;
        public string AccountNumber { 
            get
            {
                string date_part = DateTime.Today.ToString("ddMMyyyy");
                string phnumber_part = PhoneNumber.Substring(0, 4);
                string accountNum = date_part + phnumber_part;
                return accountNum;
            }
        }

        public bankaccount()
        {

        }

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
