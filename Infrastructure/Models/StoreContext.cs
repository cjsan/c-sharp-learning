using System;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
