using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DWM_v0
{
    internal class User
    {
        // =========================
        // Properties
        // =========================

        public int UserID { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public decimal Balance { get; set; }

        private readonly DBmanager _dbManager;

        public User(DBmanager dbManager)
        {
            _dbManager = dbManager;
        }
        public User()
        {
        }
        // =========================
        // Deposit
        // =========================
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // =========================
        // Withdraw
        // =========================
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }

        // =========================
        // Transfer
        // =========================
        public bool Transfer(User receiver, decimal amount)
        {
            if (receiver == null)
                return false;

            if (this.Withdraw(amount))
            {
                receiver.Deposit(amount);
                return true;
            }

            return false;
        }

        // =========================
        // Check Password
        // =========================
        public bool CheckPassword(string password)
        {
            return this.Password == password;
        }

        // =========================
        // Get User By Phone (from DB)
        // =========================
        public static User GetUserByPhone(string phone)
        {
            DBmanager db = new DBmanager();

            List<User> users = db.GetUsersTable();

            foreach (User user in users)
            {
                if(user.PhoneNumber == phone)
                {
                    return user;
                }
            }

            return null;
        }


        // =========================
        // Get Balance from DB
        // =========================
        public decimal GetBalance()
        {
            DBmanager db = new DBmanager();

            List<User> users = db.GetUsersTable();

            foreach (User user in users)
            {
                if (user.UserID == UserID)
                {
                    return user.Balance;
                }
            }

            return 0;
        }

        // =========================
        // Update Balance in DB
        // =========================
        public void UpdateBalance()
        {
            DBmanager db = new DBmanager();
            db.UpdateUserTable(this);
        }
    }
}