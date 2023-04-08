using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Midterm
{
    public static class SQLHelper
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\School\Programming\C# Projects\Midterm\Midterm\Database1.mdf;Integrated Security=True";

        //check if there is an account matching the pin and number. Return true if one can be found and false if not. 
        public static bool CheckForAccount(Customer _customer)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * from Customer where Customer_Number=@customernumber and PIN=@pin", connection);
            command.Parameters.AddWithValue("@customernumber", _customer.customerNumber);
            command.Parameters.AddWithValue("@pin", _customer.PIN);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            connection.Close();

            int count = dataset.Tables[0].Rows.Count;
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns the savings account number associated with a customer. 
        public static int GetSavingsNumber(Customer _customer)
        {
            int output;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select Savings_Account_Number from Customer where Customer_Number = " + _customer.customerNumber, connection);
            connection.Open();
            reader = command.ExecuteReader();
            //read will advance to the next line, in this case it is advancing to the first line.
            reader.Read();
            output = reader.GetInt32(0);
            reader.Close();
            command.Dispose();
            connection.Close();

            return output;
        }

        //returns the checking account number associated with a customer. 
        public static int GetCheckingNumber(Customer _customer)
        {
            int output;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select Checking_Account_Number from Customer where Customer_Number = " + _customer.customerNumber, connection);
            connection.Open();
            reader = command.ExecuteReader();
            //read will advance to the next line, in this case it is advancing to the first line.
            reader.Read();
            output = reader.GetInt32(0);
            reader.Close();
            command.Dispose();
            connection.Close();

            return output;
        }

        //returns the balance of an account from the database based on its account type and number. 
        //input for type should be either "Checking_Account" or "Savings_Account".
        public static float GetBalance(BankAccount _account)
        {
            float output;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select Balance from " + _account.type + " where Account_Number = " + _account.accountNumber, connection);
            connection.Open();
            reader = command.ExecuteReader();
            //read will advance to the next line, in this case it is advancing to the first line.
            reader.Read();
            //since it won't convert directly to float, turn the decimal to a string before parsing.
            output = float.Parse(reader.GetDecimal(0).ToString());
            reader.Close();
            command.Dispose();
            connection.Close();

            return output;
        }

        //updates a datatable to show the balance of the account class. 
        public static void UpdateBalance(BankAccount _account)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("update " + _account.type + " set Balance = " + _account.balance + " where Account_Number = " + _account.accountNumber.ToString(), connection);
            connection.Open();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}
