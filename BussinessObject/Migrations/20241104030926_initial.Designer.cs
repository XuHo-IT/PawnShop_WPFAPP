﻿// <auto-generated />
using System;
using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BussinessObject.Migrations
{
    [DbContext(typeof(PawnShopContext))]
    [Migration("20241104030926_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BussinessObject.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<DateTime>("DateBuy")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShopItemId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            BillId = 1,
                            DateBuy = new DateTime(2024, 10, 25, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1631),
                            ShopItemId = 1,
                            UserId = 1
                        },
                        new
                        {
                            BillId = 2,
                            DateBuy = new DateTime(2024, 10, 30, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1634),
                            ShopItemId = 2,
                            UserId = 2
                        },
                        new
                        {
                            BillId = 3,
                            DateBuy = new DateTime(2024, 10, 15, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1635),
                            ShopItemId = 3,
                            UserId = 3
                        },
                        new
                        {
                            BillId = 4,
                            DateBuy = new DateTime(2024, 11, 2, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1636),
                            ShopItemId = 4,
                            UserId = 4
                        },
                        new
                        {
                            BillId = 5,
                            DateBuy = new DateTime(2024, 10, 28, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1638),
                            ShopItemId = 5,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("BussinessObject.CapitalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("TotalCapital")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalExpenditure")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalProfit")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("CapitalInformation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TotalCapital = 10000.00m,
                            TotalExpenditure = 10000.00m,
                            TotalIncome = 0m,
                            TotalProfit = 0m
                        });
                });

            modelBuilder.Entity("BussinessObject.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Description = "14K Gold Ring",
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1295),
                            Interest = 0.05m,
                            IsApproved = true,
                            Name = "Gold Ring",
                            Status = "Pending",
                            UserId = 1,
                            Value = 250.00m
                        },
                        new
                        {
                            ItemId = 2,
                            Description = "Luxury Watch",
                            ExpirationDate = new DateTime(2025, 1, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1320),
                            Interest = 0.10m,
                            IsApproved = true,
                            Name = "Luxury Watch",
                            Status = "Active",
                            UserId = 2,
                            Value = 500.00m
                        },
                        new
                        {
                            ItemId = 3,
                            Description = "24K Diamond Necklace",
                            ExpirationDate = new DateTime(2025, 2, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1322),
                            Interest = 0.07m,
                            IsApproved = true,
                            Name = "Diamond Necklace",
                            Status = "Pending",
                            UserId = 3,
                            Value = 1200.00m
                        },
                        new
                        {
                            ItemId = 4,
                            Description = "Sterling Silver Bracelet",
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1325),
                            Interest = 0.04m,
                            IsApproved = false,
                            Name = "Silver Bracelet",
                            Status = "Active",
                            UserId = 4,
                            Value = 150.00m
                        },
                        new
                        {
                            ItemId = 5,
                            Description = "Porcelain Antique Vase",
                            ExpirationDate = new DateTime(2025, 3, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1328),
                            Interest = 0.08m,
                            IsApproved = true,
                            Name = "Antique Vase",
                            Status = "Pending",
                            UserId = 5,
                            Value = 750.00m
                        });
                });

            modelBuilder.Entity("BussinessObject.PawnContract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"));

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ContractId");

                    b.ToTable("PawnContracts");

                    b.HasData(
                        new
                        {
                            ContractId = 1,
                            ContractDate = new DateTime(2024, 10, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1509),
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1510),
                            ItemId = 1,
                            LoanAmount = 200.00m,
                            UserId = 1
                        },
                        new
                        {
                            ContractId = 2,
                            ContractDate = new DateTime(2024, 9, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1512),
                            ExpirationDate = new DateTime(2025, 1, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1512),
                            ItemId = 2,
                            LoanAmount = 400.00m,
                            UserId = 2
                        },
                        new
                        {
                            ContractId = 3,
                            ContractDate = new DateTime(2024, 8, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1514),
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1515),
                            ItemId = 3,
                            LoanAmount = 900.00m,
                            UserId = 3
                        },
                        new
                        {
                            ContractId = 4,
                            ContractDate = new DateTime(2024, 10, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1517),
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1518),
                            ItemId = 4,
                            LoanAmount = 120.00m,
                            UserId = 4
                        },
                        new
                        {
                            ContractId = 5,
                            ContractDate = new DateTime(2024, 7, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1520),
                            ExpirationDate = new DateTime(2024, 12, 4, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1520),
                            ItemId = 5,
                            LoanAmount = 600.00m,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("BussinessObject.ShopInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ShopAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShopInformation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ShopAddress = "FPT University",
                            ShopName = "FPT Pawn Shop",
                            Telephone = "1234-5555"
                        });
                });

            modelBuilder.Entity("BussinessObject.ShopItem", b =>
                {
                    b.Property<int>("ShopItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopItemId"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ShopItemId");

                    b.ToTable("ShopItem");

                    b.HasData(
                        new
                        {
                            ShopItemId = 1,
                            DateAdded = new DateTime(2024, 10, 15, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1463),
                            Description = "High performance laptop for gaming.",
                            IsExpired = true,
                            Name = "Gaming Laptop",
                            Price = 750.00m
                        },
                        new
                        {
                            ShopItemId = 2,
                            DateAdded = new DateTime(2024, 10, 20, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1468),
                            Description = "Latest smartphone with advanced features.",
                            IsExpired = true,
                            Name = "Latest Model Smartphone",
                            Price = 300.00m
                        },
                        new
                        {
                            ShopItemId = 3,
                            DateAdded = new DateTime(2024, 10, 5, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1470),
                            Description = "Professional electric guitar.",
                            IsExpired = true,
                            Name = "Electric Guitar",
                            Price = 450.00m
                        },
                        new
                        {
                            ShopItemId = 4,
                            DateAdded = new DateTime(2024, 10, 30, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1472),
                            Description = "High resolution digital camera.",
                            IsExpired = true,
                            Name = "Digital Camera",
                            Price = 600.00m
                        },
                        new
                        {
                            ShopItemId = 5,
                            DateAdded = new DateTime(2024, 10, 25, 10, 9, 26, 204, DateTimeKind.Local).AddTicks(1473),
                            Description = "Luxury brand handbag.",
                            IsExpired = true,
                            Name = "Designer Handbag",
                            Price = 850.00m
                        });
                });

            modelBuilder.Entity("BussinessObject.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CID")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserRealName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Address = "123 Main St",
                            CID = "C123456789",
                            Dob = new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "john.doe@example.com",
                            Gender = true,
                            Password = "Password123",
                            Telephone = "123-456-7890",
                            UserName = "john_doe",
                            UserRealName = "John Doe",
                            UserRole = 1
                        },
                        new
                        {
                            UserID = 2,
                            Address = "456 Oak St",
                            CID = "C987654321",
                            Dob = new DateTime(1988, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "jane.smith@example.com",
                            Gender = false,
                            Password = "Password456",
                            Telephone = "098-765-4321",
                            UserName = "jane_smith",
                            UserRealName = "Jane Smith",
                            UserRole = 2
                        },
                        new
                        {
                            UserID = 3,
                            Address = "789 Pine St",
                            CID = "C555123456",
                            Dob = new DateTime(1985, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "michael.brown@example.com",
                            Gender = true,
                            Password = "Password789",
                            Telephone = "555-123-4567",
                            UserName = "michael_brown",
                            UserRealName = "Michael Brown",
                            UserRole = 1
                        },
                        new
                        {
                            UserID = 4,
                            Address = "101 Maple St",
                            CID = "C444987654",
                            Dob = new DateTime(1992, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "emily.jones@example.com",
                            Gender = false,
                            Password = "Password101",
                            Telephone = "444-987-6543",
                            UserName = "emily_jones",
                            UserRealName = "Emily Jones",
                            UserRole = 2
                        },
                        new
                        {
                            UserID = 5,
                            Address = "202 Oakwood Ave",
                            CID = "C333222111",
                            Dob = new DateTime(1978, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "robert.smith@example.com",
                            Gender = true,
                            Password = "Password202",
                            Telephone = "333-222-1111",
                            UserName = "robert_smith",
                            UserRealName = "Robert Smith",
                            UserRole = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
