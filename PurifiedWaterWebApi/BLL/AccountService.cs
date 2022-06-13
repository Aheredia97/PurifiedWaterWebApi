using Newtonsoft.Json;
using PurifiedWaterWebApi.BLL.Contract;
using PurifiedWaterWebApi.Context.Entities;
using PurifiedWaterWebApi.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurifiedWaterWebApi.BLL
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void Dispose()
        {
            if(_accountRepository != null)
            {
                _accountRepository.Dispose();
                _accountRepository = null;
            }
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            #region GetUsuarios
            return _accountRepository.GetAll<Usuario>();
            #endregion
        }
    }
}
