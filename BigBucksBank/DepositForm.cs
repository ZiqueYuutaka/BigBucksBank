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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
            checkedMessage("CHECKING", LandATM.getLoginAccount().CheckingAmount.ToString("c"));
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
            checkedMessage("SAVINGS", LandATM.getLoginAccount().SavingsAmount.ToString("c"));
        }

        private void checkedMessage(string accountType, string amount)
        {
            rtbMessage.Text =
                "-------------------------------------------------\n" +
                "                 " + accountType + " ACCOUNT                 \n" +
                "-------------------------------------------------\n" +
                "Amount: " + amount;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Withdraw button clicked");
            decimal withdrawal = 0m;
            if (rbChecking.Checked)
            {
                Console.WriteLine("Depositing from Checking");
                if (isValidDeposit()) //check if valid data
                {
                    Console.WriteLine("Correct data. Begin withdrawal");
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = depositProcess(withdrawal, LandATM.getLoginAccount().CheckingAmount);
                    depositMsg("Checking", withdrawal, result);
                    LandATM.getLoginAccount().CheckingAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else if (rbSavings.Checked)
            { //If savings checked
                Console.WriteLine("Depositing from Savings");
                if (isValidDeposit()) //check if valid data
                {
                    Console.WriteLine("Correct data. Begin withdrawal");
                    //Start withdrawal process
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = depositProcess(withdrawal, LandATM.getLoginAccount().SavingsAmount);
                    depositMsg("Savings", withdrawal, result);
                    LandATM.getLoginAccount().SavingsAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else
            {
                errorMessage("Please choose which account to deposit to");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to EXIT?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void depositMsg(string accountType, decimal amtDeposited, decimal newAcctAmount)
        {
            rtbMessage.Text =
                "-------------------------------------------------\n" +
                "                 TRANSACTION                     \n" +
                "-------------------------------------------------\n" +
                "Deposited:\t" + amtDeposited.ToString("c") + "\n" +
                accountType + " Balance:\t" + newAcctAmount.ToString("c");
        }

        private decimal depositProcess(decimal deposit, decimal fromAccount)
        {
                return Math.Round((fromAccount += deposit), 2, MidpointRounding.AwayFromZero);
        }

        private void errorMessage(string text)
        {
            //Error message
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show(text, Validator.Title);
        }

        private bool isValidDeposit()
        {
            string temp = tbAmount.Text;
            return Validator.IsPresent(temp) &&
                   Validator.IsDecimal(temp) && 
                   Validator.IsAboveMin(Convert.ToDecimal(temp), 0.00m);
        }
    }
}
