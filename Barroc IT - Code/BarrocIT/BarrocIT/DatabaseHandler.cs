using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;

public class DatabaseHandler
{
    SqlConnection SQLConn;
	public DatabaseHandler(string SQLConnString)
	{
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

    public void disposeConnection()
    {
        SQLConn.Dispose();
    }

    public void testConnection()
    {
        try
        {
            openConnection();
        }
        catch (Exception exception)
        {
            MessageBox.Show("There occurred a error!" + exception);
        }
        finally
        {
            closeConnection();
        }
    }
}
