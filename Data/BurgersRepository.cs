using System.Data;

namespace BurgerShack.Data
{
    public class BurgersRepository{
        private readonly IDbConnection _db;
        
        public BurgersRepository(IDbConnection db){
            _db = db;
        }
    }
}