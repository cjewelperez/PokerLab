using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

// See https://aka.ms/new-console-template for more information

public class DatabaseMain
{
    static public void Main(String[] args)
    {
        _361DatabaseSchemaAssignment.ConnectionAccessor newAccessor = new _361DatabaseSchemaAssignment.ConnectionAccessor();

        _361DatabaseSchemaAssignment.ConnectionAccessor.TestDatabaseConnection(); 

    }
}

