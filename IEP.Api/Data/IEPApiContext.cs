using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEP.Core;

namespace IEP.Api.Data
{
    public class IEPApiContext : DbContext
    {
        public IEPApiContext (DbContextOptions<IEPApiContext> options)
            : base(options)
        {
        }

        public DbSet<IEP.Core.Department> Department { get; set; }

        public DbSet<IEP.Core.Jobs> Jobs { get; set; }
    }
}
