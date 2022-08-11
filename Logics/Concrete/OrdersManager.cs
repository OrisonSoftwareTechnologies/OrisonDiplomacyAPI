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
    public class OrdersManager:IOrdersManager
    {
        private readonly IDapperManager _dapperManager;

        public OrdersManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }



        public Task<long>insertCommonData(SPMS_Orders trans, IDbConnection db, IDbTransaction tran)
        {
            var dbpara = new DynamicParameters();

            dbpara.Add("OrderNo", trans.OrderNo, DbType.String);
            dbpara.Add("Date",trans.Date,DbType.DateTime);
            dbpara.Add("JobNo", trans.JobNo, DbType.String);

            dbpara.Add("Department", trans.Department, DbType.String);
            dbpara.Add("Staff", trans.Staff, DbType.String);
            dbpara.Add("Status", trans.Status, DbType.String);
            dbpara.Add("CDate", trans.CDate, DbType.DateTime);
            dbpara.Add("CUser", trans.CUser, DbType.Int32);
            dbpara.Add("MUser", trans.CUser, DbType.Int32);
            dbpara.Add("MDate", trans.MDate, DbType.DateTime);
            dbpara.Add("IsActive", trans.IsActive, DbType.Int32);


            
           dbpara.Add("Criteria", "Insert", DbType.String);
            dbpara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
      long newID = _dapperManager.Insert("[SPMS_OrdersSave]", dbpara, db, tran, commandType: CommandType.StoredProcedure);
         return Task.FromResult(newID);


         //   long newID = _dapperManager.Insert("insert into SPMS_Orders(OrderNo,Date,Department,Staff,Status,CDate,CUser,MDate,IsActive)values(@OrderNo,@Date,@Department,@Staff,@Status,@CDate,@CUser,@MDate,@IsActive)", dbpara, db, tran, commandType: CommandType.Text);
         //return Task.FromResult(newID);
         
        }


    }
}
