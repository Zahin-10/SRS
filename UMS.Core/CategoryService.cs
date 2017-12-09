using System;
using System.Collections.Generic;
using UMS.Core.Interfaces;
using UMS.Data.Interfaces;
using UMS.Entity;

namespace UMS.Core
{
    public class CategoryService : DomainService<Category>, ICategoryService
    {
        public bool Delete(int id)
        {
            return ((ICategoryRepository)base.repository).Delete(id);
        }


    }
}
