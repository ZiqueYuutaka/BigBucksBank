using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public static class AccountsDAO
    {
        //private const string dir = @"C:\Users\Zique Yuutaka\Documents\Visual Studio 2015\Projects\BigBucksBank\BigBucksBank\BigBucksBank";
        private const string file = "AccountAmounts.txt";

        public static void SaveAmounts(Account[] accounts)
        {
            StreamWriter textOut =
            new StreamWriter(
            new FileStream(file, FileMode.Create, FileAccess.Write));

            //Write each amount to the file
            foreach(Account account in accounts)
            {
                textOut.WriteLine(account.CheckingAmount + "|" + account.SavingsAmount);
            }

            textOut.Close();
        }

        public static List<Account> GetAccountAmounts()
        {
            //Create file if it doesn't exist
            if (!File.Exists(file))
                File.Create(file);

            StreamReader textIn =
                new StreamReader(
                    new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read));

            //create empty list of Accounts to be read in later
            List<Account> accounts = new List<Account>();

            while(textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Account newAccount = new Account();
                newAccount.CheckingAmount = Convert.ToDecimal(columns[0]);
                newAccount.SavingsAmount = Convert.ToDecimal(columns[1]);
                accounts.Add(newAccount);
            }

            textIn.Close();

            return accounts;
        }
    }
}
