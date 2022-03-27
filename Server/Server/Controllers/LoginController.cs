using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IBaseService _userservice;
        public LoginController(IUserService userservice)
        {
            _userservice = userservice;
        }


        [HttpPost]
        public string Post(string uname,string pwd)
        {
            var user = _userservice.Query<UserModel>(u => u.UserName == uname && u.PassWord == pwd).ToList();
            return "Hello";
        }
    }
}
