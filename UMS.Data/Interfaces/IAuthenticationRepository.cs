﻿using UMS.Entity;
using UMS.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace UMS.Data.Interfaces
{
    public interface IAuthenticationRepository : IRepository<Authentication>
    {
        bool Delete(string id);
    }
}
