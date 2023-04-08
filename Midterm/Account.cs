using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Account : Form
    {
        private BankAccount account = Choose_Account.account;

        public Account()
        {
            InitializeComponent();
        }

        //when the form is shown, update the balance label.
        private void Account_Shown(object _sender, EventArgs _e)
        {
            UpdateAccountLabel();
        }

        private void btn_Deposit_Click(object _sender, EventArgs _e)
        {
            float input;

            //ensure that the input can be parsed. 
            try
            {
                input = float.Parse(txt_AccountInput.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
                return;
            }

            //ensure that input is greater than zero.
            if (input <= 0)
            {
                MessageBox.Show("Enter a number greater than zero.");
                return;
            }

            account.changeBalance(input);
            UpdateAccountLabel();
        }
        private void btn_Withdraw_Click(object _sender, EventArgs _e)
        {
            float input;

            //ensure that the input can be parsed. 
            try
            {
                input = float.Parse(txt_AccountInput.Text) * -1;
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
                return;
            }

            //ensure that input is less than zero(withdraw uses negative numbers).
            if (input >= 0)
            {
                MessageBox.Show("Enter a number greater than zero.");
                return;
            }

            account.changeBalance(input);
            UpdateAccountLabel();
        }

        //send money from the current account to the customer's other account
        private void btn_Transfer_Click(object _sender, EventArgs _e)
        {
            float input;

            //ensure that the input can be parsed. 
            try
            {
                input = float.Parse(txt_AccountInput.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
                return;
            }

            //ensure that there is enough money in the account to transfer. 
            if (input > account.balance)
            {
                MessageBox.Show("Insufficient Funds.");
                return;
            }

            if (account.type == "Checking_Account")
            {
                account.changeBalance(-input);
                Login.customer.savingsAccount.changeBalance(input);
            }
            else
            {
                account.changeBalance(-input);
                Login.customer.checkingAccount.changeBalance(input);
            }

            UpdateAccountLabel();
        }

        private void btn_Back_Click(object _sender, EventArgs _e)
        {
            this.Hide();
            Choose_Account chooseAccountForm = new Choose_Account();
            chooseAccountForm.Show();
        }

        //updates the AccountLabel to show the new balance.
        private void UpdateAccountLabel()
        {
            AccountLabel.Text = account.type + " Balance: $" + SQLHelper.GetBalance(account);
        }

        
    }
}
