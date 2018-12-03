using GroomingSalonApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    public class SalonModel : DbContext
    {
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Service> Services { get; set; }

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
                entity.HasKey(e => e.EmailAddress)
                    .HasName("PK_CustomerId");

                entity.Property(e => e.EmailAddress)
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

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasKey(e => e.PetId)
                    .HasName("PK_PetId");

                entity.Property(e => e.PetId)
                    .ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_AppointmentId");

                entity.Property(e => e.AppointmentId)
                    .ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_ServiceId");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedOnAdd();

            });


        }

    }
}