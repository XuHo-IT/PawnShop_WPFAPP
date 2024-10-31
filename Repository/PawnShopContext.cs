using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public partial class PawnShopContext : DbContext
{
    public PawnShopContext()
    {
    }

    public PawnShopContext(DbContextOptions<PawnShopContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=;Database=PRNPawnShop;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
