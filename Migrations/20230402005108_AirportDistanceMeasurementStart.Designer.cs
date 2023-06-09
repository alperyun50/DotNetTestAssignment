﻿// <auto-generated />
using DotNetTestAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetTestAssignment.Migrations
{
    [DbContext(typeof(DbContexts))]
    [Migration("20230402005108_AirportDistanceMeasurementStart")]
    partial class AirportDistanceMeasurementStart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetTestAssignment.Models.AirportDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hubs")
                        .HasColumnType("int");

                    b.Property<string>("Iata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("TimezoneRegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirportDetails");
                });

            modelBuilder.Entity("DotNetTestAssignment.Models.AirportDetail", b =>
                {
                    b.OwnsOne("DotNetTestAssignment.Models.Location", "Location", b1 =>
                        {
                            b1.Property<int>("AirportDetailId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("lat")
                                .HasColumnType("float");

                            b1.Property<double>("lon")
                                .HasColumnType("float");

                            b1.HasKey("AirportDetailId");

                            b1.ToTable("AirportDetails");

                            b1.WithOwner()
                                .HasForeignKey("AirportDetailId");
                        });

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
