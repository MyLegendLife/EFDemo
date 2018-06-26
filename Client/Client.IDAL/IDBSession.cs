using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Client.IDAL
{
    public partial interface IDBSession
    {
        DbContext Db { get; }
        bool SaveChanges();
        int ExecuteSql(string sql, params SqlParameter[] pars);
        List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars);
    }
}
