using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public bool Delete(int Id)
        {
            //Fetching Item
            Category category = base.context.Category.SingleOrDefault(s => s.Id == Id);

            //Now deleting the entity
            base.context.Category.Remove(category);

            return base.context.SaveChanges() > 0;
        }
    }
}
