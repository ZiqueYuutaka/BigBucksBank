using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    class BinaryAccountDAO
    {
        private const string dir = @"C:\BinaryFiles\";
        private const string file = dir + "BinaryAccountsAmounts.dat";

        public static void SaveAmounts(List<Account> accounts)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            BinaryWriter binaryOut =
            new BinaryWriter(
            new FileStream(file, FileMode.Create, FileAccess.Write));

            //Write each amount to the file
            foreach (Account account in accounts)
            {
                binaryOut.Write(account.CheckingAmount);
                binaryOut.Write(account.SavingsAmount);
            }

            binaryOut.Close();
        }

        public static List<Account> GetAccountAmounts()
        {
            //Create file if it doesn't exist
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            BinaryReader binaryIn =
                new BinaryReader(
                    new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read));

            //create empty list of Accounts to be read in later
            List<Account> accounts = new List<Account>();

            while (binaryIn.PeekChar() != -1)
            {
                Account newAccount = new Account();
                newAccount.CheckingAmount = binaryIn.ReadDecimal();
                newAccount.SavingsAmount = binaryIn.ReadDecimal();
                accounts.Add(newAccount);
            }

            binaryIn.Close();

            return accounts;
        }
    }
}
