﻿using System;
using System.Configuration;


namespace _361DatabaseSchemaAssignment
{
    public class ConnectionAccessor
    {

        // This method retrieves and stores the database connection string if the correct name is provided

        public static string GetConnectionString(string keyname)
        {
            string connection = string.Empty;

            if(keyname.Equals("DatabaseConnection"))
            {
                connection = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            }

            else
            {
                Environment.Exit(0);
                Console.WriteLine("An invalid database connection string was entered."); 
            }
            return connection; 
        }

        // This method establishes a connection to the MSSQL server instance

        private void TestDatabaseConnection(string connection)
        {
            // TODO:

            // SqlConnection conn = new SqlConnection(ConnectionAccessor.GetConnectionString("DatabaseConnection")); 
            
        }
    }
}

