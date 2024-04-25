using Microsoft.EntityFrameworkCore;
using PlacementTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Persistence.Context
{
    public class PlacementTestContext : DbContext
    {
        public PlacementTestContext(DbContextOptions<PlacementTestContext> options) : base(options)
        {
        }

        public DbSet<TestTakers> TestTakers { get; set; }
    }
}
