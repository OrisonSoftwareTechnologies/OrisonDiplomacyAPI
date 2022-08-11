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
    public class OrderingCartManager:IOrderingCartManager
    {
        private readonly IDapperManager _dapperManager;

        public OrderingCartManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }


        public bool SaveCart(List<SPMS_OrderingCart> AddCart)
        {
            try
            {
                bool r = true;
                foreach (var cartitem in AddCart)
                {
                  
                    var dbParam = new DynamicParameters();

                    dbParam.Add("Criteria", "INSERT", DbType.String);
                    //dbParam.Add("@ID",cartitem.ID);
                    dbParam.Add("@OrderNo", cartitem.OrderNo);
                    dbParam.Add("@Date", cartitem.Date);
                    dbParam.Add("@Orientation", cartitem.Orientation);
                    dbParam.Add("@Qty", cartitem.Qty);
                    dbParam.Add("@JobNo", cartitem.JobNo);
                    dbParam.Add("@Department", cartitem.Department);
                    dbParam.Add("@Staff", cartitem.Staff);
                    dbParam.Add("@Status", cartitem.Status);
                    dbParam.Add("@CDate", cartitem.CDate);
                    //dbParam.Add("@MUser", cartitem.MUser);
                    dbParam.Add("@Mdate", cartitem.MDate);
                    dbParam.Add("@Remarks", cartitem.Remarks);
                    dbParam.Add("@CUser", cartitem.CUser);
                    dbParam.Add("@ItemID", cartitem.ItemID);
                    dbParam.Add("@IsActive", cartitem.IsActive);
                    dbParam.Add("@ItemName", cartitem.ItemName);
                    dbParam.Add("@ItemCode", cartitem.ItemCode);

                   // var result = Task.FromResult(_dapperManager.Insert<SPMS_OrderingCart>("insert into SPMS_OrderingCart(Orientation,Staff,Status,Qty,Date,Remarks,JobNo,MDate,CDate,CUser,ItemID,OrderNo,Department,IsActive,ItemName,ItemCode)values(@Orientation,@Staff,@Status,@Qty,@Date,@Remarks,@JobNo,@MDate,@CDate,@CUser,@ItemID,@OrderNo,@Department,@IsActive,@ItemName,@ItemCode)", dbParam, commandType: CommandType.Text));
                    
                     var result = Task.FromResult(_dapperManager.Insert<SPMS_OrderingCart>("[SPMSCart_SP]", dbParam,commandType: CommandType.StoredProcedure));

                   
                }
                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //public async Task<List<SPMS_OrderingCart>> GetCarts()
        //{
        //    var dbParam = new DynamicParameters();
        //    var Accounts = Task.FromResult(_dapperManager.GetAll<SPMS_OrderingCart>
        //                        ("SELECT * FROM SPMS_OrderingCart ORDER BY ID DESC", dbParam,
        //                        commandType: CommandType.Text));
        //    return await Accounts;
        //}

        public async Task<List<SPMS_OrderingCart>> GetCarts()
        {
            var dbParam = new DynamicParameters();
            dbParam.Add("criteria", "selectallcarts");
            var Accounts = Task.FromResult(_dapperManager.GetAll<SPMS_OrderingCart>
                                ("[SPMSCart_SP]", dbParam,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }




        //public async Task<string> GetMaxOrderNo()
        //{

        //    var dbParam = new DynamicParameters();
        //    var Accounts = Task.FromResult(_dapperManager.Get<string>
        //                        ("select Top 1 ISNULL(OrderNo,'1000') as OrderNo from SPMS_OrderingCart ORDER BY ID DESC", dbParam,
        //                        commandType: CommandType.Text));
        //    return await Accounts;
        //}
        public async Task<string> GetMaxOrderNo()
        {

            var dbParam = new DynamicParameters();
            dbParam.Add("criteria", "selectmaxorderno");
            var Accounts = Task.FromResult(_dapperManager.Get<string>
                                ("[SPMSCart_SP]", dbParam,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }

        //public void DeleteCartitem(SPMS_OrderingCart trans, IDbConnection db, IDbTransaction tran)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("ID", trans.ID, DbType.Int32);
        //    Task.FromResult(_dapperManager.Execute("DELETE FROM SPMS_OrderingCart where ID=@ID", dbPara, commandType: CommandType.Text));
        //}
        public void DeleteCartitem(SPMS_OrderingCart trans, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "deletecarts");
            dbPara.Add("ID", trans.ID, DbType.Int32);
            Task.FromResult(_dapperManager.Execute("[SPMSCart_SP]", dbPara, commandType: CommandType.StoredProcedure));
        }

    }
}
