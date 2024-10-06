using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalDeNegocios.Models;

namespace PortalDeNegocios.Data
{
    public class PortalDeNegociosContext : DbContext
    {
        public PortalDeNegociosContext (DbContextOptions<PortalDeNegociosContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecord { get; set; }

    }
}
