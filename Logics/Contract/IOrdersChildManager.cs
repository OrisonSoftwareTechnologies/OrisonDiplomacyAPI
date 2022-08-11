using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface IOrdersChildManager
    {
        public Task<long> InsertNewOrderItems(SPMS_OrdersChild trans, IDbConnection db, IDbTransaction tran);
    }
}
