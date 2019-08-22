using System.Collections.Generic;
using System.Data;
using BurgerShack.Models;

namespace BurgerShack.Data
{
    public class BurgersRepository{
        private readonly IDbConnection _db;
        
        public BurgersRepository(IDbConnection db){
            _db = db;
        }
        public IEnumerable<Burger> GetBurgers()
        {
          return null;
        }
        public Burger GetById(int id)
        {
            return null;
        }
        public Burger CreateBurger(Burger burger)
        {
            return null;
        }
        public Burger UpdateBurger()
        {

        }
    }
}