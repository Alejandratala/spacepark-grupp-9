﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceParkModel.Database;

namespace SpaceParkModel.Migrations
{
    [DbContext(typeof(SpaceParkContext))]
    partial class SpaceParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpaceParkModel.Database.Occupancy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParkingSpotID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<int>("SpaceshipID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Occupancies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArrivalTime = new DateTime(2021, 3, 22, 18, 26, 53, 649, DateTimeKind.Unspecified).AddTicks(1508),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 8, 0, 370, DateTimeKind.Unspecified).AddTicks(1198),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 2
                        },
                        new
                        {
                            ID = 2,
                            ArrivalTime = new DateTime(2021, 3, 22, 19, 25, 37, 861, DateTimeKind.Unspecified).AddTicks(3124),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 35, 9, 153, DateTimeKind.Unspecified).AddTicks(2960),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 2
                        },
                        new
                        {
                            ID = 3,
                            ArrivalTime = new DateTime(2021, 3, 22, 19, 35, 45, 711, DateTimeKind.Unspecified).AddTicks(9285),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 38, 27, 669, DateTimeKind.Unspecified).AddTicks(1688),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 4,
                            ArrivalTime = new DateTime(2021, 3, 22, 19, 39, 23, 343, DateTimeKind.Unspecified).AddTicks(3465),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 39, 27, 365, DateTimeKind.Unspecified).AddTicks(8201),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 5,
                            ArrivalTime = new DateTime(2021, 3, 22, 19, 39, 46, 359, DateTimeKind.Unspecified).AddTicks(6936),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 40, 6, 198, DateTimeKind.Unspecified).AddTicks(9431),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 6,
                            ArrivalTime = new DateTime(2021, 3, 22, 19, 41, 28, 504, DateTimeKind.Unspecified).AddTicks(2097),
                            DepartureTime = new DateTime(2021, 3, 22, 19, 41, 30, 457, DateTimeKind.Unspecified).AddTicks(3860),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 7,
                            ArrivalTime = new DateTime(2021, 3, 23, 11, 42, 13, 452, DateTimeKind.Unspecified).AddTicks(6063),
                            DepartureTime = new DateTime(2021, 3, 23, 11, 42, 58, 902, DateTimeKind.Unspecified).AddTicks(6162),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 8,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 15, 59, 46, DateTimeKind.Unspecified).AddTicks(1350),
                            DepartureTime = new DateTime(2021, 3, 24, 12, 16, 12, 736, DateTimeKind.Unspecified).AddTicks(1570),
                            ParkingSpotID = 1,
                            PersonID = 2,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 9,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 17, 55, 996, DateTimeKind.Unspecified).AddTicks(8849),
                            DepartureTime = new DateTime(2021, 3, 24, 12, 18, 2, 489, DateTimeKind.Unspecified).AddTicks(5235),
                            ParkingSpotID = 1,
                            PersonID = 2,
                            SpaceshipID = 3
                        },
                        new
                        {
                            ID = 11,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 22, 24, 582, DateTimeKind.Unspecified).AddTicks(8001),
                            DepartureTime = new DateTime(2021, 3, 24, 14, 43, 18, 801, DateTimeKind.Unspecified).AddTicks(4517),
                            ParkingSpotID = 4,
                            PersonID = 1,
                            SpaceshipID = 5
                        },
                        new
                        {
                            ID = 12,
                            ArrivalTime = new DateTime(2021, 3, 25, 10, 1, 58, 653, DateTimeKind.Unspecified).AddTicks(3626),
                            ParkingSpotID = 2,
                            PersonID = 1,
                            SpaceshipID = 4
                        },
                        new
                        {
                            ID = 13,
                            ArrivalTime = new DateTime(2021, 3, 25, 10, 59, 56, 40, DateTimeKind.Unspecified).AddTicks(3378),
                            DepartureTime = new DateTime(2021, 3, 25, 11, 0, 7, 53, DateTimeKind.Unspecified).AddTicks(8153),
                            ParkingSpotID = 1,
                            PersonID = 1,
                            SpaceshipID = 6
                        },
                        new
                        {
                            ID = 14,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 22, 6, 27, DateTimeKind.Unspecified).AddTicks(7378),
                            ParkingSpotID = 3,
                            PersonID = 1,
                            SpaceshipID = 1
                        },
                        new
                        {
                            ID = 15,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 22, 6, 27, DateTimeKind.Unspecified).AddTicks(7378),
                            ParkingSpotID = 4,
                            PersonID = 3,
                            SpaceshipID = 2
                        },
                        new
                        {
                            ID = 16,
                            ArrivalTime = new DateTime(2021, 3, 24, 12, 22, 6, 27, DateTimeKind.Unspecified).AddTicks(7378),
                            ParkingSpotID = 5,
                            PersonID = 4,
                            SpaceshipID = 3
                        });
                });

            modelBuilder.Entity("SpaceParkModel.Database.ParkingSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ParkingSizes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Price = 100.00m,
                            Size = 1000
                        },
                        new
                        {
                            ID = 2,
                            Price = 1000.00m,
                            Size = 10000
                        },
                        new
                        {
                            ID = 3,
                            Price = 5000.00m,
                            Size = 150000
                        });
                });

            modelBuilder.Entity("SpaceParkModel.Database.ParkingSpots", b =>
                {
                    b.Property<int>("Spot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParkingSizeID")
                        .HasColumnType("int");

                    b.HasKey("Spot");

                    b.ToTable("ParkingSpots");

                    b.HasData(
                        new
                        {
                            Spot = 1,
                            ParkingSizeID = 1
                        },
                        new
                        {
                            Spot = 2,
                            ParkingSizeID = 1
                        },
                        new
                        {
                            Spot = 3,
                            ParkingSizeID = 1
                        },
                        new
                        {
                            Spot = 4,
                            ParkingSizeID = 2
                        },
                        new
                        {
                            Spot = 5,
                            ParkingSizeID = 2
                        },
                        new
                        {
                            Spot = 6,
                            ParkingSizeID = 3
                        });
                });

            modelBuilder.Entity("SpaceParkModel.Database.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OccupancyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 600.00m,
                            OccupancyID = 1
                        },
                        new
                        {
                            ID = 2,
                            Amount = 100.00m,
                            OccupancyID = 2
                        },
                        new
                        {
                            ID = 3,
                            Amount = 400.00m,
                            OccupancyID = 3
                        },
                        new
                        {
                            ID = 4,
                            Amount = 10000.00m,
                            OccupancyID = 4
                        },
                        new
                        {
                            ID = 5,
                            Amount = 850.00m,
                            OccupancyID = 5
                        },
                        new
                        {
                            ID = 6,
                            Amount = 80.00m,
                            OccupancyID = 6
                        },
                        new
                        {
                            ID = 7,
                            Amount = 1200.00m,
                            OccupancyID = 7
                        },
                        new
                        {
                            ID = 8,
                            Amount = 250.00m,
                            OccupancyID = 8
                        },
                        new
                        {
                            ID = 9,
                            Amount = 400.00m,
                            OccupancyID = 9
                        },
                        new
                        {
                            ID = 10,
                            Amount = 700.00m,
                            OccupancyID = 11
                        },
                        new
                        {
                            ID = 12,
                            Amount = 300.00m,
                            OccupancyID = 13
                        });
                });

            modelBuilder.Entity("SpaceParkModel.Database.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            ID = 2,
                            Name = "R2-D2"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Leia Organa"
                        },
                        new
                        {
                            ID = 4,
                            Name = "C-3PO"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Beru Whitesun lars"
                        });
                });

            modelBuilder.Entity("SpaceParkModel.Database.Spaceship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Spaceships");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "X-wing"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Imperial shuttle"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Republic Cruiser"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Slave 1"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Republic attack cruiser"
                        },
                        new
                        {
                            ID = 6,
                            Name = "J-type diplomatic barge"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
