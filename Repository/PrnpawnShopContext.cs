using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public partial class PrnpawnShopContext : DbContext
{
    public PrnpawnShopContext()
    {
    }

    public PrnpawnShopContext(DbContextOptions<PrnpawnShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CapitalInformation> CapitalInformations { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<PawnContract> PawnContracts { get; set; }

    public virtual DbSet<ShopInformation> ShopInformations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); Database=PRNPawnShop; Uid=abc; Pwd=abc; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CapitalInformation>(entity =>
        {
            entity.HasKey(e => e.CapitalId).HasName("PK__CapitalI__D3DFD193C54BF007");

            entity.ToTable("CapitalInformation");

            entity.Property(e => e.CapitalId).HasColumnName("CapitalID");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Items__727E83EB02095EB9");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Interest).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PawnContract>(entity =>
        {
            entity.HasKey(e => e.ContractNumber).HasName("PK__PawnCont__C51D43DB8E01150F");

            entity.Property(e => e.ContractNumber).HasMaxLength(20);
            entity.Property(e => e.Item).HasMaxLength(100);
            entity.Property(e => e.PawnMoney).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.UserRealName).HasMaxLength(100);
        });

        modelBuilder.Entity<ShopInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShopInformation");

            entity.Property(e => e.RoomDetailDescription).HasMaxLength(200);
            entity.Property(e => e.ShopAddress).HasMaxLength(200);
            entity.Property(e => e.ShopName).HasMaxLength(100);
            entity.Property(e => e.Telephone).HasMaxLength(15);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC68C2C486");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Cid)
                .HasMaxLength(20)
                .HasColumnName("CID");
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(15);
            entity.Property(e => e.UserRealName).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
