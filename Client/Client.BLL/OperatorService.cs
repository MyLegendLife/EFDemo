using Client.DALFactory;
using Client.IBLL;
using Client.Model;
using Client.Model.Sys;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace Client.BLL
{

    public partial class OperatorService : BaseService<Operator>, IOperatorService
    {

        public DataTable SqlQueryForDataTatable(Database database, string sql)
        {

            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = database.Connection.ConnectionString;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            conn.Close();//连接需要关闭  
            conn.Dispose();
            return table;
        }
    }
}
