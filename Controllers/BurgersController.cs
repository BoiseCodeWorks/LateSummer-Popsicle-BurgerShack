using System;
using System.Collections.Generic;
using BurgerShack.Data;
using BurgerShack.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        private readonly BurgersRepository _repo;

        public BurgersController(BurgersRepository repo)
        {
        _repo =repo;    
        }

        [HttpGet]
        // TODO Come back to this
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(_repo.GetBurgers());
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        // STUB
        public ActionResult<Burger> Get(int id)
        {
            try
            {
                return Ok(_repo.GetById(id))
                
            }
            catch (Exception e)
            {
                
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        // STUB
        public ActionResult<Burger> Post([FromBody] Burger burger)
        {
            return null;
        }

        [HttpPut]
        // STUB 
        public ActionResult<Burger> Put([FromBody] Burger burger)
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