using GroomingSalonApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSep18
{
    class SalonModel : DbContext
    {
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GroomingSalon;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAccount>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_CustomerId");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerFN)
                    .IsRequired()
                    .HasMaxLength(50);

            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_Transactions");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedOnAdd();

            });

        }

    }
}