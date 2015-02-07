using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    class Transaction
    {
        private int transactionID;
        private string dateTime;
        private string transactionType;
        private string transactionDescription;
        private double transactionAmount;
        private double accountBalance;
        private double paymentAmount;
        private double depositAmount;
        private string Cleared;

        public Transaction()
        {

        }

        public int transID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }

        public string date
        {
            get { return dateTime; }
            set { dateTime = value;}
        }

        public string transType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        public string transDesc
        {
            get { return transactionDescription; }
            set { transactionDescription = value; }
        }

        public double transAmt
        {
            get { return transactionAmount; }
            set { transactionAmount = value; }
        }

        public double acctBal
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public double debitAmt
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        public double creditAmt
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public string isCleared
        {
            get { return Cleared; }
            set { Cleared = value; }
        }
    }
}
