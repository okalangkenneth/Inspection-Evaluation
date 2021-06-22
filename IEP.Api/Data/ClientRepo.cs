using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEP.Api.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace IEP.Api.Data
{
    public class ClientRepo
    {
        private readonly IEPApiContext db;

        public ClientRepo(IEPApiContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Client>>GetAllAsync(bool includeJobs)
        {
            return includeJobs ? await db.Client
                                             .Include(e=> e.Inspectors)
                                             .Include(e=> e.Jobs)
                                             .Include(e=> e.Samples)
                                             .Include(e=>e.JobLocation)
                                             .ToListAsync():
                                 await db.Client
                                              .Include(e => e.Inspectors)
                                              .ToListAsync();
        }

        
    }
}
