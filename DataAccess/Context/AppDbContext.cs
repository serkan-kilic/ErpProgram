using DataAccess.Config;
using Entities.concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(AppConfig.ConnectionString);
        }
        public DbSet<category> categories { get; set; }
        public DbSet<item> itemmaster { get; set; }
        public DbSet<stockonhand> stockonhand { get; set; }
        public DbSet<customertype> customertype { get; set; }
        public DbSet<province> province { get; set; }
        public DbSet<district> district { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<orderline> orderline { get; set; }
        public DbSet<payment> payment { get; set; }
        public DbSet<orderstatus> orderstatus { get; set; }
        public DbSet<ordertype> ordertype { get; set; }
        public DbSet<orderstockreservation> orderstockreservation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<category>(e => e.ToTable("categories"));
            modelBuilder.Entity<item>(e => e.ToTable("itemmaster"));
            modelBuilder.Entity<stockonhand>(e => e.ToTable("stockonhand"));
            modelBuilder.Entity<customertype>(e => e.ToTable("customertype"));
            modelBuilder.Entity<province>(e => e.ToTable("province"));
            modelBuilder.Entity<district>(e => e.ToTable("district"));
            modelBuilder.Entity<customer>(e => e.ToTable("customers"));
            modelBuilder.Entity<order>(e => e.ToTable("orders"));
            modelBuilder.Entity<orderline>(e => e.ToTable("orderline"));
            modelBuilder.Entity<payment>(e => e.ToTable("payment"));
            modelBuilder.Entity<orderstatus>(e => e.ToTable("orderstatus"));
            modelBuilder.Entity<ordertype>(e => e.ToTable("ordertype"));
            modelBuilder.Entity<orderstockreservation>(e => e.ToTable("orderstockreservation"));

            modelBuilder.Entity<item>().HasQueryFilter(x => x.deleted != "d");
            modelBuilder.Entity<customer>().HasQueryFilter(x => x.deleted != "d");
            modelBuilder.Entity<order>().HasQueryFilter(x => x.deleted != "d");
            modelBuilder.Entity<orderline>().HasQueryFilter(x => x.deleted != "d");
            modelBuilder.Entity<stockonhand>().HasQueryFilter(x => x.deleted != "d");
            modelBuilder.Entity<orderstockreservation>().HasQueryFilter(x => x.deleted != "d");
        }
    }
}
