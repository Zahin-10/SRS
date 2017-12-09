using System.Collections.Generic;
using UMS.Entity;

namespace UMS.Data.Interfaces
{
    public interface ICategoryRepository: IRepository<Category>
    {
        bool Delete(int id);
        
        
    }
}
