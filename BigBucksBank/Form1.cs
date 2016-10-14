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
        public delegate bool ChangeHandler(TextBox tb);
        public event ChangeHandler usernameChanged;
        public event ChangeHandler pinChanged;

        /*private struct Admin
        {
            public string name;
            public string pin;

        }*/
        //private Admin admin, tempAdmin;
        //private bool isAdminOn = false;
        const int LOGIN_ATTEMPTS = 3;
        const int SIZE = 5;
        Account[] accounts;
        int acctIndex;
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
            //admin = new Admin();

            this.usernameChanged = new LandATM.ChangeHandler(isAdminUsername);
            this.pinChanged = new LandATM.ChangeHandler(isAdminPIN);

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
            //Create admin account
            /*admin.name = "ADMIN";
            admin.pin = "12345";

            tempAdmin.name = "";
            tempAdmin.pin = "";*/
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
            acctIndex = accountExists();
            if (acctIndex != -1)
            {
                Console.WriteLine("User found");
                tbUsername.Focus();
                if (isCorrectPin(acctIndex))
                {
                    Console.WriteLine("Login successful");
                    tbPIN.Text = "";

                }
                else
                {
                    accounts[acctIndex].loginAttempts++;
                    txtArea.Text = "INCORRECT PIN entered.\n" +
                                    (LOGIN_ATTEMPTS - accounts[acctIndex].loginAttempts) +
                                    " attempts left for user: \n" + accounts[acctIndex].UserName;
                    clearFields();
                    if (accounts[acctIndex].loginAttempts == LOGIN_ATTEMPTS)
                    {
                        //Lock out and wait for admin
                        txtArea.Text = "LOCKED OUT. Please get assistance from administrator";
                        clearFields();
                        showButtons(false);
                        enableButtons(false);
                        tbPIN.Enabled = false;
                    }
                }

            }
            else
            {
                Console.WriteLine("No user found");
                clearFields();
            }
        }

        private int accountExists()
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (accounts[i].UserName.Equals(tbUsername.Text))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool isCorrectPin(int i)
        {
            if (accounts[i].Pin.Equals(tbPIN.Text)) {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void showButtons(bool val)
        {
            if (val)
            {
                btnClear.Show();
                btnLogin.Show();
            } else
            {
                btnClear.Hide();
                btnLogin.Hide();
            }
        }

        private void enableButtons(bool val)
        {
            btnClear.Enabled = val;
            btnLogin.Enabled = val;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (usernameChanged(tbUsername))
            {
                showButtons(true);
                tbPIN.Enabled = true;

            }
        }

        private bool isAdminUsername(TextBox textBox)
        {
            if (textBox.Text.Equals("ADMIN"))
            {
                return true;
            }
            return false;
        }

        private bool isAdminPIN(TextBox textBox)
        {
            if (textBox.Text.Equals("12345"))
            {
                return true;
            }
            return false;
        }

        private void tbPIN_TextChanged(object sender, EventArgs e)
        {
            if (pinChanged(tbPIN)) {
                enableButtons(true);
                accounts[acctIndex].loginAttempts = 0;
                clearFields();
                txtArea.Text = "ATM unlock successful";
            }
        }

        private void clearFields()
        {
            tbUsername.Text = "";
            tbPIN.Text = "";
            tbUsername.Focus();
        }
    }
}
