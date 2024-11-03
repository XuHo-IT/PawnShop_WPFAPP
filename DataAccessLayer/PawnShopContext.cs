using System;
using System.Collections.Generic;
using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public partial class PawnShopContext : DbContext
{
    public PawnShopContext()
    {
    }

    public PawnShopContext(DbContextOptions<PawnShopContext> options)
        : base(options)
    {
    }

  

    public virtual DbSet<CapitalInformation> CapitalInformation { get; set; }

    public virtual DbSet<Item> Items{ get; set; }

    public virtual DbSet<ShopItem> ShopItems{ get; set; }
    public virtual DbSet<PawnContract> PawnContracts { get; set; }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<ShopInformation> ShopInformation{ get; set; }


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
    
        modelBuilder.Entity<Item>().HasData(
            new Item { ItemId = 1, Name = "Gold Ring", Description = "14K Gold Ring", Value = 250.00m, Status = "Pending", ExpirationDate = DateTime.Now.AddMonths(1) },
            new Item { ItemId = 2, Name = "Watch", Description = "Luxury Watch", Value = 500.00m, Status = "Active", ExpirationDate = DateTime.Now.AddMonths(2) }
        );

 
        modelBuilder.Entity<ShopItem>().HasData(
            new ShopItem { ShopItemId = 1, Name = "Laptop", Description = "Gaming Laptop", Price = 750.00m, DateAdded = DateTime.Now },
            new ShopItem { ShopItemId = 2, Name = "Smartphone", Description = "Latest Model Smartphone", Price = 300.00m, DateAdded = DateTime.Now}
        );

        modelBuilder.Entity<PawnContract>().HasData(
        new PawnContract { ContractId = 1, ItemId = 1, Description = "14K Gold Ring Pawn", UserId = 1, LoanAmount = 200.00m, ContractDate = DateTime.Now, ExpirationDate = DateTime.Now.AddMonths(1) },
        new PawnContract { ContractId = 2, ItemId = 2, Description = "Luxury Watch", UserId = 2, LoanAmount = 400.00m, ContractDate = DateTime.Now, ExpirationDate = DateTime.Now.AddMonths(2) }
);

        modelBuilder.Entity<ShopInformation>().HasData(
     new ShopInformation
     {
         Id = 1, // Add an ID for seeding
         ShopName = "FPT Pawn Shop",
         ShopAddress = "FPT University",
         Telephone = "1234-5555"
     }
 );
        modelBuilder.Entity<CapitalInformation>().HasData(
      new CapitalInformation
      {
          Id = 1, // Add an ID for seeding
          TotalCapital = 0,
          TotalIncome = 0,
          TotalExpenditure = 0
      }
  );
        modelBuilder.Entity<PawnContract>()
                 .HasKey(pc => new { pc.ContractId, pc.ItemId });  
    }
}
