using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Login : Form
    {
        //only one customer can be using the program at a time, and that customer's details will be stored under the "customer" instance.
        public static Customer customer = new Customer();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object _sender, EventArgs _e)
        {
            //set customer number and pin to the entered values.
            try
            {
                customer.customerNumber = int.Parse(txt_CustomerNumber.Text);
                customer.PIN = int.Parse(txt_PIN.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numbers only, and ensure that both fields are filled.");
                return;
            }

            //if there is a valid account, show the choose account form and set the variables for the customer's accounts. If not show a failure textbox. 
            if (SQLHelper.CheckForAccount(customer))
            {
                customer.checkingAccount.accountNumber = SQLHelper.GetCheckingNumber(customer);
                customer.savingsAccount.accountNumber = SQLHelper.GetSavingsNumber(customer);
                customer.checkingAccount.balance = SQLHelper.GetBalance(customer.checkingAccount);
                customer.savingsAccount.balance = SQLHelper.GetBalance(customer.savingsAccount);

                this.Hide();
                Choose_Account chooseAccountForm = new Choose_Account();
                chooseAccountForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid authentication.");
            }
            
        }
    }
}
