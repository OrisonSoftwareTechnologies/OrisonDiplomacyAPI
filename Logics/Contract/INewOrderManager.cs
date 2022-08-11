using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
   public interface INewOrderManager
    {
        public Task<long> SaveCartToOrder(NewCartToOrder wlt);
    }
}
