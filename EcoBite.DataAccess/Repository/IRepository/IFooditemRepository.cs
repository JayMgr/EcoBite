using EcoBiteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBiteBook.DataAccess.Repository.IRepository
{
    public interface IFooditemRepository : IRepository<Fooditem> 
    {
        void Update(Fooditem obj);
        
    }
}
