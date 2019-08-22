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
                return Ok(_repo.GetById(id));
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
            try
            {
                return Ok(_repo.CreateBurger(burger));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        // STUB 
        public ActionResult<Burger> Put([FromBody] Burger burger)
        {
            try
            {
                return Ok(_repo.UpdateBurger(burger));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        // STUB
        public ActionResult<string> Delete(int id)
        {
            try
            {
                return Ok(_repo.RemoveBurger(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}