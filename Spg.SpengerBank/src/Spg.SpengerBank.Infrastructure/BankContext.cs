using Bogus;
using Microsoft.EntityFrameworkCore;
using Spg.SpengerBank.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.Infrastructure
{
    public class BankContext : DbContext
    {
        public DbSet<Demo> Demos => Set<Demo>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Savings> Savings => Set<Savings>();

        public BankContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        { }

        // 4. Methoden ((OnConfiguring), OnModelCreating)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Address>().HasNoKey();
            builder.Entity<Customer>().OwnsOne(c => c.Address); 
            builder.Entity<Customer>().OwnsOne(c => c.RegistrationNumber);
            builder.Entity<Employee>().OwnsOne(c => c.RegistrationNumber);

            builder.Entity<Bank>().OwnsOne(c => c.RegistrationNumber);
            builder.Entity<Savings>().OwnsOne(c => c.RegistrationNumber);


        }
    }
}
