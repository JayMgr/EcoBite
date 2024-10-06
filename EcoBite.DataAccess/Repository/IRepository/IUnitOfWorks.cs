using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBiteBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWorks
    {
        IFooditemRepository Fooditem { get; }

        void Save();
    }
}
