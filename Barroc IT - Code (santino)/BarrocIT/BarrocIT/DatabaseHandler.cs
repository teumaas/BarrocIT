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
        string DBFile = "BarrocIT_DB.mdf";

        ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" +
                           Application.ExecutablePath.Remove(Application.ExecutablePath.Length - 22) + DBFile +
                           @";Integrated Security=True;Connect Timeout=30";

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

    public SqlConnection getConnection()
    {
        return SQLConn;
    }

    public DataTable SQLCommand(string query)
    {
        testConnection();
        openConnection();

        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, getConnection());
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);

        closeConnection();
        return dt;
    }

    public object GetFirstValue(string Query)
    {
        openConnection();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = getConnection();
        cmd.CommandText = Query;
        SqlDataReader reader = cmd.ExecuteReader();
        object result = -1;

        if (reader.HasRows)
        {
            reader.Close();
            result = cmd.ExecuteScalar();
        }
        else
        {
            reader.Close();
        }

        closeConnection();
        return result;
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
