using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEP.Api.Model.Entities;

namespace IEP.Api.Data
{
    public class IEPApiContext : DbContext
    {
        public IEPApiContext (DbContextOptions<IEPApiContext> options)
            : base(options)
        {
        }

        public DbSet<IEP.Api.Model.Entities.Client> Client { get; set; }

        public DbSet<IEP.Api.Model.Entities.Job> Job { get; set; }
    }
}
