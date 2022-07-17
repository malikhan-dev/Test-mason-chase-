using Mc2.CrudTest.Acceptance.Domain.Customers;
using Mc2.CrudTest.Acceptance.Persistance.Ef.Config;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.Context
{
    public class AcceptanceContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-SQ187L3\MSSQLSERVER2019;Integrated Security=true;initial catalog=AcceptanceTest");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
