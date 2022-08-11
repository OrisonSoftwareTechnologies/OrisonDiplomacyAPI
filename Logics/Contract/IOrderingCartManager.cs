using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface IOrderingCartManager
    {
        public bool SaveCart(List<SPMS_OrderingCart> AddCart);
        Task<List<SPMS_OrderingCart>> GetCarts();
        Task<string> GetMaxOrderNo();
        public void DeleteCartitem(SPMS_OrderingCart trans, IDbConnection db, IDbTransaction tran);
    }
}
