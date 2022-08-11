using OrisonSPMSAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Contract
{
    public interface ILoginManager
    {
        public Task<loginModel> GetUserLoginDetails(string Username, string Password);
    }
}
