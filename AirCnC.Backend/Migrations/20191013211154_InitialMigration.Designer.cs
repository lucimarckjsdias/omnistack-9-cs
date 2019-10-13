﻿// <auto-generated />
using System;
using AirCnC.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirCnC.Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191013211154_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirCnC.Backend.Models.Booking", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SpotGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("SpotGuid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("AirCnC.Backend.Models.Spot", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Techs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Spots");
                });

            modelBuilder.Entity("AirCnC.Backend.Models.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AirCnC.Backend.Models.Booking", b =>
                {
                    b.HasOne("AirCnC.Backend.Models.Spot", "Spot")
                        .WithMany()
                        .HasForeignKey("SpotGuid");

                    b.HasOne("AirCnC.Backend.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserGuid");
                });

            modelBuilder.Entity("AirCnC.Backend.Models.Spot", b =>
                {
                    b.HasOne("AirCnC.Backend.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserGuid");
                });
#pragma warning restore 612, 618
        }
    }
}
