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
    public class LoginController : ControllerBase
    {
        private readonly OrisonSystemALZAMREEQContext _context;
        private IWebHostEnvironment _environment;
        private ILoginManager _repository;
        public LoginController(OrisonSystemALZAMREEQContext context, IWebHostEnvironment environment, ILoginManager repository)
        {
            _environment = environment;
            _context = context;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        [Route("GetUser")]

        public async Task<loginModel> GetUserLogin(string UserName, string Password)
        {
            loginModel dt = new loginModel();
            dt = await _repository.GetUserLoginDetails(UserName, Password);

            if (dt == null)
            {
                dt = new loginModel();
            }

            return dt;

        }
    }
}
