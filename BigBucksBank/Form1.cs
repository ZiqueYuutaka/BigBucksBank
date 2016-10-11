using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class LandATM : Form
    {
        const int LOGIN_ATTEMPTS = 3;
        const int SIZE = 5;
        Account[] accounts;
        private string[] userNames = {"StevenJones",
                                  "SusanMitchell",
                                  "JohnSmith",
                                  "CarolMichaels",
                                  "PaulGordon" };
        private string[] pins = {"1111",
                                 "2222",
                                 "3333",
                                 "4444",
                                 "5555"};
        private string[] accountNumbers = {"111111",
                                           "222222",
                                           "333333",
                                           "444444",
                                           "555555"};

        public LandATM()
        {
            InitializeComponent();
        }

        private void LandATM_Load(object sender, EventArgs e)
        {
            loadAccounts();

            //DEBUG
            printAccounts();
        }

        private void loadAccounts()
        {
            accounts = new Account[SIZE];
            Random randAcct = new Random(123);
            decimal temp;
            for (int i = 0; i < SIZE; i++)
            {
                accounts[i] = new Account();
                accounts[i].UserName = userNames[i];
                accounts[i].Pin = pins[i];
                accounts[i].AcctNumber = accountNumbers[i];
                temp = Convert.ToDecimal(randAcct.Next(1000, 9999));
                accounts[i].Checking = temp;
                temp = Convert.ToDecimal(randAcct.Next(10000, 99999));
                accounts[i].Savings = temp;
            }
        }

        private void printAccounts()
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(accounts[i].receipt());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int acctIndex = accountExists();
            if (acctIndex != -1)
            {
                Console.WriteLine("User found");
                tbUsername.Focus();
                if (correctPin(acctIndex))
                {
                    Console.WriteLine("Login successful");
                    tbPIN.Text = "";

                }
                else
                {
                    Console.WriteLine("PIN NOT Found");
                    tbPIN.Text = "";
                    accounts[acctIndex].loginAttempts++;
                    if(accounts[acctIndex].loginAttempts == LOGIN_ATTEMPTS)
                    {
                        //Lock out and wait for admin
                        Console.WriteLine("Locked out");
                    }
                }

            }
            else
            {
                Console.WriteLine("No user found");
                tbUsername.Text = "";
                tbUsername.Focus();
            }
        }

        private int accountExists()
        {
            for(int i = 0; i < SIZE; i++)
            {
                if (accounts[i].UserName.Equals(tbUsername.Text))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool correctPin(int i)
        {
            if (accounts[i].Pin.Equals(tbPIN.Text)){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
