using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface IPackageItemRepository : IRepository<PackageItem>
    {
        bool Delete(int id);

        IEnumerable<PackageItem> GetAllWithPromo();
        bool RemovePromo(PackageItem packageitem);

        bool AddPromo(PackageItem packageitem, int promoId);
    }
}
