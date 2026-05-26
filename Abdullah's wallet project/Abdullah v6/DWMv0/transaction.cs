using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace DWM_v0
{
    public class Transaction
    {
        // =========================
        // Properties
        // =========================
        private readonly DBmanager _dbManager;

        public int TransactionID { get; set; }

        public int SenderID { get; set; }

        public int ReceiverID { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; }

        public DateTime TransactionDate { get; set; }

        // =========================
        // Constructor
        // =========================
        public Transaction()
        {
            TransactionDate = DateTime.Now;
        }

        // =========================
        // Save Transaction to DB
        // =========================

        public void Save()
        {
            DBmanager db = new DBmanager();
            db.InsertToTransactionTable(this);
        }

        // =========================
        // Get Last 5 Transactions
        // =========================
        public List<Transaction> GetLastFive(int userId)
        {
            DBmanager db = new DBmanager();

            List<Transaction> allTransactions = db.GetTransactionsTable();

            List<Transaction> lastFiveList = new List<Transaction>();

            foreach(Transaction transaction in allTransactions)
            {
                if(transaction.SenderID == userId || transaction.ReceiverID == userId)
                {
                    lastFiveList.Add(transaction);
                }
            }

            //get last 5
            return lastFiveList.Skip(Math.Max(0, lastFiveList.Count - 5)).ToList();
        }

    }
}