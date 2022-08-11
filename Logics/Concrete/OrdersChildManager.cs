using Dapper;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Concrete
{
    public class OrdersChildManager:IOrdersChildManager
    {
        private readonly IDapperManager _dapperManager;

        public OrdersChildManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }
        public Task<long> InsertNewOrderItems(SPMS_OrdersChild trans, IDbConnection db, IDbTransaction tran)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("Oid", trans.Oid, DbType.Int32);
            dbPara.Add("ItemID", trans.ItemID, DbType.String);
                dbPara.Add("Qty", trans.Qty, DbType.String);
                 dbPara.Add("Orientation", trans.Orientation, DbType.String);
            dbPara.Add("ItemName", trans.ItemName, DbType.String);

            dbPara.Add("ItemCode", trans.ItemCode, DbType.String);
            dbPara.Add("Criteria", "Insert", DbType.String);
            dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
            long newID = _dapperManager.Insert("[SPMS_OrdersChildSave]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            return Task.FromResult(newID);

            //long newID= _dapperManager.Insert("insert into SPMS_OrdersChild(Oid,Qty,Orientation,ItemID)values(@Oid,@Qty,@Orientation,@ItemID);", dbPara, db, tran, commandType: CommandType.Text);
            //return Task.FromResult(newID);




        }
    }
}
