using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using OrisonSPMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly OrisonSystemALZAMREEQContext _context;
        private IWebHostEnvironment _environment;
        private IOrdersManager _repository;
        private INewOrderManager _crepository;
        public OrdersController(OrisonSystemALZAMREEQContext context, IWebHostEnvironment environment, IOrdersManager repository,INewOrderManager crepository)
        {
            _environment = environment;
            _context = context;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _crepository = crepository;
        }

        [HttpPost("SaveCartToOrder")]
        public async Task<HttpResponseMessage> SaveCartToOrder(NewCartToOrder value)
        {
            await _crepository.SaveCartToOrder(value);
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = (System.Net.HttpStatusCode)1;
            return msg;
        }
    }
}
