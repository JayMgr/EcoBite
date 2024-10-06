using EcoBiteBook.DataAccess.Data;
using EcoBiteBook.DataAccess.Repository.IRepository;
using EcoBiteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBiteBook.DataAccess.Repository
{
    public class FooditemRepository : Repository<Fooditem> , IFooditemRepository
    {
        private ApplicationDbContext _db;
        public FooditemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
 
        public void Update(Fooditem obj)
        {
            _db.Fooditems.Update(obj);
        }

    }
}
