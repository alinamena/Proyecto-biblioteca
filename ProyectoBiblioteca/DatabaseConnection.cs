using System;
using System.Windows.Forms;

using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString = "Data Source=Alina/Alina;Initial Catalog=LibraryDB;Integrated Security=True";

    public SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Database connection established.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        return connection;
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
