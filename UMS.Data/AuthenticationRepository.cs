using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data
{
    public class AuthenticationRepository : Repository<Authentication>
    {
        public bool Delete(string id)
        {
            //Fetching Item
            Authentication authentication = base.context.Authentication.SingleOrDefault(s => s.Username == id);
            

            //Now deleting the entity
            base.context.Authentication.Remove(authentication);

            return base.context.SaveChanges()>0;
        }

        


    }
}
