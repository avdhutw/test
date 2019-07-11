using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demochatboot.Models
{
    public class ChartbootsContext : DbContext
    {

        public virtual DbSet<Company> Company { get; set; }

        public ChartbootsContext()
        {

        }

        public ChartbootsContext(DbContextOptions<ChartbootsContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LENOVOG5080;Database=Demochatboots;Uid=avdhut;Pwd=12345;");
            }
        }

    }
}
