using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class PackageDetailsRepository : Repository<PackageDetails>
    {
        public bool Delete(int id)
        {
            //Fetching Item
            PackageDetails packagedetails = base.context.PackageDetails.SingleOrDefault(s => s.Id == id);
            

            //Now deleting the entity
            base.context.PackageDetails.Remove(packagedetails);

            return base.context.SaveChanges()>0;
        }

        public IEnumerable<PackageDetails> GetAllbyPackageItem(int id)
        {
            return base.context.PackageDetails.Include(s => s.packageid).Where(s=> s.packageid == id).ToList();
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
