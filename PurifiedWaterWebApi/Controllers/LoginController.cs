using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PurifiedWaterWebApi.BLL.Contract;

namespace PurifiedWaterWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IAccountService _accountService;
        public LoginController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("GetUsuarios")]
        public string GetUsuarios()
        {
            #region GetUsuario
            var usuarios = _accountService.GetUsuarios();
            return JsonConvert.SerializeObject(usuarios);
            #endregion
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
