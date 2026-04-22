using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Maslyanchuk_Eric
{
    //database manager class to handle database connections
    public static class DatabaseManager
    {
        //method to get a new SQL connection
        public static SqlConnection GetConnection()
        {
            // Connection string to connect to the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\UnitedStates.mdf;
          Integrated Security=True";

            //return a new SqlConnection object
            return new SqlConnection(connectionString);
        }
    }
}
