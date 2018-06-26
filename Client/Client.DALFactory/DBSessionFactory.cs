using System.Runtime.Remoting.Messaging;

namespace Client.DALFactory
{
    public class DBSessionFactory
    {
        public static IDAL.IDBSession CreateDBSession()
        {
            IDAL.IDBSession DbSession = (IDAL.IDBSession)CallContext.GetData("dbSession");
            if (DbSession == null)
            {
                DbSession = new DALFactory.DBSession();
                CallContext.SetData("dbSession", DbSession);
            }
            return DbSession;
        }
    }
}
