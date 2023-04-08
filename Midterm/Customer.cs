using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Customer
    {
        public int customerNumber;
        public int PIN;
        public SavingsAccount savingsAccount;
        public CheckingAccount checkingAccount;

        //default constructor with no parameters.
        public Customer()
        {
            this.customerNumber = 0;
            this.PIN = 0;
            this.savingsAccount = new SavingsAccount();
            this.checkingAccount = new CheckingAccount();
        }

        //constructor with parameters.
        public Customer(int _customerNumber, int _PIN, SavingsAccount _savingsAccount, CheckingAccount _checkingAccount)
        {
            this.customerNumber = _customerNumber;
            this.PIN = _PIN;
            this.savingsAccount = _savingsAccount;
            this.checkingAccount = _checkingAccount;
        }
    }
}
