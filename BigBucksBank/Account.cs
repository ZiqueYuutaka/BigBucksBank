using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    class Account
    {
        private string userName;
        private string pin;
        private decimal checking;
        private decimal savings;
        private string account;
        private int loginAttempts;

        public Account() {
            userName = "";
            pin = "";
            checking = 0.00m;
            savings = 0.00m;
            account = "0000000000";
            loginAttempts = 0;
        
        }

        public Account(String userName, String pin, string acctNumber) {
            this.userName = userName;
            this.pin = pin;
            checking = 0.00m;
            savings = 0.00m;
            account = acctNumber;
            loginAttempts = 0;
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

        public decimal Checking
        {
            get
            {
                return checking;
            }
            set
            {
                try
                {
                    decimal temp = Convert.ToDecimal(value);
                    checking = value;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(
                        "Value is not a numerical value");
                }
            }
        }// End Checking

        public decimal Savings
        {
            get
            {
                return savings;
            }
            set
            {
                try
                {
                    decimal temp = Convert.ToDecimal(value);
                    checking = value;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(
                        "Value is not a numerical value");
                }
            }
        }//End Savings

        public string AcctNumber
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }//End AcctNumber

        public int LoginAttempts
        {
            get
            {
                return loginAttempts;
            }
        }

        public string receipt()
        {
            return
                "-------------------------------------------------\n" +
                "                   ACCOUNT                       \n" +
                "-------------------------------------------------\n" +
                "Username:     " + userName + "\n" +
                "Account:      " + account + "\n" +
                "CHECKING:     " + checking + "\n" +
                "SAVINGS:      " + savings;
        }
    }
}
