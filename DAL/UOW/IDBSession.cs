using System.Data;

namespace DAL.UOW
{
    public interface IDBSession
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; set; }
    }
}