using System.Collections.Generic;
using System.Runtime.InteropServices;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface ICategoryService: IDomainService<Category>
    {
        bool Delete(int id);
        
    }
}
