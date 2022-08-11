using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface IItemMasterManager
    {
        Task<List<DtItemMaster>> GetItems();
        Task<List<DtItemMaster>> GetItemsByID(int Id);
        public bool Save(DtItemMaster Item);
        public bool Update(DtItemMaster Item);
        Task<int>GetMaxItemCode(int ID);
        Task<string> MiscImagePath();
        Task<string> MiscImageUrl();
        Task<List<dtMastermisc>> getCombos();
        Task<List<dtAccounts>> getComboStaff();
        Task<List<dtMastermisc>> getComboDepartment();
        Task<List<dtVoucher>> getComboJob();
        public bool SaveOrder(List<SPMS_Ordering> AddOrder); 
        Task<List<SPMS_Orders>> GetOrders();
        Task<List<SPMS_OrdersChildGrid>> GetOrdersChild();
        Task<string>GetMaxOrderNo();
        public bool UpdateOrder(SPMS_Ordering orditem);
        public bool deleteitems(int Item);
    }
}
