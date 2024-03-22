using BLogic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("api/User/[controller]")]
    public class UserController : Controller
    {
        BusinessLogic businessLogic;
        public UserController()
        {
            
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            BusinessLogic businessLogic = new BusinessLogic();
            try
            {
                return Ok(businessLogic.GetPerson(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person, int id)
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

        [HttpPut]
        public IActionResult Edit([FromBody] Person person, int id)
        {
            bool success = businessLogic.UpdatePerson(id, person);
            if (!success) { return Problem(); }
            return Ok();
        }

        [HttpDelete]
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

