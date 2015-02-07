using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace AccountManager
{
    class DAL
    {
        /* Private Members */
        private OleDbConnection _dbConn;
        private string _connString;

        /* Public Methods */

        // Add transaction information to DB
        public Boolean insertTransaction(Transaction inTransaction)
        {
            Boolean _result = false;
            try
            {
                string _sql = "Insert into Checking ([ID],[Code],[Date],[Description],[Payment Amount],[Deposit Amount],[Balance],[Cleared]) values (:transactionID,:transactionType,:transactionDate,:transactionDesc,:paymentAmt,:depositAmt,:accountBal,:transCleared)";
                OleDbCommand _cmd = new OleDbCommand(_sql, _dbConn);
                _cmd.Parameters.AddWithValue("transactionID", inTransaction.transID);
                _cmd.Parameters.AddWithValue("transactionType", inTransaction.transType);
                _cmd.Parameters.AddWithValue("transactionDate", inTransaction.date);
                _cmd.Parameters.AddWithValue("transactionDesc", inTransaction.transDesc);
                _cmd.Parameters.AddWithValue("paymentAmt", inTransaction.debitAmt);
                _cmd.Parameters.AddWithValue("depositAmt", inTransaction.creditAmt);
                _cmd.Parameters.AddWithValue("accountBal", inTransaction.acctBal);
                _cmd.Parameters.AddWithValue("transCleared", inTransaction.isCleared);
                openDb();
                _cmd.ExecuteNonQuery();
                closeDb();
                _result = true;

            }
            catch (Exception ex)
            {
                _result = false;
                
                MessageBox.Show("Error: " + ex.Message);
 
            }

            return _result;

        }

        /* Constructors */
        public DAL()
        {
            _connString = Properties.Settings.Default.DBCheckingConnectionString1;
            _dbConn = new OleDbConnection(_connString);
        }

        /* Private Methods */

        // Open DB connection
        private int openDb()
        {
            int _result = 0;

            if (_dbConn.State == System.Data.ConnectionState.Closed)
            {
                _dbConn.Open();
                _result = 1;
            }
            else
            {
                _dbConn.Close();
                _dbConn.Open();
                _result = 1;
            }
            return _result;
        }

        // Close DB connection
        private int closeDb()
        {
            int _result = 0;
            if (_dbConn.State == System.Data.ConnectionState.Open)
            {
                _dbConn.Close();
                _result = 1;
            }
            return _result;
        }

    }
}
