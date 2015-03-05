using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;
using MySql.Data.MySqlClient;

namespace VotingSystem
{

    public class SQLConnector
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public SQLConnector()
        {
            Initialize();

        }

        //Initialize values
        private void Initialize()
        {
            server = "mysql.itu.dk";
            database = "voting_system";
            uid = "fhor";
            password = "Flomme92";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }




        public void Trying()
        {

            var name = OpenConnection();
            if (name == true)
            {
                MessageBox.Show("DET VIRKEDE!!!!!");

            }

            else
            {
                MessageBox.Show("DET FEJLEDE!!!!!");
            }
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        /*

        //Close connection
        public bool CloseConnection()
        {
        }

        */
    }
}
