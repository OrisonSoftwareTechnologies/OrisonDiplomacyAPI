using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using OrisonSPMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterController : ControllerBase
    {
        private readonly OrisonSystemALZAMREEQContext _context;
        private IWebHostEnvironment _environment;
        private IItemMasterManager _repository;
        public ItemMasterController(OrisonSystemALZAMREEQContext context, IWebHostEnvironment environment, IItemMasterManager repository)
        {
            _environment = environment;
            _context = context;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        [HttpGet]
        [Route("ParentItems")]
        public async Task<List<DtItemMaster>> GetBalance()
        {
            return await _repository.GetItems();
        }
        //[Route("GetItemsById/{id}")]
        [HttpGet]
        [Route("GetItemsById/{ID}")]
        public async Task<List<DtItemMaster>> GetItemsByID(int ID)
        {
            return await _repository.GetItemsByID(ID);
        }

        [HttpPost("SaveItem")]
        public async void Save([FromBody] DtItemMaster Item)
        {
            if (ModelState.IsValid)
                _repository.Save(Item);
        }
        [HttpPost("UpdateItem")]
        public async void Updateitems([FromBody] DtItemMaster Item)
        {
            if (ModelState.IsValid)
                _repository.Update(Item);
        }
        [HttpGet(nameof(GetMaxItemCode))]
        public async Task<int> GetMaxItemCode(int ID)
        {
            return await _repository.GetMaxItemCode(ID);
        }
        [HttpGet(nameof(MiscImagePath))]
        public async Task<string> MiscImagePath()
        {
            return await _repository.MiscImagePath();
        }
        [HttpGet(nameof(MiscImageUrl))]
        public async Task<string> MiscImageUrl()
        {
            return await _repository.MiscImageUrl();
        }

        [HttpGet]
        [Route("getCombos")]
        public async Task<List<dtMastermisc>> getCombos()
        {
            return await _repository.getCombos();
        }

        [HttpGet]
        [Route("getComboStaff")]
        public async Task<List<dtAccounts>> getComboStaff()
        {
            return await _repository.getComboStaff();
        }
        [HttpGet]
        [Route("getComboDepartment")]
        public async Task<List<dtMastermisc>> getComboDeparment()
        {
            return await _repository.getComboDepartment();
        }
        [HttpGet]
        [Route("getComboJob")]
        public async Task<List<dtVoucher>> getComboJob()
        {
            return await _repository.getComboJob();
        }
        [HttpPost("SaveOrderItem")]
        public async void SaveOrder([FromBody]List<SPMS_Ordering> AddOrder)
        {
            if (ModelState.IsValid)
                _repository.SaveOrder(AddOrder);
        }
        [HttpGet]
        [Route("GetOrders")]
        public async Task<List<SPMS_Orders>> GetOrders()
        {
            return await _repository.GetOrders();
        }
        [HttpGet]
        [Route("GetOrdersChild")]
        public async Task<List<SPMS_OrdersChildGrid>> GetOrdersChild()
        {
            return await _repository.GetOrdersChild();
        }
        [HttpGet(nameof(GetMaxOrderNo))]
        public async Task<string> GetMaxOrderNo()
        {
            return await _repository.GetMaxOrderNo();
        }
        [HttpPost("UpdateOrder")]
        public async void UpdateOrder([FromBody] SPMS_Ordering orditem)
        {
            if (ModelState.IsValid)
                _repository.UpdateOrder(orditem);
        }


        [HttpPost("DeleteItem")]
        public async void deleteitems([FromBody] int Item)
        {
            if (ModelState.IsValid)
                _repository.deleteitems(Item);
        }
    }

    
}


