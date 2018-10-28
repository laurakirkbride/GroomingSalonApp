﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroomingSalonApp.Migrations
{
    [DbContext(typeof(SalonModel))]
    [Migration("20181028043015_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroomingSalonApp.CustomerAccount", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CustomerFN")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CustomerLN");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zip");

                    b.HasKey("CustomerId")
                        .HasName("PK_CustomerId");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("GroomingSalonApp.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DatePaid");

                    b.Property<int>("PetId");

                    b.Property<int>("ServiceId");

                    b.Property<double>("ServicePrice");

                    b.HasKey("TransactionId")
                        .HasName("PK_Transactions");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}