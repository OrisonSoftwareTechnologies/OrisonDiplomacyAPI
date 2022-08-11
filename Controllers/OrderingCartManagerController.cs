using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using OrisonSPMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrisonSPMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingCartManagerController : ControllerBase
    {
        private readonly OrisonSystemALZAMREEQContext _context;
        private IWebHostEnvironment _environment;
        private IOrderingCartManager _repository;
        public OrderingCartManagerController(OrisonSystemALZAMREEQContext context, IWebHostEnvironment environment, IOrderingCartManager repository)
        {
            _environment = environment;
            _context = context;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpPost("SaveCartItem")]
        public async void SaveCart([FromBody] List<SPMS_OrderingCart> AddCart)
        {
            if (ModelState.IsValid)
                _repository.SaveCart(AddCart);
        }
        [HttpGet]
        [Route("GetCarts")]
        public async Task<List<SPMS_OrderingCart>> GetCarts()
        {
            return await _repository.GetCarts();
        }
        [HttpGet(nameof(GetMaxOrderNo))]
        public async Task<string> GetMaxOrderNo()
        {
            return await _repository.GetMaxOrderNo();
        }

    }
}
