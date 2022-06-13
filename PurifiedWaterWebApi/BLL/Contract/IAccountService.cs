using PurifiedWaterWebApi.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurifiedWaterWebApi.BLL.Contract
{
    public interface IAccountService
    {
        Task<List<Usuario>> GetUsuarios();
    }
}
