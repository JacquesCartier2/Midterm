using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Choose_Account : Form
    {
        //both buttons open the same form, and this variable is used to determine whether it is using the checking or savings account. 
        public static BankAccount account;
        public Choose_Account()
        {
            InitializeComponent();
        }

        private void btn_CheckingAccount_Click(object _sender, EventArgs _e)
        {
            account = Login.customer.checkingAccount;
            this.Hide();
            Account accountForm = new Account();
            accountForm.Show();
        }

        private void btn_SavingsAccount_Click(object _sender, EventArgs _e)
        {
            account = Login.customer.savingsAccount;
            this.Hide();
            Account accountForm = new Account();
            accountForm.Show();
        }
    }
}
