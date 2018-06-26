using Client.DAL;
using Client.IDAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace Client.DALFactory
{
    public partial class DBSession : IDBSession
    {
        public DbContext Db
        {
            get
            {
                return DBContextFactory.CreateDbContext();
            }
        }
        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }
        public int ExecuteSql(string sql, params SqlParameter[] pars)
        {
            return Db.Database.ExecuteSqlCommand(sql, pars);
        }
        public List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars)
        {
            return Db.Database.SqlQuery<T>(sql, pars).ToList();
        }
    }
}
