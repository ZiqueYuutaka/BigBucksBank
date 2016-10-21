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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            lblBalance.Text = LandATM.getLoginAccount().receipt();
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

        /*        private void button1_Click(object sender, EventArgs e)
                {

                }*/
    }
}
