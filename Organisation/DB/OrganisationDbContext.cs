using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.DB
{
    public class OrganisationDbContext:DbContext
    {
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public OrganisationDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
