using System;
using System.Configuration; 
namespace _361DatabaseSchemaAssignment
{
    public class ConnectionAccessor
    {

        public static string GetConnectionString(string keyname)
        {
            string connection = string.Empty;

            if(keyname.Equals("DatabaseConnection"))
            {
                connection = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            }

            return connection; 
        }

    }
}

