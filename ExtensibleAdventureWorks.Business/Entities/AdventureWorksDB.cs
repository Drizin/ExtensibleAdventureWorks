using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleAdventureWorks.Business.Entities
{
    partial class AdventureWorksDB
    {
        private static void AdventureWorksDBStaticPartial()
        {
        }

        #region CreateConnection
        /// <summary>
        /// Creates a raw SqlConnection to the database. This is NOT for using Entity Framework, but Dapper or raw ADO.NET.
        /// Don't forget to wrap your connection inside a "using" statement, to automatically close/dispose connection at end:
        /// using (var cn = GalileoDB.CreateConnection())
        /// {
        ///    ...
        /// }
        /// </summary>
        /// <returns></returns>
        public static System.Data.SqlClient.SqlConnection CreateConnection()
        {
            var cn = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            cn.Open();
            return cn;
        }
        #endregion

        #region Dapper Wrappers
        /// <summary>
        /// Execute parameterized SQL
        /// </summary>
        /// <returns>Number of rows affected</returns>
        public static int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var cn = CreateConnection())
            {
                cn.Open();
                return cn.Execute(sql, param, transaction, commandTimeout, commandType);
            }
        }
        /// <summary>
        ///  Executes a query, returning the data typed as per T
        /// </summary>
        /// <returns>
        /// A sequence of data of the supplied type; if a basic type (int, string, etc) is
        ///  queried then the data from the first column in assumed, otherwise an instance
        ///  is created per row, and a direct column-name===member-name mapping is assumed
        ///  (case insensitive).
        /// </returns>
        public static IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var cn = CreateConnection())
            {
                cn.Open();
                return cn.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
            }
        }

        #endregion


    }
}
