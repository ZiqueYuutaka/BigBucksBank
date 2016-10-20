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
    public partial class ATMForm : Form
    {
        int choice = 0;

        public ATMForm()
        {
            InitializeComponent();
        }

        private void ATMForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ATM for customer");
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case GroupBoxValues.DEPOSIT:
                    Console.WriteLine("Deposit");
                    break;
                case GroupBoxValues.WITHDRAWAL:
                    Console.WriteLine("Withdrawal");
                    break;
                case GroupBoxValues.BALANCE:
                    Console.WriteLine("Balance");
                    break;
                case GroupBoxValues.TRANSFER:
                    Console.WriteLine("Transfer");
                    break;
                case GroupBoxValues.EXIT:
                    System.Windows.Forms.DialogResult close;
                    close = MessageBox.Show("Are you sure you want to EXIT?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.
                        Question);

                    if (close == System.Windows.Forms.DialogResult.Yes)
                    {
                        Close();
                    }
                    break;
                default:
                    MessageBox.Show("Please choose an option displayed", "Invalid choice");
                    break;
            }
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDeposit.Checked == true)
            {
                choice = GroupBoxValues.DEPOSIT;
            }
        }

        private void rbWithdrawal_CheckedChanged(object sender, EventArgs e)
        {
            if(rbWithdrawal.Checked == true)
            {
                choice = GroupBoxValues.WITHDRAWAL;
            }
        }

        private void rbBalance_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBalance.Checked == true)
            {
                choice = GroupBoxValues.BALANCE;
            }
        }

        private void rbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTransfer.Checked == true)
            {
                choice = GroupBoxValues.TRANSFER;
            }
        }

        private void rbExit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExit.Checked == true)
            {
                choice = GroupBoxValues.EXIT;
            }
        }
    }
}
