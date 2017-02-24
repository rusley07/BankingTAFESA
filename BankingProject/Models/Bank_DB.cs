using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingProject.Models
{
    public class Bank_DB
    {
        private static List<Account> c1 = new List<Account>();
        private static List<Account> c2 = new List<Account>();

        private static Dictionary<string, List<Account>> listing = new Dictionary<string, List<Account>>();
        
        private void initAccounts() {
            c1.Add(new Account("A100", "Access", 1000.00M));
            c1.Add(new Account("A200", "Credit Card", -5000.00M));
            c1.Add(new Account("A300", "Savings", 7000.00M));
            c2.Add(new Account("A101", "Access", 9000.00M));
            c2.Add(new Account("A201", "Credit Card", -1000.00M));
            c2.Add(new Account("A301", "Savings", 7000.00M));
        }

        public Dictionary<string, List<Account>> initDB()
        {
            this.initAccounts();
            listing.Add("C100", c1);
            listing.Add("C200", c2);
            return listing;

        }

        public List<Account> getAccounts(string cust_id)
        {
            return listing[cust_id];
        }


    }
}