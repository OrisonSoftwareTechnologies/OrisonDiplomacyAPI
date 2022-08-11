using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface IDapperManager:IDisposable
    {
        DbConnection GetConnection();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType);
        int Execute(string sp, DynamicParameters parms, CommandType commandType);
        long Insert(string sp, DynamicParameters parms, IDbConnection db, IDbTransaction tran, CommandType commandType = CommandType.StoredProcedure);


        long InsertTable(string sp, DynamicParameters parms, CommandType commandType);
        void Insertvoid(string sp, DynamicParameters parms, CommandType commandType);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType);
        long Update(string v, DynamicParameters dbPara, CommandType commandType);
        long UpdateTable(string sp, DynamicParameters parms, IDbConnection db, IDbTransaction tran, CommandType commandType);
    }
}
