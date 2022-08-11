using Dapper;
using OrisonSPMSAPI.Entities;
using OrisonSPMSAPI.Logics.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Concrete
{
    public class LoginManager:ILoginManager
    {
        private readonly IDapperManager _dapperManager;

        public LoginManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public async Task<loginModel> GetUserLoginDetails(string UserName, string Password)
        {
            var dbpara = new DynamicParameters();

            dbpara.Add("UserName", UserName, DbType.String);
            dbpara.Add("Password", Password, DbType.String);
            dbpara.Add("Criteria", "UserData", DbType.String);

            var userData = await Task.FromResult(_dapperManager.Get<loginModel>
            ("[SPMSLogin]", dbpara,
            commandType: CommandType.StoredProcedure));
            return userData;
        }

    }
}
