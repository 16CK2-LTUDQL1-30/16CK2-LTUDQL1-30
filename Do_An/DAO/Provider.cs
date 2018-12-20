using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Provider
    {
        static string ConnectionString = @"Data Source=DESKTOP-57EP8JP\SQLEXPRESS;Initial Catalog=QL_VeXeKhach;Persist Security Info=True;User ID=sa;Password=ttth";
        SqlConnection connect;

        public void Connect()
        {
            try
            {
                if(connect == null)
                {
                    connect = new SqlConnection(ConnectionString);
                }
                if(connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                connect.Open();
            }
            catch(SqlException ex)
            { throw ex; }
        }
        public void Disconnect()
        {
            if(connect != null && connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public int ExcuteNoneQuery(CommandType cmdType, string strSql, params SqlParameter [] parameters)
        {
            try
            {
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                if(parameters !=null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                int nRow = cmd.ExecuteNonQuery();
                return nRow;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter [] parameters)
        {
            try
            {
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                if(parameters !=null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
