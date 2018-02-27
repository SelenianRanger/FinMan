using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using FinMan.forms;
using FinMan.controllers;

namespace FinMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MainWindow mainWindow = new MainWindow();
            ConnectionDialog connDialog = new ConnectionDialog();

            DBController dbController = new DBController();

            // main window listeners
            mainWindow.showSettings = () => { connDialog.ShowDialog(); };

            mainWindow.getDataSet = (string comm, bool userOnly) =>
            {
                return dbController.getDataSet(comm, userOnly);
            };

            mainWindow.update = () =>
            {
                mainWindow.updateTable();

                DataSet data = dbController.getDataSet("SELECT user_id, name AS [Name], balance AS [Balance] FROM AccountBalances", true);
                mainWindow.updateAccountsTable(data);

                int balance = dbController.getTotalBalance();
                mainWindow.updateTotalBalance(balance);
            };

            mainWindow.modifyListener = (string name, int type_id, int balance, string desc, int action, int acc_id) =>
            {
                switch (action)
                {
                    // add account
                    case 1:
                        return dbController.addAccount(name, type_id, balance, desc);
                    // modify account
                    case 0:
                        return dbController.updateAccount(name, type_id, balance, desc, acc_id);
                    // delete account
                    case -1:
                        return dbController.deleteAccount(acc_id);
                    default:
                        return false;
                }
            };

            mainWindow.adminModifyListener = (int selection, string type, int action, int id) =>
            {
                switch (action)
                {
                    // add type
                    case 1:
                        return dbController.addType(selection, type);

                    // update type
                    case 0:
                        return dbController.updateType(selection, type, id);

                    // delete type
                    case -1:
                        return dbController.deleteType(selection, id);
                    default:
                        return false;
                }
            };

            mainWindow.modifyTransactionListener = (int acc_id, int type, int type_id, int amount, DateTime time, string desc, int action, int id) =>
            {
                switch (action)
                {
                    // add transaction
                    case 1:
                        return dbController.addTransaction(acc_id, type, type_id, amount, time, desc);
                    // update transaction
                    case 0:
                        return dbController.updateTransaction(acc_id, type, type_id, amount, time, desc, id);
                    // delete transaction
                    case -1:
                        return dbController.deleteTransaction(id);
                    default:
                        return false;
                }
            };

            // connection dialog listeners
            connDialog.connListener = (string connStr) =>
            {
                if(connStr != null)
                {
                    return dbController.connectToServer(connStr);
                }
                else
                {
                    return dbController.disconnectFromServer();
                }
            };

            connDialog.signinListener = (string username, string password, int action, bool admin) =>
            {
                switch (action)
                {
                    // signup
                    case 1:
                        if(username != null)
                        {
                            return dbController.signup(username, password, admin);
                        }
                        return -1;
                        
                    // signin
                    case 0:
                        if(username != null)
                        {
                            int res = dbController.signin(username, password);
                            if(res != -1)
                            {
                                mainWindow.connect(true, (res == 1));

                                return res;
                            }

                        }
                        return -1;
                       
                    // delete
                    case -1:
                        return dbController.deleteUser();
                        
                    // update
                    case 2:
                        return dbController.updateUser(username, password);
                        
                    // signout
                    case -2:
                        {
                            int res = dbController.signout();
                            if(res != -1)
                            {
                                mainWindow.updateAccountsTable(null);
                                mainWindow.connect(false, false);
                            }

                            return res;
                        }
                        
                    default:
                        return -1;
                }
            };

            Application.EnableVisualStyles();
            Application.Run(mainWindow);
        }
    }
}
