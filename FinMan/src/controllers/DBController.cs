using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace FinMan.controllers
{
    class DBController
    {
        private SqlConnection serverConn;
        private int user_id;
        private bool user_admin;

        private int user_id_counter;
        private int acc_id_counter;
        private int tran_id_counter;
        private int acc_type_id_counter;
        private int exp_id_counter;
        private int inc_id_counter;

        // server connection
        public bool connectToServer(string connStr)
        {
            serverConn = new SqlConnection(connStr);

            try
            {
                serverConn.Open();
            }
            catch
            {
                serverConn.Dispose();
                return false;
            }

            // set counter initial values
            string comm = "SELECT COUNT(user_id) FROM dbo.Users;";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();
            data.Read();
            user_id_counter = (int)data[0];
            data.Close();

            comm = "SELECT COUNT(acc_id) FROM dbo.Accounts;";
            sqlComm = new SqlCommand(comm, serverConn);
            data = sqlComm.ExecuteReader();
            data.Read();
            acc_id_counter = (int)data[0];
            data.Close();

            comm = "SELECT COUNT(tran_id) FROM dbo.Transactions;";
            sqlComm = new SqlCommand(comm, serverConn);
            data = sqlComm.ExecuteReader();
            data.Read();
            tran_id_counter = (int)data[0];
            data.Close();

            comm = "SELECT COUNT(acc_type_id) FROM dbo.AccountTypes;";
            sqlComm = new SqlCommand(comm, serverConn);
            data = sqlComm.ExecuteReader();
            data.Read();
            acc_type_id_counter = (int)data[0];
            data.Close();

            comm = "SELECT COUNT(exp_id) FROM dbo.ExpenseTypes;";
            sqlComm = new SqlCommand(comm, serverConn);
            data = sqlComm.ExecuteReader();
            data.Read();
            exp_id_counter = (int)data[0];
            data.Close();

            comm = "SELECT COUNT(inc_id) FROM dbo.IncomeTypes;";
            sqlComm = new SqlCommand(comm, serverConn);
            data = sqlComm.ExecuteReader();
            data.Read();
            inc_id_counter = (int)data[0];
            data.Close();

            return true;
        }

        public bool disconnectFromServer()
        {
            try
            {
                serverConn.Close();
                serverConn.Dispose();
            }
            catch
            {
                return false;
            }

            return true;
        }

        // user login
        public int signup(string username, string password, bool admin)
        {
            // check if username available
            string comm = "SELECT (username) FROM dbo.Users WHERE username='" + username + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (!data.Read())
            {
                data.Close();
                comm = "INSERT INTO dbo.Users VALUES ("
                    + "'" + user_id_counter.ToString() + "',"
                    + "'" + username + "',"
                    + "'" + password + "',"
                    + "'" + (admin ? "1" : "0") + "');";
                sqlComm = new SqlCommand(comm, serverConn);
                sqlComm.ExecuteNonQuery();

                user_id_counter++;
                return 0;
            }

            data.Close();
            return -1;
        }

        public int signin(string username, string password)
        {
            string comm = "SELECT * FROM dbo.Users WHERE username="
                + "'" + username + "' AND password="
                + "'" + password + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (data.Read())
            {
                user_id = (int)data["user_id"];
                user_admin = (bool)data["admin"];
                data.Close();
                return (user_admin ? 1 : 0);
            }

            data.Close();
            return -1;
        }

        public int signout()
        {
            return 0;
        }

        public int deleteUser()
        {
            string comm = "DELETE FROM dbo.Users WHERE user_id="
                + "'" + user_id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            comm = "INSERT INTO dbo.Users(user_id, username, password) VALUES ("
                + "'" + user_id.ToString() + "', null, null);";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            return 0;
        }

        public int updateUser(string username, string password)
        {
            if(password == null)
            {
                // find user
                string comm = "SELECT (username) FROM dbo.Users Where username="
                    + "'" + username + "';";
                SqlCommand sqlComm = new SqlCommand(comm, serverConn);
                SqlDataReader data = sqlComm.ExecuteReader();

                if (data.Read())
                {
                    data.Close();
                    return 0;
                }
                else
                {
                    data.Close();
                    return -1;
                }
            }
            else
            {
                // modify user
                String comm = "UPDATE dbo.Users SET password="
                    + "'" + password + "' WHERE username="
                    + "'" + username + "';";
                SqlCommand sqlComm = new SqlCommand(comm, serverConn);

                sqlComm.ExecuteNonQuery();
                return 0;
            }
        }

        public DataSet getDataSet(string comm, bool userOnly)
        {
            if (userOnly)
            {
                comm = "SELECT * FROM (" + comm + ") AS tmp WHERE user_id="
                    + "'" + user_id.ToString() + "'";
            }
            comm += ";";

            DataSet data = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter(comm, serverConn);
            adap.Fill(data);

            return data;
        }

        public SqlDataReader getDataReader(string comm, bool userOnly)
        {
            if (userOnly)
            {
                comm = "SELECT * FROM (" + comm + ") WHERE user_id="
                    + "'" + user_id.ToString() + "'";
            }
            comm += ";";

            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            return data;
        }

        public bool addAccount(string name, int type_id, int balance, string desc)
        {
            // check if available
            string comm = "SELECT * FROM dbo.Accounts WHERE "
                + "user_id='" + user_id.ToString() + "'"
                + "AND name='" + name + "'"
                + "AND acc_type_id='" + type_id.ToString() + "'"
                + ";";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (data.Read())
            {
                data.Close();
                return false;
            }
            data.Close();

            // add account
            comm = "INSERT INTO dbo.Accounts VALUES ("
                + "'" + acc_id_counter.ToString() + "'"
                + ", '" + user_id.ToString() + "'"
                + ", '" + type_id.ToString() + "'"
                + ", '" + name + "'"
                + ", '" + desc + "');";
            sqlComm = new SqlCommand(comm, serverConn);

            try
            {
                sqlComm.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            // opening balance
            addTransaction(acc_id_counter, 1, -1, balance, DateTime.Now, "opening balance");

            acc_id_counter++;
            return true;
        }

        public bool updateAccount(string name, int type_id, int balance, string desc, int acc_id)
        {
            // check if available
            string comm = "SELECT * FROM dbo.Accounts WHERE "
                + "user_id='" + user_id.ToString() + "'"
                + "AND name='" + name + "'"
                + "AND acc_type_id='" + type_id.ToString() + "'"
                + ";";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (data.Read() && !(name == (string)data["name"] && type_id == (int)data["acc_type_id"]))
            {
                data.Close();
                return false;
            }
            data.Close();

            // update account details
            comm = "UPDATE dbo.Accounts SET "
                + "name=" + "'" + name + "'"
                + ", acc_type_id=" + "'" + type_id + "'"
                + ", description=" + "'" + desc + "'"
                + "WHERE acc_id=" + acc_id.ToString();
            sqlComm = new SqlCommand(comm, serverConn);

            try
            {
                sqlComm.ExecuteNonQuery();
            } 
            catch
            {
                return false;
            }

            // update balance
            if (balance != int.MinValue)
            {
                int tmp = getBalance(acc_id);
                int difference = balance - tmp;
                if (difference > 0)
                {
                    addTransaction(acc_id, 1, -1, difference, DateTime.Now, "balance correction");
                }
                else if (difference < 0)
                {
                    addTransaction(acc_id, -1, -1, -difference, DateTime.Now, "balance correction");
                }
            }

            return true;
        }

        public bool deleteAccount(int acc_id)
        {
            string comm = "DELETE FROM dbo.Accounts WHERE "
                + "acc_id=" + "'" + acc_id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            comm = "INSERT INTO dbo.Accounts VALUES ("
                + "'" + acc_id.ToString() + "'"
                + ", null, '0', null, null);";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery(); 

            return true;
        }

        public bool addType(int selection, string type)
        {
            string table = "";
            string idName = "";
            string typeName = "";
            int counter = -1;
            switch (selection)
            {
                case 0:
                    table = "dbo.AccountTypes";
                    idName = "acc_type_id";
                    typeName = "acc_type";
                    counter = acc_type_id_counter;
                    break;
                case 1:
                    table = "dbo.IncomeTypes";
                    idName = "inc_id";
                    typeName = "inc_type";
                    counter = inc_id_counter;
                    break;
                case -1:
                    table = "dbo.ExpenseTypes";
                    idName = "exp_id";
                    typeName = "exp_type";
                    counter = exp_id_counter;
                    break;
            }
            // check if available
            string comm = "SELECT * FROM " + table + " WHERE " + typeName + "="
                + "'" + type + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (data.Read())
            {
                data.Close();
                return false;
            }
            data.Close();

            // add type
            comm = "INSERT INTO " + table + " VALUES ("
                + "'" + counter.ToString() + "'"
                + ",'" + type + "');";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            switch (selection)
            {
                case 0:
                    acc_type_id_counter++;
                    break;
                case 1:
                    inc_id_counter++;
                    break;
                case -1:
                    exp_id_counter++;
                    break;
            }
            return true;
        }

        public bool updateType(int selection, string type, int id)
        {
            string table = "";
            string idName = "";
            string typeName = "";
            switch (selection)
            {
                case 0:
                    table = "dbo.AccountTypes";
                    idName = "acc_type_id";
                    typeName = "acc_type";
                    break;
                case 1:
                    table = "dbo.IncomeTypes";
                    idName = "inc_id";
                    typeName = "inc_type";
                    break;
                case -1:
                    table = "dbo.ExpenseTypes";
                    idName = "exp_id";
                    typeName = "exp_type";
                    break;
            }

            // check if available
            string comm = "SELECT * FROM " + table + " WHERE " + typeName + "="
                + "'" + type + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            if (data.Read())
            {
                data.Close();
                return false;
            }
            data.Close();

            // update type
            comm = "UPDATE " + table + " SET "
                + typeName + "='" + type + "' WHERE "
                + idName + "='" + id.ToString() + "';";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            return true;
        }

        public bool deleteType(int selection, int id)
        {
            string table = "";
            string idName = "";
            string typeName = "";
            switch (selection)
            {
                case 0:
                    table = "dbo.AccountTypes";
                    idName = "acc_type_id";
                    typeName = "acc_type";
                    break;
                case 1:
                    table = "dbo.IncomeTypes";
                    idName = "inc_id";
                    typeName = "inc_type";
                    break;
                case -1:
                    table = "dbo.ExpenseTypes";
                    idName = "exp_id";
                    typeName = "exp_type";
                    break;
            }

            string comm = "DELETE FROM " + table + " WHERE "
                + idName + "='" + id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            comm = "INSERT INTO " + table + " VALUES ("
                + "'" + id.ToString() + "', null);";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            return true;
        }

        public bool addTransaction(int acc_id, int type, int type_id, int amount, DateTime time, string desc)
        {
            string comm = "INSERT INTO dbo.Transactions VALUES (" 
                + "'" + tran_id_counter.ToString() + "'"
                + ",'" + user_id.ToString() + "'"
                + ",'" + acc_id.ToString() + "'"
                + ",";
            if(type == 1)
            {
                if (type_id != -1)
                {
                    comm += "null,'" + type_id.ToString() + "'"
                        + ",'" + (amount).ToString() + "',";
                }
                else
                {
                    comm += "null,null," + "'" + (amount).ToString() + "',";
                }
            }
            else
            {
                comm += "'" + type_id.ToString() + "',null"
                    + ",'" + (-amount).ToString() + "',";
            }
            comm += "'" + time.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                + ",'" + desc + "');";

            SqlCommand sqlComm = new SqlCommand(comm, serverConn);

            try
            {
                sqlComm.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            tran_id_counter++;
            return true;
        }

        public bool updateTransaction(int acc_id, int type, int type_id, int amount, DateTime time, string desc, int id)
        {
            string comm = "UPDATE dbo.Transactions Set acc_id="
                + "'" + acc_id.ToString() + "',";
            if(type == 1)
            {
                comm += "exp_id=null, inc_id="
                    + "'" + type_id.ToString() + "', amount="
                    + "'" + amount.ToString() + "',";
            } else
            {
                comm += "inc_id=null, exp_id="
                    + "'" + type_id.ToString() + "', amount="
                    + "'" + (-amount).ToString() + "',";
            }
            comm += "date=" + "'" + time.ToString("yyyy-MM-dd HH:mm:ss") + "',"
                + "description=" + "'" + desc + "'";
            comm += " WHERE tran_id=" + "'" + id.ToString() + "';";

            SqlCommand sqlComm = new SqlCommand(comm, serverConn);

            try
            {
                sqlComm.ExecuteNonQuery();
            } 
            catch
            {
                return false;
            }

            return true;
        }

        public bool deleteTransaction(int id)
        {
            string comm = "DELETE FROM dbo.Transactions WHERE "
                + "tran_id=" + "'" + id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            comm = "INSERT INTO dbo.Transactions VALUES ("
                + "'" + id.ToString() + "',null,null,null,null,null,null,null);";
            sqlComm = new SqlCommand(comm, serverConn);
            sqlComm.ExecuteNonQuery();

            return true;
        }

        public int getBalance(int acc_id)
        {
            int balance = 0;
            string comm = "SELECT SUM(amount) FROM dbo.Transactions WHERE acc_id="
                + "'" + acc_id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            data.Read();
            balance = (data[0] is DBNull) ? 0 : (int)data[0];
            data.Close();

            return balance;
        }

        public int getTotalBalance()
        {
            int balance = 0;
            string comm = "SELECT SUM(amount) FROM dbo.Transactions WHERE user_id="
                + "'" + user_id.ToString() + "';";
            SqlCommand sqlComm = new SqlCommand(comm, serverConn);
            SqlDataReader data = sqlComm.ExecuteReader();

            data.Read();
            balance = (data[0] is DBNull) ? 0 : (int)data[0];
            data.Close();

            return balance;
        }
    }
}
