using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        private DataProvider() { }

        string connectionString = @"Data Source=DESKTOP-EAENUQG\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
        SqlConnection Connection { get; set; }

        public void connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(connectionString);
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void disconnect()
        {
            try
            {
                if (Connection != null && Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery1(CommandType cmdType, string strSQL, params SqlParameter[] parameters)
        {
            try
            {
                connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmdType;
                command.CommandText = strSQL;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disconnect();
            }
        }

        public int ExecuteNonQuery2(string query, object[] paramater = null)
        {
            int data = 0;
            connect();
            SqlCommand command = new SqlCommand(query, Connection);
            if (paramater != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, paramater[i]);
                        i++;
                    }
                }
            }
            data = command.ExecuteNonQuery();
            disconnect();
            return data;
        }

        public DataTable Select(CommandType cmdType, string strSQL)
        {
            try
            {
                connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmdType;
                command.CommandText = strSQL;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disconnect();
            }
        }

    }
}
