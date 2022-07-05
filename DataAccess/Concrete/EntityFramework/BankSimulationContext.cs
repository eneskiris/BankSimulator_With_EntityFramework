using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BankSimulationContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BankSimulation;Trusted_Connection=true");
        }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankBranch>().ToTable("BranchesOfBank");
            modelBuilder.Entity<BankBranch>().Property(p => p.BankBranchId).HasColumnName("Id");
            modelBuilder.Entity<BankBranch>().Property(p => p.BankBranchName).HasColumnName("Name");
        }

    }
}
