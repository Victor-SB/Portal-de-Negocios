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

        public DbSet<PortalDeNegocios.Models.Department> Department { get; set; }
    }
}
