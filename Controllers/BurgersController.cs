using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get(){
            
        }
    }
}