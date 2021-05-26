using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DBCarsconnect
{
    class DBConnection
    {
        // store the MySql connection here for use later 
         MySqlConnection connection = null;
        
          string connectionString;

        public MySqlConnection Connection { get => connection; }


        // connection string will be composed of following information
        // server name 
        // database 
        // username 
        // password 

        public DBConnection(string serverName, string databaseName, string userID, string password)
        {
            // Example Connection String:
            // SERVERNAME=localhost;DATABASE=hire;UID=csharp;PASSWORD=password;

            this.connectionString = $"SERVER={serverName};DATABASE={databaseName};UID={userID};PASSWORD={password};";

        }

        public bool Connect()
        {
            bool suceeded = true;

            try
            {

                this.connection = new MySqlConnection(this.connectionString);

                this.connection.Open();		

            }
            catch (MySqlException ex)
            {
                suceeded = false;

                switch(ex.Number)
                {
                   
                    default:
                        MessageBox.Show("Exception found.\n"+ ex.Message);
                        break;
                }
            }

            return suceeded;
        }

        public bool Close()
        {
            bool succeeded = true;

            try
            {
                this.connection.Close();
            }

            catch(MySqlException ex)
            {
                succeeded = false;
                MessageBox.Show("Exception found: " + ex.Message);
            }

            return succeeded;

            

        }
    }
}