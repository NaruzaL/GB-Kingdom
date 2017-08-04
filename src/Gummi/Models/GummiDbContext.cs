using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Gummi.Models
{
    public class GummiDbContext : DbContext
    {
        public GummiDbContext()
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder Options)
        {
            Options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKindgdom;integrated security=True");
        }
        public GummiDbContext(DbContextOptions<GummiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
