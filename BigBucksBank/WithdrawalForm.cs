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
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
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

        private void withdrawalMsg(string accountType, decimal amountWithdrawn, decimal newAcctAmount)
        {
            rtbMessage.Text =
                "-------------------------------------------------\n" +
                "                 TRANSACTION                     \n" +
                "-------------------------------------------------\n" +
                "Withdrawn:\t" + amountWithdrawn.ToString("c") + "\n" +
                accountType + " Balance:\t" + newAcctAmount.ToString("c");
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Withdraw button clicked");
            decimal withdrawal = 0m;
            if (rbChecking.Checked)
            {
                Console.WriteLine("Withdrawing from Checking");
                if (isValidWithdrawal()) //check if valid data
                {
                    Console.WriteLine("Correct data. Begin withdrawal");
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = withdrawalProcess(withdrawal, LandATM.getLoginAccount().CheckingAmount);
                    withdrawalMsg("Checking", withdrawal, result);
                    LandATM.getLoginAccount().CheckingAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else if(rbSavings.Checked){ //If savings checked
                Console.WriteLine("Withdrawaing from Savings");
                if (isValidWithdrawal()) //check if valid data
                {
                    Console.WriteLine("Correct data. Begin withdrawal");
                    //Start withdrawal process
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = withdrawalProcess(withdrawal, LandATM.getLoginAccount().SavingsAmount);
                    withdrawalMsg("Savings", withdrawal, result);
                    LandATM.getLoginAccount().SavingsAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else
            {
                errorMessage("Please choose which account to withdraw from");
            }
        }

        private decimal withdrawalProcess(decimal withdrawal, decimal fromAccount)
        {
                if (Validator.IsInRange(withdrawal, 0.00m, fromAccount))
                {
                    return Math.Round((fromAccount -= withdrawal), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    errorMessage("Incorrect amount to withdraw. Please try again.");
                    return fromAccount;
                }
        }

        private void errorMessage(string text)
        {
            //Error message
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show(text, Validator.Title);
        }

        private bool isValidWithdrawal()
        {
            string temp = tbAmount.Text;
            return Validator.IsPresent(temp) &&
                   Validator.IsDecimal(temp);
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
    }
}
