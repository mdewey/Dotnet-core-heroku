using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace heroku_test
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               var conn = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "server=localhost;database=heroku_test";
               optionsBuilder.UseNpgsql(conn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().HasData(
                new Items{Id = 1, Cool = "Yes I am", Something =" not something"},
                new Items{Id = 2, Cool = "Yes I am not", Something ="something"},
                new Items{Id = 3, Cool = "No I am", Something ="i am the best something"},
                new Items{Id = 4, Cool = "Nope, I am", Something =" meh?"}
            );


        }

        public DbSet<Items> Items { get; set; }
    }
}
