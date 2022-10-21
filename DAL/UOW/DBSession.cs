using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UOW
{
    public class DBSession : IDisposable, IDBSession
    {
        public IDbConnection Connection { get; }

        public IDbTransaction Transaction { get; set; }

        public DBSession(IConfiguration configuration)
        {
            //chaîne de connection dans appsettings.json
            string chainDeConnection = configuration.GetConnectionString("ovh");

            //creat instance of connection
            Connection = new SqlConnection(chainDeConnection);

            //open connection
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
