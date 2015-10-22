using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

// 
// Made by Tom Smits.
//

public class DatabaseHandler
{
    private string ConnectionString;
    SqlConnection SQLConn;

    public DatabaseHandler()
    {
        ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tom\Desktop\BarrocIT_DB.mdf;Integrated Security=True;Connect Timeout=30";

        SQLConn = new SqlConnection(ConnectionString);
    }

    public void openConnection()
    {
        SQLConn.Open();
    }

    public void closeConnection()
    {
        SQLConn.Close();
    }

    public SqlConnection getConection()
    {
        return SQLConn;
    }

    public DataTable SQLCommand(string query)
    {
        testConnection();
        openConnection();

        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, getConection());
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);

        closeConnection();
        return dt;
    }

    public void testConnection()
    {
        try
        {
            openConnection();
        }
        catch (Exception exception)
        {
            MessageBox.Show("" + exception, "Test connection failed an error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            closeConnection();
        }
    }
}
