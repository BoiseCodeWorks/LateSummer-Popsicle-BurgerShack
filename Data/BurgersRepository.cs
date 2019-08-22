using System;
using System.Collections.Generic;
using System.Data;
using BurgerShack.Models;
using Dapper;

namespace BurgerShack.Data
{
    public class BurgersRepository{
        private readonly IDbConnection _db;
        
        public BurgersRepository(IDbConnection db){
            _db = db;
        }
        public IEnumerable<Burger> GetBurgers()
        {
          return _db.Query<Burger>("SELECT * FROM burgers;");
        }
        public Burger GetById(int id)
        {
            return _db.QueryFirstOrDefault<Burger>("SELECT * FROM burgers WHERE id = @id;", new {id});
        }
        public Burger CreateBurger(Burger burger)
        {
            return null;
        }
        public Burger UpdateBurger(Burger burger)
        {
            return null;
        }

        internal object RemoveBurger(int id)
        {
            throw new NotImplementedException();
        }
    }
}