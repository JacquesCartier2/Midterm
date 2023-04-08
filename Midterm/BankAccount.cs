using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public abstract class BankAccount
    {
        public int accountNumber;
        public float balance;
        public string type = null;

        //default constructor with no parameters.
        public BankAccount()
        {
            this.accountNumber = 0;
            this.balance = 0;
        }

        //constructor with parameters.
        public BankAccount(int _accountNumber, float _balance)
        {
            this.accountNumber = _accountNumber;
            this.balance = _balance;
        }

        //changes the balance variable, then updates the database with the new balance.
        virtual public void changeBalance(float _changeAmount)
        {
            //use the ToString function to limit the change amount to 2 decimal points.
            _changeAmount = float.Parse(_changeAmount.ToString("n2"));

            float newBalance = balance + _changeAmount;

            //do not allow for a negative balance.
            if (newBalance < 0)
            {
                newBalance = 0;
            }

            balance = newBalance;

            SQLHelper.UpdateBalance(this);
        }
    }

    public class SavingsAccount : BankAccount
    {

        //default constructor with no parameters.
        public SavingsAccount()
        {
            this.accountNumber = 0;
            this.balance = 0;
            this.type = "Savings_Account";
        }

        //constructor with parameters.
        public SavingsAccount(int _accountNumber, float _balance)
        {
            this.accountNumber = _accountNumber;
            this.balance = _balance;
            this.type = "Savings_Account";
        }

        

    }

    public class CheckingAccount : BankAccount
    {

        //default constructor with no parameters.
        public CheckingAccount()
        {
            this.accountNumber = 0;
            this.balance = 0;
            this.type = "Checking_Account";
        }

        //constructor with parameters.
        public CheckingAccount(int _accountNumber, float _balance)
        {
            this.accountNumber = _accountNumber;
            this.balance = _balance;
            this.type = "Checking_Account";
        }

        //changes the balance variable, then updates the database with the new balance.
        //if more money is being withdrawn than is in the balance, take the rest of the money from the savings account
        override public void changeBalance(float _changeAmount)
        {
            //use the ToString function to limit the change amount to 2 decimal points.
            _changeAmount = float.Parse(_changeAmount.ToString("n2"));

            float newBalance = balance + _changeAmount;

            //take the rest of the money from the savings accout if there is not enough in checking.
            if (newBalance < 0)
            {
                //for withdrawls, change amount is negative, so it is reduced by addition.
                _changeAmount += balance;
                Login.customer.savingsAccount.changeBalance(_changeAmount);
                newBalance = 0;
            }

            balance = newBalance;

            SQLHelper.UpdateBalance(this);
        }
    }
}
