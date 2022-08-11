using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface IOrdersManager
    {
        public Task<long> insertCommonData(SPMS_Orders trans, IDbConnection db, IDbTransaction tran);
    }
}
