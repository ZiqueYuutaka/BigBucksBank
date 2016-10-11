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

        public LandATM()
        {
            InitializeComponent();
        }

        private void LandATM_Load(object sender, EventArgs e)
        {

        }

        private string createAccountNumber()
        {
            string account;
            Random randAcct = new Random(123);
            return account = randAcct.Next(1000000, 9999999).ToString();
        }
    }
}
