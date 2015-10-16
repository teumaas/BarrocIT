using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

//
// Made by Tom Smits
//
public class DatabaseHandler
{
    SqlConnection SQLConn;
    private string SQLConnString;

	public DatabaseHandler(string SQLConnString)
	{
        this.SQLConnString = SQLConnString;
        SQLConn = new SqlConnection(SQLConnString);
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
            MessageBox.Show("An error occurred!" + exception);
        }
        finally
        {
            closeConnection();
        }
    }
}
