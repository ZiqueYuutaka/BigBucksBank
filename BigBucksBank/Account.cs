using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class Account
    {
        private string userName;
        private string pin;
        private decimal checkingAmount;
        private decimal savingsAmount;
        private string checkingAccount;
        private string savingAccount;

        public Account() {
            userName = "";
            pin = "";
            checkingAmount = 0.00m;
            savingsAmount = 0.00m;
            checkingAccount = "000000";
            savingAccount = "000000";
        
        }

        public Account(String userName, String pin, string checkingNumber,
                        string savingNumber, decimal checking, decimal savings) {
            this.userName = userName;
            this.pin = pin;
            this.checkingAmount = checking;
            this.savingsAmount = 0.00m;
            checkingAccount = checkingNumber;
            savingAccount = savingNumber;
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if(value.Equals(""))
                {
                    throw new ArgumentNullException(
                        "Please enter a value for Username");
                }
                userName = value;
            }
        }//End UserName

        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentNullException(
                        "Please enter a value for PIN");
                }
                pin = value;
            }
        }//End Pin

        public decimal CheckingAmount
        {
            get
            {
                return checkingAmount;
            }
            set
            {
                try
                {
                    //decimal temp = Convert.ToDecimal(value);
                    checkingAmount = value;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(
                        "Value is not a numerical value");
                }
            }
        }// End Checking

        public decimal SavingsAmount
        {
            get
            {
                return savingsAmount;
            }
            set
            {
                try
                {
                    //decimal temp = Convert.ToDecimal(value);
                    savingsAmount = value;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(
                        "Value is not a numerical value");
                }
            }
        }//End Savings

        public string CheckingAccount
        {
            get
            {
                return checkingAccount;
            }
            set
            {
                checkingAccount = value;
            }
        }//End CheckingAccount

        public string SavingsAccount
        {
            get
            {
                return savingAccount;
            }
            set
            {
                savingAccount = value;
            }
        }

        /*public int LoginAttempts
        {
            get
            {
                return loginAttempts;
            }
        }*/

        public string receipt()
        {
            return
                "-------------------------------------------------\n" +
                "                   ACCOUNT                       \n" +
                "-------------------------------------------------\n" +
                "Username:     " + userName + "\n" +
                "CHECKINGACCT: " + checkingAccount + "\n" +
                "CHECKING:     " + checkingAmount.ToString("c") + "\n" +
                "SAVINGSACCT:  " + savingAccount + "\n" +
                "SAVINGS:      " + savingsAmount.ToString("c");
        }
    }
}
