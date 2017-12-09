using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface IPackageDetailsRepository : IRepository<PackageDetails>
    {
        bool Delete(int id);
        IEnumerable<PackageDetails> GetAllbyPackageItem(int id);
        bool RemovePromo(PackageItem packageitem);
        bool AddPromo(PackageItem packageitem, int promoId);
    }
}
