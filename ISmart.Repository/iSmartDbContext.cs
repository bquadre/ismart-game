using iSmart.Core;
using ISmart.Repository.Configurations;
using ISmart.Repository.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISmart.Repository
{
    public class iSmartDbContext : DbContext
    {
        public iSmartDbContext(DbContextOptions<iSmartDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new GameConfig(modelBuilder.Entity<Game>());

            ///seed
            ModelBuilderExtensions.Seed(modelBuilder);
        }
    }
}
