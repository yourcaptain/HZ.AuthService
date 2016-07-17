using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    public class Auth : Controller
    {
        private static List<KeyValuePair<string, DateTime>> tokens;

        [HttpGet]
        public string GetToken()
        {
            string token = Guid.NewGuid().ToString();
            if (tokens == null)
                tokens = new List<KeyValuePair<string, DateTime>>();
            tokens.Add(new KeyValuePair<string, DateTime>(token, System.DateTime.Now));
            return token;
        }

        [HttpPost]
        public string ValidateToken(string token)
        {
            return "true";
        }
    }

}