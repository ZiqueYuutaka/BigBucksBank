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
        //public event ChangeHandler pinChanged;

        /*private struct Admin
        {
            public string name;
            public string pin;

        }*/
        //private Admin admin, tempAdmin;
        //private bool isAdminOn = false;
        private bool isLockedOut = false;
        const int TOTAL_ATTEMPTS = 1;
        const int SIZE = 5;
        Account[] accounts;
        int acctIndex;
        int login_attempts = 0;       

        public LandATM()
        {
            InitializeComponent();
        }

        private void LandATM_Load(object sender, EventArgs e)
        {
            //admin = new Admin();

            this.usernameChanged = new LandATM.ChangeHandler(isAdminUsername);
           // this.pinChanged = new LandATM.ChangeHandler(isAdminPIN);

            loadAccounts();

            btnPower.Hide();

            //DEBUG
            printAccounts();
        }

        private void loadAccounts()
        {
            string[] userNames = {"StevenJones",
                                  "SusanMitchell",
                                  "JohnSmith",
                                  "CarolMichaels",
                                  "PaulGordon" };
            string[] pins = {"1111",
                              "2222",
                              "3333",
                              "4444",
                              "5555"};
            string[] accountNumbers = {"11111",
                                       "222222",
                                       "333333",
                                       "444444",
                                       "555555",
                                       "666666",
                                       "777777",
                                       "888888",
                                       "999999",
                                       "000000"};

            accounts = new Account[SIZE];
            Random randAcct = new Random(123);
            decimal temp;
            for (int i = 0, j = 0; i < SIZE; i++)
            {
                accounts[i] = new Account();
                accounts[i].UserName = userNames[i];
                accounts[i].Pin = pins[i];
                accounts[i].CheckingAccount = accountNumbers[j++];
                accounts[i].SavingsAccount = accountNumbers[j++];
                temp = Convert.ToDecimal(randAcct.Next(1000, 9999));
                accounts[i].CheckingAmount = temp;
                temp = Convert.ToDecimal(randAcct.Next(10000, 99999));
                accounts[i].SavingsAmount = temp;
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
            
            if (isLockedOut)
            {                
                if(isAdminUsername(tbUsername) && isAdminPIN(tbPIN)) //The machine is locked
                {
                    Console.WriteLine("Unlocking Machine");
                    unlockMachineWithMsg("ATM unlock successful");
                }
                else
                {
                    incorrectAdminLogin();
                }
            }
            else
            {
                acctIndex = accountExists();
                if (acctIndex != -1)
                {
                    Console.WriteLine("User found");
                    tbUsername.Focus();
                    if (isCorrectPin(acctIndex)) //correct USER pin
                    {

                        clearFields();
                        login_attempts = 0;
                        ATMForm acctInterface = new ATMForm();
                        acctInterface.ShowDialog();
                        txtArea.Text = accounts[acctIndex].receipt();

                    }
                    else //incorrect login pin
                    {
                        loginIncorrect();
                        Console.WriteLine("Incorrect PIN");
                    }

                }
                else if (isAdminUsername(tbUsername)) //Power down machine
                {
                    if (isAdminPIN(tbPIN))
                    {
                        txtArea.Text = "Power down sequence initiated";
                        showButtons(false);
                        btnPower.Show();
                    }
                    else
                    {
                        incorrectAdminLogin();
                    }
                }
                else//no user found
                {
                    loginIncorrect();
                    Console.WriteLine("User NOT found");
                }
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

        private void loginIncorrect()
        {
            login_attempts++;
            txtArea.Text = "Incorrect PIN and USERNAME combination entered.\n" +
                            (TOTAL_ATTEMPTS - login_attempts) +
                            " attempts left";
            clearFields();
            if (login_attempts == TOTAL_ATTEMPTS)
            {
                //Lock out and wait for admin
                txtArea.Text = "PLEASE SEE A BANK OFFICER-NO FURTHER LOGIN ATTEMPTS ALLOWED";
                clearFields();
                showButtons(false);
                //enableButtons(false);
                tbPIN.Enabled = false;
                isLockedOut = true;
            }
        }

        private void incorrectAdminLogin()
        {
            txtArea.Text = "Incorrect ADMIN PIN";
            tbPIN.Text = "";
            tbPIN.Focus();
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

        /*private void enableButtons(bool val)
        {
            btnClear.Enabled = val;
            btnLogin.Enabled = val;
        }*/

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (usernameChanged(tbUsername) && isLockedOut)
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

        public void unlockMachineWithMsg(string message)
        {
            //enableButtons(true);
            showButtons(true);
            login_attempts = 0;
            clearFields();
            txtArea.Text = message;
            isLockedOut = false;
        }

        private void clearFields()
        {
            tbUsername.Text = "";
            tbPIN.Text = "";
            tbUsername.Focus();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Power button clicked");
            System.Windows.Forms.DialogResult result;
            result = MessageBox.Show("Power down ATM?", "Power Down", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
            else //Admin decides to keep ATM running
            {
                btnPower.Hide();
                unlockMachineWithMsg("Power down sequence cancelled");                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            txtArea.Text = "";
        }
    }
}
