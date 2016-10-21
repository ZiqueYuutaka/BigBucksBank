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
    public partial class TransferForm : Form
    {
        private decimal checkingAmount;
        private decimal savingsAmount;
        public TransferForm()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (rbFromChkg.Checked)
            {
                if (rbToSvngs.Checked)
                {
                    //Transfer
                    Console.WriteLine("From Checking to Savings");
                    transferProcess(checkingAmount, savingsAmount, "Checking", "Savings");
                }
                else
                {
                    MessageBox.Show("Please choose a different internal account",Validator.Title);
                }
            }else if (rbFromSvngs.Checked)
            {
                if (rbToChkg.Checked)
                {
                    //Transfer
                    Console.WriteLine("From Savings to Checking");
                    transferProcess(savingsAmount, checkingAmount, "Savings", "Checking");
                }
                else
                {
                    MessageBox.Show("Please choose a different internal account", Validator.Title);
                }
            }
            else
            {
                MessageBox.Show("Please choose an account to transfer from", Validator.Title);
            }
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            checkingAmount = LandATM.getLoginAccount().CheckingAmount;
            savingsAmount = LandATM.getLoginAccount().SavingsAmount;

        }

        private void transCompleteMsg(string from, string to, decimal amountTransferred)
        {
            rtbMessage.Text =
                "-------------------------------------------------\n" +
                "                 TRANSFER COMPLETE               \n" +
                "-------------------------------------------------\n" +
                "FROM:\t" + from + "\n" +
                "TO:\t" + to + "\n" +
                "AMOUNT TRANSFERRED:\t" + amountTransferred.ToString("c") + "\n" +
                LandATM.getLoginAccount().receipt();
        }

        private bool isValidTransfer(decimal max)
        {
            string temp = tbAmount.Text;
            return Validator.IsPresent(temp) &&
                   Validator.IsDecimal(temp) &&
                   Validator.IsInRange(Convert.ToDecimal(temp), 0.00m, max);
        }

        private void transferProcess(decimal fromAmount, decimal toAmount, string from, string to)
        {
            if (isValidTransfer(fromAmount))
            {
                decimal transferAmount = Convert.ToDecimal(tbAmount.Text);
                transferAmounts(transferAmount, fromAmount, toAmount);
                transCompleteMsg(from, to, transferAmount);
            }
            else
            {
                MessageBox.Show("Invalid amount to transfer", Validator.Title);
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

        private void transferAmounts(decimal amount, decimal from, decimal to)
        {
            from -= amount;
            to += amount;
            if (rbFromChkg.Checked)
            {
                LandATM.getLoginAccount().CheckingAmount = from;
                LandATM.getLoginAccount().SavingsAmount = to;
            }
            else
            {
                LandATM.getLoginAccount().CheckingAmount = to;
                LandATM.getLoginAccount().SavingsAmount = from;
            }
        }
    }
}
