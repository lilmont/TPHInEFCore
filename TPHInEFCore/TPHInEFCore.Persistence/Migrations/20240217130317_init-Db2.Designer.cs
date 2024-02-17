﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPHInEFCore.Persistence.Context;

#nullable disable

namespace TPHInEFCore.Persistence.Migrations
{
    [DbContext(typeof(TphEfCoreDbContext))]
    [Migration("20240217130317_init-Db2")]
    partial class initDb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TPHInEFCore.Persistence.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TPHInEFCore.Persistence.Entities.Developer", b =>
                {
                    b.HasBaseType("TPHInEFCore.Persistence.Entities.Employee");

                    b.Property<string>("ProgrammingLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Developer");
                });

            modelBuilder.Entity("TPHInEFCore.Persistence.Entities.Manager", b =>
                {
                    b.HasBaseType("TPHInEFCore.Persistence.Entities.Employee");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("TPHInEFCore.Persistence.Entities.TechnicalLead", b =>
                {
                    b.HasBaseType("TPHInEFCore.Persistence.Entities.Developer");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TechnicalLead");
                });
#pragma warning restore 612, 618
        }
    }
}
