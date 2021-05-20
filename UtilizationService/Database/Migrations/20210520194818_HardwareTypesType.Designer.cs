﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UtilizationService.Database;

namespace UtilizationService.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210520194818_HardwareTypesType")]
    partial class HardwareTypesType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("UtilizationService.Entities.HardwareType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Identifier")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HardwareTypes");
                });

            modelBuilder.Entity("UtilizationService.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("HardwareTypeId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HardwareTypeId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("UtilizationService.Entities.Record", b =>
                {
                    b.HasOne("UtilizationService.Entities.HardwareType", "HardwareType")
                        .WithMany()
                        .HasForeignKey("HardwareTypeId");

                    b.Navigation("HardwareType");
                });
#pragma warning restore 612, 618
        }
    }
}
