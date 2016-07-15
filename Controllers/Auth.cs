using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class Auth : Controller
    {
        [HttpGet]
        public string GetToken()
        {
            return "ABCDEFG";
        }

    }

}