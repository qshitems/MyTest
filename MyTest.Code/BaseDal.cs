using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Code
{
    public class BaseDal
    {
        public static string dbConnectionString
        {
            get
            {

                try
                {

                    return ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
                }
                catch
                {

                }
                return string.Empty;
            }
        }
        public static SqlConnection GetConnection
        {
            get
            {
                return new SqlConnection(dbConnectionString);
            }
        }
        #region ExecuteReaderReturnObj
        /// <summary>
        /// 执行sql，返回影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int ExecuteUpdate(string sql, dynamic param = null)
        {
            using (IDbConnection conn = GetConnection)
            {
                return conn.Execute(sql, param as object);
            }
        }
        /// <summary>
        /// 返回一条记录,非实体类，是匿名对象--单记录
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数,执行条件查询时要参数化</param>
        /// <returns></returns>
        public static object ExecuteReaderReturnObj(string sql, dynamic param = null)
        {
            using (IDbConnection conn = GetConnection)
            {
                return conn.Query(sql, param as object).SingleOrDefault();
            }
        }
        /// <summary>
        /// 返回一条记录,非实体类，是匿名对象--多记录
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数,执行条件查询时要参数化</param>
        /// <returns></returns>
        public static object ExecuteReaderReturnObjList(string sql, dynamic param = null)
        {
            using (IDbConnection conn = GetConnection)
            {
                return conn.Query(sql, param as object).ToList();
            }
        }
        #endregion
        #region ExecuteReaderReturnT
        /// <summary>
        /// 返回一条记录
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数,执行条件查询时要参数化</param>
        /// <returns></returns>
        public static T ExecuteReaderReturnT<T>(string sql, dynamic param = null)
        {
            using (IDbConnection conn = GetConnection)
            {
                return conn.Query<T>(sql, param as object).SingleOrDefault();
            }
        }
        #endregion
        #region ExecuteReaderReturnListT
        /// <summary>
        /// 返回一集合记录
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数,执行条件查询时要参数化</param>
        /// <returns></returns>
        public static List<T> ExecuteReaderReturnListT<T>(string sql, dynamic param = null)
        {
            using (IDbConnection conn = GetConnection)
            {
                var result = conn.Query<T>(sql, param as object);//.ToList();
                if (result != null && result.Count() != 0)
                    return result.ToList();
                return new List<T>();
            }
        }
        #endregion
        #region ExecuteReaderReturnPageListT
        /// <summary>
        /// 返回一集合记录，分页
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="columns">查询的列</param>
        /// <param name="selectCol">查询列别名</param>
        /// <param name="key">主键</param>
        /// <param name="tableName">表名</param>
        /// <param name="orderBy">排序</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="pageSize">每一页多少条数据,如果为0，则不分页</param>
        /// <returns></returns>
        public static List<T> ExecuteReaderReturnPageListT<T>(string columns, string tableName, string key,
            string orderBy, int pageIndex, int pageSize, out int total)
        {
            return ExecuteReaderReturnPageListT<T>(columns, tableName, key, orderBy, pageIndex, pageSize, null, out total);
        }


        public static List<T> ExecuteReaderReturnPageListT<T>(string columns, string tableName, string key, Pagination Pagination,
        dynamic param = null)
        {
            int pageSize = Pagination.rows;
            string where = Pagination.where;
            if (pageSize == 0)//不分页
            {
                Pagination.records = 0;
                return GetItemList<T>(columns, tableName, key, Pagination.sidx, where, param as object);
            }
            string orderBy = Pagination.sidx;
            int pageIndex = Pagination.page;
            int sumNums = GetPageListCount(tableName, where, param as object);
            Pagination.records = sumNums;
            if (sumNums == 0)
            {
                return new List<T>();
            }
            if (pageIndex < 2)//第一页
            {
                return GetPageListNumFirst<T>(columns, tableName, orderBy, pageSize, where, param as object);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * FROM (SELECT {0}, ROW_NUMBER() OVER(ORDER BY {1}) num FROM {2}", columns, string.IsNullOrEmpty(orderBy) ? key + " DESC" : orderBy, tableName);
            if (!string.IsNullOrEmpty(where))
            {
                sb.AppendFormat(" WHERE {0}", where);
            }
            sb.Append(") tmp WHERE num BETWEEN @pageMin AND @pageMax");


            DynamicParameters p = new DynamicParameters();
            if (param == null)
            {
                p.Add("pageMin", pageSize * (pageIndex - 1) + 1);
                p.Add("pageMax", pageSize * pageIndex);
            }
            else
            {
                p.AddDynamicParams(param);
                p.Add("pageMin", pageSize * (pageIndex - 1) + 1);
                p.Add("pageMax", pageSize * pageIndex);
            }
            using (IDbConnection conn = GetConnection)
            {
                var list = conn.Query<T>(sb.ToString(), p).ToList();
                if (list == null)
                    return new List<T>();
                return list;
            }
        }
        /// <summary>
        /// 返回一集合记录，分页
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="columns">查询的列</param>
        /// <param name="selectCol">查询列别名</param>
        /// <param name="key">主键</param>
        /// <param name="tableName">表名</param>
        /// <param name="orderBy">排序</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="pageSize">每一页多少条数据,如果为0，则不分页</param>
        /// <param name="where">where条件</param>
        /// <param name="parameters">sql参数，执行条件查询时要参数化</param>
        /// <returns></returns>
        public static List<T> ExecuteReaderReturnPageListT<T>(string columns, string tableName, string key,
            string orderBy, int pageIndex, int pageSize, string where, out int total, dynamic param = null)
        {
            if (pageSize == 0)//不分页
            {
                total = 0;
                return GetItemList<T>(columns, tableName, key, orderBy, where, param as object);
            }
            int sumNums = GetPageListCount(tableName, where, param as object);
            total = sumNums;
            if (sumNums == 0)
            {
                return new List<T>();
            }
            if (pageIndex < 2)//第一页
            {
                return GetPageListNumFirst<T>(columns, tableName, orderBy, pageSize, where, param as object);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * FROM (SELECT {0}, ROW_NUMBER() OVER(ORDER BY {1}) num FROM {2}", columns, string.IsNullOrEmpty(orderBy) ? key + " DESC" : orderBy, tableName);
            if (!string.IsNullOrEmpty(where))
            {
                sb.AppendFormat(" WHERE {0}", where);
            }
            sb.Append(") tmp WHERE num BETWEEN @pageMin AND @pageMax");
            

            DynamicParameters p = new DynamicParameters();
            if (param == null)
            {
                p.Add("pageMin", pageSize * (pageIndex - 1) + 1);
                p.Add("pageMax", pageSize * pageIndex);
            }
            else
            {
                p.AddDynamicParams(param);
                p.Add("pageMin", pageSize * (pageIndex - 1) + 1);
                p.Add("pageMax", pageSize * pageIndex);
            }
            using (IDbConnection conn = GetConnection)
            {
                var list = conn.Query<T>(sb.ToString(), p).ToList();
                if (list == null)
                    return new List<T>();
                return list;
            }
        }
        /// <summary>
        /// 获取总数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int GetPageListCount(string tableName, string where, object param)
        {
            string sql = string.Format("SELECT COUNT(0) FROM {0}", tableName);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " WHERE " + where;
            }
            using (IDbConnection conn = GetConnection)
            {
                return conn.Query<int>(sql, param).SingleOrDefault();
            }
        }
        /// <summary>
        /// 不分页
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableName"></param>
        /// <param name="key"></param>
        /// <param name="orderByCol"></param>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static List<T> GetItemList<T>(string columns, string tableName, string key, string orderByCol, string where, object param)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT {0}", columns);
            sb.AppendFormat(" FROM {0}", tableName);
            if (!string.IsNullOrEmpty(where))
            {
                sb.AppendFormat(" WHERE {0}", where);
            }
            if (!string.IsNullOrEmpty(orderByCol))
            {
                sb.AppendFormat(" ORDER BY {0}", orderByCol);
            }
            using (IDbConnection conn = GetConnection)
            {
                return conn.Query<T>(sb.ToString(), param).ToList();
            }
        }
        /// <summary>
        /// 第一页
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableName"></param>
        /// <param name="key"></param>
        /// <param name="orderByCol"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<T> GetPageListNumFirst<T>(string columns, string tableName, string orderByCol, int pageSize,
            string where, object param)
        {
            string sql = "SELECT TOP {0} {1} FROM {2}";
            sql = string.Format(sql, pageSize, columns, tableName);
            if (!string.IsNullOrEmpty(where))
            {
                sql += " WHERE " + where;
            }
            if (!string.IsNullOrEmpty(orderByCol))
            {
                sql += " ORDER BY " + orderByCol;
            }
            using (IDbConnection conn = GetConnection)
            {
                //return conn.Query<T>(sql, param).ToList();
                var list = conn.Query<T>(sql, param).ToList();
                if (list == null)
                    return new List<T>();
                return list;
            }
        }
        #endregion
    }
     class TransactedConnection : IDbConnection
    {
        IDbConnection _conn;
        IDbTransaction _tran;

        public TransactedConnection(IDbConnection conn, IDbTransaction tran)
        {
            _conn = conn;
            _tran = tran;
        }

        public string ConnectionString { get { return _conn.ConnectionString; } set { _conn.ConnectionString = value; } }
        public int ConnectionTimeout { get { return _conn.ConnectionTimeout; } }
        public string Database { get { return _conn.Database; } }
        public ConnectionState State { get { return _conn.State; } }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction()
        {
            return _tran;
        }

        public void ChangeDatabase(string databaseName)
        {
            _conn.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            _conn.Close();
        }

        public IDbCommand CreateCommand()
        {
            // The command inherits the "current" transaction.
            var command = _conn.CreateCommand();
            command.Transaction = _tran;
            return command;
        }

        public void Dispose()
        {
            _conn.Dispose();
        }

        public void Open()
        {
            _conn.Open();
        }
    }
}
