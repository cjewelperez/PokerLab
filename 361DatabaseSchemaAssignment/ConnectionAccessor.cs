using System;
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
                Console.WriteLine("An invalid database connection name was entered."); 
            }
            return connection; 
        }

        // This method establishes a connection to the MSSQL server instance

        public static void TestDatabaseConnection(string connection)
        {
            // TODO: 
        }



    }
}

