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
    public class UnitOfWorks : IUnitOfWorks
    {

        private ApplicationDbContext _db;
        public IFooditemRepository Fooditem{ get; private set; }
        public UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;
            Fooditem = new FooditemRepository(_db);
        }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
