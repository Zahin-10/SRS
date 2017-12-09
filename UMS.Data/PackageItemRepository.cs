using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class PackageItemRepository : Repository<PackageItem>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            PackageItem packageitem = base.context.PackageItem.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.PackageItem.Remove(packageitem);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<PackageItem> GetAllWithPromo()
        {
            return base.context.PackageItem.Include(s => s.Promotion).ToList();
        }

        

        public bool RemovePromo(PackageItem packageitem)
        {
            PackageItem packageitemToUpdate = base.context.PackageItem.SingleOrDefault(s => s.Id == packageitem.Id);
            packageitemToUpdate.promoId = null;
            base.context.Entry(packageitemToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }
        public bool AddPromo(PackageItem packageitem, int promoId)
        {
            PackageItem packageitemToUpdate = base.context.PackageItem.SingleOrDefault(s => s.Id == packageitem.Id);
            packageitemToUpdate.promoId = promoId;
            base.context.Entry(packageitemToUpdate).State = EntityState.Modified;

            return base.context.SaveChanges() > 0;
        }





    }
}
