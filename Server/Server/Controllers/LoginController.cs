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
        IBaseService _baseservice;
        public LoginController(IBaseService baseservice)
        {
            _baseservice = baseservice;
        }


        [HttpPost]
        public string Post(string uname,string pwd)
        {
            var user =_baseservice.Query<UserModel>(u => u.UserName == uname && u.PassWord == pwd).ToList();
            return "Hello";
        }
    }
}
