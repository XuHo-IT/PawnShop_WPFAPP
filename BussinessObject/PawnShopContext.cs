﻿using System;
using System.Collections.Generic;
using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BussinessObject;

public class PawnShopContext : DbContext
{
    public PawnShopContext()
    {
    }

    public PawnShopContext(DbContextOptions<PawnShopContext> options)
        : base(options)
    {
    }

  

    public virtual DbSet<CapitalInformation> CapitalInformation { get; set; }

    public virtual DbSet<Item> Item{ get; set; }

    public virtual DbSet<ShopItem> ShopItem { get; set; }
    public virtual DbSet<PawnContract> PawnContracts { get; set; }

    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<ShopInformation> ShopInformation{ get; set; }
    public virtual DbSet<Bill> Bills { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PawnShop"));
        }
    }

    string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();
        return config["ConnectionStrings:PawnShop"];
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // Seed data for Item
        modelBuilder.Entity<Item>().HasData(
            new Item { ItemId = 1, Name = "Gold Ring", Description = "14K Gold Ring", Value = 250.00m, Status = "Pending", ExpirationDate = DateTime.Now.AddMonths(1), Interest = 0.05m, IsApproved = true, UserId = 1 },
            new Item { ItemId = 2, Name = "Luxury Watch", Description = "Luxury Watch", Value = 500.00m, Status = "Active", ExpirationDate = DateTime.Now.AddMonths(2), Interest = 0.10m, IsApproved = true, UserId = 2 },
            new Item { ItemId = 3, Name = "Diamond Necklace", Description = "24K Diamond Necklace", Value = 1200.00m, Status = "Pending", ExpirationDate = DateTime.Now.AddMonths(3), Interest = 0.07m, IsApproved = true, UserId = 3 },
            new Item { ItemId = 4, Name = "Silver Bracelet", Description = "Sterling Silver Bracelet", Value = 150.00m, Status = "Active", ExpirationDate = DateTime.Now.AddMonths(1), Interest = 0.04m, IsApproved = false, UserId = 4 },
            new Item { ItemId = 5, Name = "Antique Vase", Description = "Porcelain Antique Vase", Value = 750.00m, Status = "Pending", ExpirationDate = DateTime.Now.AddMonths(4), Interest = 0.08m, IsApproved = true, UserId = 5 }
        );

        // Seed data for ShopItem
        modelBuilder.Entity<ShopItem>().HasData(
            new ShopItem { ShopItemId = 1, Name = "Gaming Laptop", Description = "High performance laptop for gaming.", Price = 750.00m, DateAdded = DateTime.Now.AddDays(-20), IsExpired = true },
            new ShopItem { ShopItemId = 2, Name = "Latest Model Smartphone", Description = "Latest smartphone with advanced features.", Price = 300.00m, DateAdded = DateTime.Now.AddDays(-15), IsExpired = true },
            new ShopItem { ShopItemId = 3, Name = "Electric Guitar", Description = "Professional electric guitar.", Price = 450.00m, DateAdded = DateTime.Now.AddDays(-30), IsExpired = true },
            new ShopItem { ShopItemId = 4, Name = "Digital Camera", Description = "High resolution digital camera.", Price = 600.00m, DateAdded = DateTime.Now.AddDays(-5), IsExpired = true },
            new ShopItem { ShopItemId = 5, Name = "Designer Handbag", Description = "Luxury brand handbag.", Price = 850.00m, DateAdded = DateTime.Now.AddDays(-10), IsExpired = true }
        );

        // Seed data for PawnContract
        modelBuilder.Entity<PawnContract>().HasData(
            new PawnContract { ContractId = 1, ItemId = 1, UserId = 1, LoanAmount = 200.00m, ContractDate = DateTime.Now.AddMonths(-1), ExpirationDate = DateTime.Now.AddMonths(1) },
            new PawnContract { ContractId = 2, ItemId = 2, UserId = 2, LoanAmount = 400.00m, ContractDate = DateTime.Now.AddMonths(-2), ExpirationDate = DateTime.Now.AddMonths(2) },
            new PawnContract { ContractId = 3, ItemId = 3, UserId = 3, LoanAmount = 900.00m, ContractDate = DateTime.Now.AddMonths(-3), ExpirationDate = DateTime.Now.AddMonths(1) },
            new PawnContract { ContractId = 4, ItemId = 4, UserId = 4, LoanAmount = 120.00m, ContractDate = DateTime.Now.AddMonths(-1), ExpirationDate = DateTime.Now.AddMonths(1) },
            new PawnContract { ContractId = 5, ItemId = 5, UserId = 5, LoanAmount = 600.00m, ContractDate = DateTime.Now.AddMonths(-4), ExpirationDate = DateTime.Now.AddMonths(1) }
        );

        // Seed data for User
        modelBuilder.Entity<User>().HasData(
            new User { UserID = 1, UserName = "john_doe", UserRealName = "John Doe", Telephone = "123-456-7890", Gender = true, EmailAddress = "john.doe@example.com", Dob = new DateTime(1990, 5, 20), Address = "123 Main St", UserRole = 1, CID = "C123456789", Password = "Password123" },
            new User { UserID = 2, UserName = "jane_smith", UserRealName = "Jane Smith", Telephone = "098-765-4321", Gender = false, EmailAddress = "jane.smith@example.com", Dob = new DateTime(1988, 8, 15), Address = "456 Oak St", UserRole = 2, CID = "C987654321", Password = "Password456" },
            new User { UserID = 3, UserName = "michael_brown", UserRealName = "Michael Brown", Telephone = "555-123-4567", Gender = true, EmailAddress = "michael.brown@example.com", Dob = new DateTime(1985, 10, 5), Address = "789 Pine St", UserRole = 1, CID = "C555123456", Password = "Password789" },
            new User { UserID = 4, UserName = "emily_jones", UserRealName = "Emily Jones", Telephone = "444-987-6543", Gender = false, EmailAddress = "emily.jones@example.com", Dob = new DateTime(1992, 2, 28), Address = "101 Maple St", UserRole = 2, CID = "C444987654", Password = "Password101" },
            new User { UserID = 5, UserName = "robert_smith", UserRealName = "Robert Smith", Telephone = "333-222-1111", Gender = true, EmailAddress = "robert.smith@example.com", Dob = new DateTime(1978, 12, 12), Address = "202 Oakwood Ave", UserRole = 1, CID = "C333222111", Password = "Password202" }
        );

        // Seed data for Bill
        modelBuilder.Entity<Bill>().HasData(
            new Bill { BillId = 1, ShopItemId = 1, UserId = 1, DateBuy = DateTime.Now.AddDays(-10) },
            new Bill { BillId = 2, ShopItemId = 2, UserId = 2, DateBuy = DateTime.Now.AddDays(-5) },
            new Bill { BillId = 3, ShopItemId = 3, UserId = 3, DateBuy = DateTime.Now.AddDays(-20) },
            new Bill { BillId = 4, ShopItemId = 4, UserId = 4, DateBuy = DateTime.Now.AddDays(-2) },
            new Bill { BillId = 5, ShopItemId = 5, UserId = 5, DateBuy = DateTime.Now.AddDays(-7) }
        );


        // Seed data for CapitalInformation
        modelBuilder.Entity<CapitalInformation>().HasData(
            new CapitalInformation
            {
                Id = 1,
                TotalCapital = 1000.00m,
                TotalIncome = 500.00m,
                TotalExpenditure = 300.00m
            }
        );

        // Seed data for ShopInformation
        modelBuilder.Entity<ShopInformation>().HasData(
            new ShopInformation
            {
                Id = 1,
                ShopName = "FPT Pawn Shop",
                ShopAddress = "FPT University",
                Telephone = "1234-5555"
            }
        );
    }
}
