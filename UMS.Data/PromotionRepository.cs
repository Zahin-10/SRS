using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class PromotionRepository : Repository<Promotion>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            Promotion promotion = base.context.Promotion.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.Promotion.Remove(promotion);

            return base.context.SaveChanges()>0;
        }

        


    }
}
