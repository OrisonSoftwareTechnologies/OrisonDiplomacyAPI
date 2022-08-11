using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Concrete
{
    public class NewOrderManager:INewOrderManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;
        private readonly IOrdersManager _Mrepository;
        private readonly IOrdersChildManager _Drepository;
        private readonly IOrderingCartManager _Arepository;
        public NewOrderManager(IDapperManager dapperManager,IConfiguration config,IOrdersManager Mrepository,IOrdersChildManager Drepository,IOrderingCartManager Arepository)
        {
            this._dapperManager = dapperManager;
            _config = config;
            _Mrepository = Mrepository;
            _Drepository = Drepository;
            _Arepository = Arepository;
        }
    
        public async Task<long> SaveCartToOrder(NewCartToOrder wlt)
        {
            long newID;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                using var tran = db.BeginTransaction();
                try
                {

                   
                        SPMS_Orders ul = wlt.NewOrdersentry;
                        newID = await _Mrepository.insertCommonData(ul, db, tran);
                    
                        foreach (SPMS_OrdersChild dt in wlt.NewOrdersChildentry)
                        {
                            dt.Oid = Convert.ToInt32(newID);
                            await _Drepository.InsertNewOrderItems(dt, db, tran);
                       
                        }


                        foreach (SPMS_OrderingCart dt in wlt.DeleteOldCartitem)
                        {
                            _Arepository.DeleteCartitem(dt, db, tran);
                        }

                        tran.Commit();
                 
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
            return newID;
        }

        
    }
}
