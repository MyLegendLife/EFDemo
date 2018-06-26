using Client.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Client.DAL
{
    public class DBContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new ClientEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
