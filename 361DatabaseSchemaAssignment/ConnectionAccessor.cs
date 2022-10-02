using System;
using System.Configuration;
using System.Data; 
using System.Data.SqlClient;
using System.Web;


namespace _361DatabaseSchemaAssignment
{
    public class ConnectionAccessor
    {

        // This method retrieves and stores the database connection string if the correct name is provided

        public  string GetConnectionString(string keyname)
        {
            string connection = string.Empty;

            switch (keyname)
            {
                case "DatabaseConnection":
                    connection = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                    break; 

                default:
                    Console.WriteLine("An invalid database connection string was entered."); 
                    break; 
            }
            return connection; 
        }

        // This method establishes a connection to the MSSQL server instance

        public static void TestDatabaseConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionAccessor.GetConnectionString("DatabaseConnection"));
            con.Open();
            Console.WriteLine("Connection to server was successful"); 
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Employee", con);
            dataAdapter.Fill(dataTable);
        }
    }
}

