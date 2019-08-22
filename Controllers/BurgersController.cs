using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        [HttpGet]
        // TODO Come back to this
        public ActionResult<IEnumerable<Burger>> Get()
        {
            return null;
        }

        [HttpGet("{id}")]
        // STUB
        public ActionResult<Burger> Get(int id)
        {
            return null;
        }

        [HttpPost]
        // STUB
        public ActionResult<Burger> Post([FromBody] Burger burger)
        {
            return null;
        }

        [HttpDelete("{id}")]
        // STUB
        public ActionResult<string> Delete(int id)
        {
            return null;
        }

    }
}