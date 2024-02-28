﻿using BLogic;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("api/Login/[controller]")]
    public class LoginController : Controller
    {
        BusinessLogic businessLogic;
        public LoginController()
        {
            BusinessLogic businessLogic = new BusinessLogic();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            try
            {
                bool success = businessLogic.Login(userName, password);
                return Ok(success);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
