using Dapper;
using OrisonSPMSAPI.Logics.Contract;
using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Concrete
{
    public class ItemMasterManager : IItemMasterManager
    {
        string[] aa;
        private readonly IDapperManager _dapperManager;

        public ItemMasterManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }
     
        public async Task<List<DtItemMaster>> GetItems()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "selectallspmsitems");
            var Accounts = Task.FromResult(_dapperManager.GetAll<DtItemMaster>
                                ("[SPMS_SelectData]", dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }

        public async Task<List<DtItemMaster>> GetItemsByID(int Id)
        {
            var dbPara = new DynamicParameters();
            var Accounts = Task.FromResult(_dapperManager.GetAll<DtItemMaster>
                                ("SELECT ID, ItemID,ItemCode,ItemName,ItemNameAr,Type,Parent,FileName,Path FROM SPMS_ItemMaster where parent="+Id+" and IsActive=1", dbPara,
                                commandType: CommandType.Text));
            return await Accounts;
        }
       
        public bool Save(DtItemMaster Item)
        {
            DynamicParameters dbPara = SetParameters(Item);
            dbPara.Add("criteria", "INSERT");
            var result = Task.FromResult(_dapperManager.Insert<DtItemMaster>("[SPMSItemMasterSP]", dbPara,
                commandType: CommandType.StoredProcedure));
            if (result.IsCompletedSuccessfully)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     

        public bool Update(DtItemMaster Item)
        {
            DynamicParameters dbPara = SetParameters(Item);
            dbPara.Add("criteria", "UPDATE");
            var result = Task.FromResult(_dapperManager.Insert<DtItemMaster>("[SPMSItemMasterSP]", dbPara,
                commandType: CommandType.StoredProcedure));
            if (result.IsCompletedSuccessfully)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DynamicParameters SetParameters(DtItemMaster Item)
        {
            DynamicParameters dbPara = new DynamicParameters();
            dbPara.Add("@ID", Item.ID);
            dbPara.Add("@ItemCode", Item.ItemCode);
            dbPara.Add("@ItemID", Item.ItemID);
            dbPara.Add("@ItemName", Item.ItemName);
            dbPara.Add("@ItemNameAr", Item.ItemNameAr);
            dbPara.Add("@Path", Item.Path);
            dbPara.Add("@Parent", Item.Parent);
            dbPara.Add("@Type", Item.Type);
            dbPara.Add("@FileName", Item.FileName);
            dbPara.Add("@IsActive", Item.IsActive);
            return dbPara;

        }


        public async Task<int> GetMaxItemCode(int ID)
        {
            if (ID == 0)
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("criteria", "parentgetmaxitemcode");
                var Accounts = Task.FromResult(_dapperManager.Get<int>
                                    ("[SPMS_SelectData]", dbPara,
                                    commandType: CommandType.StoredProcedure));
                return await Accounts;
            }
            else
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("criteria", "childgetmaxitemcode");
                var Accounts = Task.FromResult(_dapperManager.Get<int>
                                    ("[SPMS_SelectData]", dbPara,
                                    commandType: CommandType.StoredProcedure));
                return await Accounts;
            }
        }


        public async Task<string> MiscImagePath()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "selectspmsimagepath");
            var data = Task.FromResult(_dapperManager.Get<string>
                                         ("[SPMS_SelectData]", dbPara,
                                         commandType: CommandType.StoredProcedure));
            return await data;


        }

        public async Task<string> MiscImageUrl()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "selectspmsimageurl");
            var data = Task.FromResult(_dapperManager.Get<string>
                                         ("[SPMS_SelectData]", dbPara,
                                         commandType: CommandType.StoredProcedure));
            return await data;
        }





        private DynamicParameters SetParameter(dtMastermisc myimage)
        {
            DynamicParameters dbP = new DynamicParameters();
            dbP.Add("@Source", myimage.ID);
            dbP.Add("@Description", myimage.ID);
            return dbP;

        }

      

        public async Task<List<dtMastermisc>> getCombos()
        {

            var dbP = new DynamicParameters();
            dbP.Add("criteria", "selectcombostatus");
            var status = Task.FromResult(_dapperManager.GetAll<dtMastermisc>
                                ("[SPMS_CartOrderCombodata]", dbP,
                                commandType: CommandType.StoredProcedure));
            return await status;
        }
      
        public async Task<List<dtAccounts>> getComboStaff()
        {

            var dbP = new DynamicParameters();
            dbP.Add("criteria", "selectcombostaffs");
            var status = Task.FromResult(_dapperManager.GetAll<dtAccounts>
                                ("[SPMS_CartOrderCombodata]", dbP,
                                commandType: CommandType.StoredProcedure));
            return await status;
        }

       
        public async Task<List<dtMastermisc>> getComboDepartment()
        {

            var dbP = new DynamicParameters();
            dbP.Add("criteria", "selectcombodepartment");
            var status = Task.FromResult(_dapperManager.GetAll<dtMastermisc>
                                ("[SPMS_CartOrderCombodata]", dbP,
                                commandType: CommandType.StoredProcedure));
            return await status;
        }


        private DynamicParameters SetParameters(SPMS_Ordering orderitem)
        {
            DynamicParameters dbParam = new DynamicParameters();
            dbParam.Add("@ID", orderitem.ID);
            dbParam.Add("@OrderNo", orderitem.OrderNo);
            dbParam.Add("@Date", orderitem.Date);
            dbParam.Add("@Orientation", orderitem.Orientation);
            dbParam.Add("@Qty", orderitem.Qty);
            dbParam.Add("@JobNo", orderitem.JobNo);
            dbParam.Add("@Department", orderitem.Department);
            dbParam.Add("@Staff", orderitem.Staff);
            dbParam.Add("@Status", orderitem.Status);
            dbParam.Add("@CDate", orderitem.CDate);
            dbParam.Add("@MUser", orderitem.MUser);
            dbParam.Add("@Mdate", orderitem.MDate);
            dbParam.Add("@Remarks", orderitem.Remarks);
            dbParam.Add("@CUser", orderitem.CUser);
            dbParam.Add("@ItemID", orderitem.ItemID);
            dbParam.Add("@IsActive", orderitem.IsActive);
            return dbParam;

        }


      
        public async Task<List<dtVoucher>> getComboJob()
        {

            var dbP = new DynamicParameters();
            dbP.Add("criteria", "selectcombojobNo");
            var status = Task.FromResult(_dapperManager.GetAll<dtVoucher>
                                ("[SPMS_CartOrderCombodata]", dbP,
                                commandType: CommandType.StoredProcedure));
            return await status;
        }

        public bool SaveOrder(List<SPMS_Ordering> AddOrder)
        {
         try { 
            bool r=true;
            foreach (var orderitem in AddOrder)
            {
                DynamicParameters dbParam = SetParameters(orderitem);


            var result= Task.FromResult(_dapperManager.Insert<SPMS_Ordering>("insert into SPMS_Ordering(Orientation,Staff,Status,Qty,Date,Remarks,JobNo,MDate,CDate,OrderNo,CUser,ItemID,IsActive)values(@Orientation,@Staff,@Status,@Qty,@Date,@Remarks,@JobNo,@MDate,@CDate,@OrderNo,@CUser,@ItemID,@IsActive)", dbParam,
                    commandType: CommandType.Text));

            }
            return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }

}



        public async Task<List<SPMS_Orders>> GetOrders()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "selectallorders");
            var Accounts = Task.FromResult(_dapperManager.GetAll<SPMS_Orders>
                                ("[SPMS_SelectData]", dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }

        public async Task<List<SPMS_OrdersChildGrid>> GetOrdersChild()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("criteria", "selectallchildorders");
            var Accounts = Task.FromResult(_dapperManager.GetAll<SPMS_OrdersChildGrid>
                                ("[SPMS_SelectData]", dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }


        public async Task<string> GetMaxOrderNo()
        {

            var dbParam = new DynamicParameters();
            dbParam.Add("criteria", "selectmaxorderno");
            var Accounts = Task.FromResult(_dapperManager.Get<string>
                                ("[SPMS_SelectData]", dbParam,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }

        public bool UpdateOrder(SPMS_Ordering orditem)
        {
            DynamicParameters dbParam= SetParameters(orditem);
            var result = Task.FromResult(_dapperManager.Insert<SPMS_Ordering>("update SPMS_Ordering set Orientation=@Orientation,Staff=@Staff,Status=@Status,Qty=@Qty,Date=@Date,Remarks=@Remarks,JobNo=@JobNo,MDate=@Mdate,OrderNo=@OrderNo,CUser=@CUser,MUser=@Muser where ID=@ID", dbParam,
                commandType: CommandType.Text));
            if (result.IsCompletedSuccessfully)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool deleteitems(int Item)
        //{
        //    //DynamicParameters dbPara = SetParameters( Item);
        //    var result = Task.FromResult(_dapperManager.Insert<DtItemMaster>("update SPMS_ItemMaster set IsActive=0 where ID="+Item, null,
        //        commandType: CommandType.Text)) ;

        //    if (result.IsCompletedSuccessfully)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public bool deleteitems(int Item)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Item, DbType.Int32);
            dbPara.Add("criteria", "DELETE");
            var result = Task.FromResult(_dapperManager.Insert<DtItemMaster>("[SPMSItemMasterSP]", dbPara,
                commandType: CommandType.StoredProcedure));

            if (result.IsCompletedSuccessfully)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
