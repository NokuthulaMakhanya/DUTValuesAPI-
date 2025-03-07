﻿// <auto-generated />
using DUT_Values.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DUT_Values.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240612184727_SeedDUTValues")]
    partial class SeedDUTValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DUT_Values.Models.DUTValue", b =>
                {
                    b.Property<int>("DUTValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DUTValueId"));

                    b.Property<string>("DUTValueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DUTValueId");

                    b.ToTable("DUTValues");

                    b.HasData(
                        new
                        {
                            DUTValueId = 1,
                            DUTValueName = "Transparency"
                        },
                        new
                        {
                            DUTValueId = 2,
                            DUTValueName = "Honesty"
                        },
                        new
                        {
                            DUTValueId = 3,
                            DUTValueName = "Integrity"
                        },
                        new
                        {
                            DUTValueId = 4,
                            DUTValueName = "Respect"
                        },
                        new
                        {
                            DUTValueId = 5,
                            DUTValueName = "Accountability"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
