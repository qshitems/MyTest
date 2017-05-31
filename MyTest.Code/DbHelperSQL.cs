using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Code
{
    public abstract class DbHelperSQL
    {
        public static readonly string strConn = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
        public DbHelperSQL() { }

        #region 公用方法


        public static int GetMaxID(string FieldName, string TableName)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            object obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }

        public static int GetMaxID(string FieldName, string TableName, string strWhere)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            if (!string.IsNullOrEmpty(strWhere))
            {
                strsql += " where " + strWhere;
            }
            object obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }

        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Exists(SqlConnection conn, string strSql, params SqlParameter[] cmdParms)
        {
            object obj = GetSingle(conn, strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteMuliSql(Hashtable htSQLString)
        {
            SqlTransaction trans = null;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try

                    {
                        if (connection.State != ConnectionState.Open) connection.Open();
                        trans = connection.BeginTransaction();
                        int rows = 0;
                        foreach (DictionaryEntry htSQL in htSQLString)
                        {
                            SqlParameter[] cmdParms = (SqlParameter[])htSQL.Value;
                            PrepareCommand(cmd, connection, trans, htSQL.Key.ToString(), cmdParms);

                            rows += cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        return rows;
                    }
                    catch (System.Data.OleDb.OleDbException E)
                    {
                        trans.Rollback();
                        trans.Dispose();
                        trans = null;
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteMuliSqlPour(Hashtable htSQLString)
        {
            SqlTransaction trans = null;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open) connection.Open();
                        trans = connection.BeginTransaction();
                        int rows = 0;
                        foreach (DictionaryEntry htSQL in htSQLString)
                        {
                            SqlParameter[] cmdParms = (SqlParameter[])htSQL.Value;
                            PrepareCommand(cmd, connection, trans, htSQL.Key.ToString(), cmdParms);

                            rows += cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        if (rows >= htSQLString.Count)
                        {
                            trans.Commit();
                            return rows;
                        }
                        else
                        {
                            trans.Rollback();
                            trans.Dispose();
                            trans = null;
                            return 0;
                        }


                    }
                    catch (System.Data.OleDb.OleDbException E)
                    {
                        trans.Rollback();
                        trans.Dispose();
                        trans = null;
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteMuliSql(string SQLString)
        {
            SqlTransaction trans = null;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open) connection.Open();
                        trans = connection.BeginTransaction();

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = SQLString;
                        int rows = cmd.ExecuteNonQuery();

                        trans.Commit();

                        return rows;
                    }
                    catch (Exception E)
                    {
                        if (connection.State == ConnectionState.Open)
                            trans.Rollback();
                        trans.Dispose();
                        trans = null;
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteSql(string SQLString)
        {
            //DbHelperSQLThread thrSQL = new DbHelperSQLThread(SQLString);
            //ThreadStart threadStart = new ThreadStart(thrSQL.ExecuteSql);
            //Thread thread = new Thread(threadStart);
            //thread.Start();

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.OleDb.OleDbException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>   
        /// 执行一条计算查询结果语句，返回查询结果（object）。   
        /// </summary>   
        /// <param name="connection"></param>  
        /// <param name="SQLString">计算查询结果语句</param>   
        /// <returns>查询结果（object）</returns>   
        public static object GetSingleModel(SqlConnection connection, string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    object obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                catch (System.Data.OleDb.OleDbException e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        /// <summary>   
        /// 执行一条计算查询结果语句，返回查询结果（object）。   
        /// </summary>   
        /// <param name="SQLString">计算查询结果语句</param>   
        /// <returns>查询结果（object）</returns>   
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.OleDb.OleDbException e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>   
        /// 执行一条计算查询结果语句，返回查询结果（object）。   
        /// </summary>   
        /// <param name="connection"></param>  
        /// <param name="SQLString">计算查询结果语句</param>   
        /// <returns>查询结果（object）</returns>   
        public static object GetSingle(SqlConnection connection, string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    object obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                catch (System.Data.OleDb.OleDbException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;   
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                {
                    //cmd.Parameters.Add(parm);
                    if ((parm.Direction == ParameterDirection.InputOutput || parm.Direction == ParameterDirection.Input) &&
                        (parm.Value == null))
                    {
                        parm.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parm);
                }
            }
        }

        /// <summary>   
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>   
        /// <param name="SQLString">SQL语句</param>   
        /// <returns>影响的记录数</returns>   
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.OleDb.OleDbException E)
                    {
                        throw new Exception(E.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 执行SQL语句，返回影响的记录数   
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="SQLString"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static int ExecuteSql(SqlConnection connection, string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    int rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return rows;
                }
                catch (System.Data.OleDb.OleDbException E)
                {
                    throw new Exception(E.Message);
                }
            }
        }

        /// <summary>   
        /// 执行查询语句，返回DataSet   
        /// </summary>   
        /// <param name="SQLString">查询语句</param>   
        /// <returns>DataSet</returns>   
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                DataSet ds = new DataSet();
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    connection.Close();
                    return ds;
                }
            }
        }

        public static DataSet Query(SqlConnection connection, string SQLString, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, SQLString, cmdParms);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds, "ds");
                    cmd.Parameters.Clear();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                //connection.Close();
                return ds;
            }
        }


        /// <summary>   
        /// 执行存储过程，返回影响行数   
        /// </summary>   
        /// <param name="storedProcName">string类型存储过程名</param>   
        /// <param name="parameters">SqlParameters[]存储过程参数</param>   
        /// <returns>int 影响行数</returns>   
        public static int RunProcedure_NonQuery(string storedProcName, IDataParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
                    return (command.ExecuteNonQuery());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>   
        /// 执行存储过程，返回影响行数   
        /// </summary>   
        /// <param name="storedProcName">string类型存储过程名</param>   
        /// <param name="parameters">SqlParameters[]存储过程参数</param>   
        /// <returns>int 影响行数</returns>   
        public static int RunProcedure_NonQuery(string connStr, string storedProcName, IDataParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
                    return (command.ExecuteNonQuery());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>   
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)   
        /// </summary>   
        /// <param name="connection">数据库连接</param>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <returns>SqlCommand</returns>   
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        /// <summary>   
        /// 执行存储过程   
        /// </summary>   
        /// <param name="storedProcName">存储过程名</param>   
        /// <param name="parameters">存储过程参数</param>   
        /// <param name="tableName">DataSet结果中的表名</param>   
        /// <returns>DataSet</returns>   
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                DataSet dataSet = new DataSet();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }
    }
}