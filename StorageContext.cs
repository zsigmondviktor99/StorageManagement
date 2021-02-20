using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raktar
{
    class StorageContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Type> Types { get; set; }

        public StorageContext()
        {

        }

        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StorageDb");
        }
    }
}
