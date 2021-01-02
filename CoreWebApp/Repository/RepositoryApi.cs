using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Repository
{
    public class RepositoryApi : IRepository
    {
        CoreWebAppDbContext db;
        public RepositoryApi(CoreWebAppDbContext _db)
        {
            db = _db;
        }
    }
}
