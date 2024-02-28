using BLogic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace SwaggerRestAPIMotionsApp.Controllers
{
    [ApiController]
    [Route("api/User/[controller]")]
    public class UserController : Controller
    {
        BusinessLogic businessLogic;
        public UserController()
        {
            BusinessLogic businessLogic = new BusinessLogic();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            try
            {
                bool success = businessLogic.AddPerson(person);
                if (!success) { return Problem(); }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Edit([FromBody] Person person, int id)
        {
            bool success = businessLogic.UpdatePerson(id, person);
            if (!success) { return Problem(); }
            return Ok();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                bool success = businessLogic.DeletePerson(id);
                if (!success) { return Problem(); }
                return Ok();
            }
            catch
            {
                return View();
            }
        }
    }
}

