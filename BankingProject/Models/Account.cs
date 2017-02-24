using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingProject.Models
{
    public class Account
    {
        public string Acct_ID { get; set; }
        public string Acct_Type { get; set; }
        public decimal Acct_Balance { get; set; }

        public Account(string _acctID, string _acctType, decimal _acctBalance)
        {
            Acct_ID = _acctID;
            Acct_Type = _acctType;
            Acct_Balance = _acctBalance;
        }

        public bool withdraw(decimal _amount)
        {
            if (Acct_Balance > _amount)
            {
                Acct_Balance -= _amount;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool deposit(decimal _amount)
        {
            Acct_Balance += _amount;
            return true;
        }
    }
}