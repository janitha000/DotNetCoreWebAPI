﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace webapi.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20171007125522_First migration")]
    partial class Firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CarBrand", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.HasKey("Name");

                    b.ToTable("CarBrand");
                });

            modelBuilder.Entity("CarType", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyType");

                    b.Property<string>("CarBrandName");

                    b.Property<string>("VehicleType")
                        .IsRequired();

                    b.HasKey("Name");

                    b.HasIndex("CarBrandName");

                    b.ToTable("CarType");
                });

            modelBuilder.Entity("CarType", b =>
                {
                    b.HasOne("CarBrand")
                        .WithMany("Types")
                        .HasForeignKey("CarBrandName");
                });
#pragma warning restore 612, 618
        }
    }
}
