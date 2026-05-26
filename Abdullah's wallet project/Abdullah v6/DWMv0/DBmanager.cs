using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace DWM_v0
{
    internal class DBmanager
    {
        private OleDbConnection connection;

        public DBmanager()
        {
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=WalletDB.accdb;";

            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        public OleDbDataReader ExecuteReader(string query, OleDbParameter[] parameters)
        {
            OleDbCommand command = new OleDbCommand(query, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return command.ExecuteReader();
        }

        public object ExecuteScalar(string query, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteScalar();
            }
        }

        public int ExecuteNonQuery(string query, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public List<Transaction> GetTransactionsTable()
        {
            List<Transaction> transactions = new List<Transaction>();

            DBmanager db = new DBmanager();

            string query = "SELECT * FROM [transaction] ";

            using (OleDbDataReader reader = db.ExecuteReader(query, null))
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        TransactionID = Convert.ToInt32(reader["TransactionID"]),
                        SenderID = Convert.ToInt32(reader["SenderID"]),
                        ReceiverID = Convert.ToInt32(reader["ReceiverID"]),
                        Amount = Convert.ToDecimal(reader["Amount"]),
                        Type = reader["Type"].ToString(),
                        TransactionDate = Convert.ToDateTime(reader["TransactionDate"])
                    };

                    transactions.Add(transaction);
                }
            }

            return transactions;
        }

        public void InsertToTransactionTable(Transaction transaction)
        {
            DBmanager db = new DBmanager();

            string query = "INSERT INTO [transaction] ([SenderID], [ReceiverID], [Amount], [Type], [TransactionDate]) VALUES  (?, ?, ?, ?,?)";

            OleDbParameter[] parameters =
            {
                new OleDbParameter
                {
                    OleDbType = OleDbType.Integer,
                    Value = transaction.SenderID
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Integer,
                    Value = transaction.ReceiverID
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Currency,
                    Value = transaction.Amount
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = transaction.Type
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Date,
                    Value = transaction.TransactionDate
                }
            };
            int rowsAffected = db.ExecuteNonQuery(query, parameters);
        }

        public List<User> GetUsersTable()
        {
            List<User> users = new List<User>();

            DBmanager db = new DBmanager();

            string query = "SELECT * FROM [User]";

            using (OleDbDataReader reader = db.ExecuteReader(query, null))
            {
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["FullName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Balance = Convert.ToDecimal(reader["Balance"]),
                        Password = reader["Password"].ToString(),
                    };

                    users.Add(user);
                }
            }

            return users;
        }

        public void InsertToUserTable(User user)
        {
            DBmanager db = new DBmanager();

            string query = "INSERT INTO [User] ([FullName], [PhoneNumber], [Password], [Balance]) VALUES  (?, ?, ?, ?)";

            OleDbParameter[] parameters =
            {
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.FullName
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.PhoneNumber
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.Password
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Currency,
                    Value = user.Balance
                }
            };

            int rowsAffected = db.ExecuteNonQuery(query, parameters);
        }

        public void UpdateUserTable(User user)
        {
            DBmanager db = new DBmanager();
            
            string query = "UPDATE [User] SET [FullName] = ?,  [PhoneNumber] = ?, [Password] = ?, [Balance] = ? WHERE [UserID] = ?";

            OleDbParameter[] parameters =
{
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.FullName
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.PhoneNumber
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.VarWChar,
                    Value = user.Password
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Currency,
                    Value = user.Balance
                },
                new OleDbParameter
                {
                    OleDbType = OleDbType.Integer,
                    Value = user.UserID
                }
            };

            db.ExecuteNonQuery(query, parameters);
        }
    }
}