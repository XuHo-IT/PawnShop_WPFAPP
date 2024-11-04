using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BussinessObject.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateBuy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "CapitalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalExpenditure = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "PawnContracts",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PawnContracts", x => x.ContractId);
                });

            migrationBuilder.CreateTable(
                name: "ShopInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShopAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItem",
                columns: table => new
                {
                    ShopItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItem", x => x.ShopItemId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserRealName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillId", "DateBuy", "ShopItemId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 25, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(9029), 1, 1 },
                    { 2, new DateTime(2024, 10, 30, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(9031), 2, 2 },
                    { 3, new DateTime(2024, 10, 15, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(9032), 3, 3 },
                    { 4, new DateTime(2024, 11, 2, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(9033), 4, 4 },
                    { 5, new DateTime(2024, 10, 28, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(9035), 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "CapitalInformation",
                columns: new[] { "Id", "TotalCapital", "TotalExpenditure", "TotalIncome" },
                values: new object[] { 1, 1000.00m, 300.00m, 500.00m });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "Description", "ExpirationDate", "Interest", "IsApproved", "Name", "Status", "UserId", "Value" },
                values: new object[,]
                {
                    { 1, "14K Gold Ring", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8803), 0.05m, true, "Gold Ring", "Pending", 1, 250.00m },
                    { 2, "Luxury Watch", new DateTime(2025, 1, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8824), 0.10m, true, "Luxury Watch", "Active", 2, 500.00m },
                    { 3, "24K Diamond Necklace", new DateTime(2025, 2, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8827), 0.07m, true, "Diamond Necklace", "Pending", 3, 1200.00m },
                    { 4, "Sterling Silver Bracelet", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8829), 0.04m, false, "Silver Bracelet", "Active", 4, 150.00m },
                    { 5, "Porcelain Antique Vase", new DateTime(2025, 3, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8831), 0.08m, true, "Antique Vase", "Pending", 5, 750.00m }
                });

            migrationBuilder.InsertData(
                table: "PawnContracts",
                columns: new[] { "ContractId", "ContractDate", "Description", "ExpirationDate", "ItemId", "LoanAmount", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8957), "14K Gold Ring", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8958), 1, 200.00m, 1 },
                    { 2, new DateTime(2024, 9, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8960), "Luxury Watch", new DateTime(2025, 1, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8961), 2, 400.00m, 2 },
                    { 3, new DateTime(2024, 8, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8962), "24K Diamond Necklace", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8963), 3, 900.00m, 3 },
                    { 4, new DateTime(2024, 10, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8964), "Sterling Silver Bracelet", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8965), 4, 120.00m, 4 },
                    { 5, new DateTime(2024, 7, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8966), "Porcelain Antique Vase", new DateTime(2024, 12, 4, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8967), 5, 600.00m, 5 }
                });

            migrationBuilder.InsertData(
                table: "ShopInformation",
                columns: new[] { "Id", "ShopAddress", "ShopName", "Telephone" },
                values: new object[] { 1, "FPT University", "FPT Pawn Shop", "1234-5555" });

            migrationBuilder.InsertData(
                table: "ShopItem",
                columns: new[] { "ShopItemId", "DateAdded", "Description", "IsExpired", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 15, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8926), "High performance laptop for gaming.", true, "Gaming Laptop", 750.00m },
                    { 2, new DateTime(2024, 10, 20, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8932), "Latest smartphone with advanced features.", true, "Latest Model Smartphone", 300.00m },
                    { 3, new DateTime(2024, 10, 5, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8934), "Professional electric guitar.", true, "Electric Guitar", 450.00m },
                    { 4, new DateTime(2024, 10, 30, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8935), "High resolution digital camera.", true, "Digital Camera", 600.00m },
                    { 5, new DateTime(2024, 10, 25, 10, 26, 3, 969, DateTimeKind.Local).AddTicks(8936), "Luxury brand handbag.", true, "Designer Handbag", 850.00m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Address", "CID", "Dob", "EmailAddress", "Gender", "Password", "Telephone", "UserName", "UserRealName", "UserRole" },
                values: new object[,]
                {
                    { 1, "123 Main St", "C123456789", new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "Password123", "123-456-7890", "john_doe", "John Doe", 1 },
                    { 2, "456 Oak St", "C987654321", new DateTime(1988, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", false, "Password456", "098-765-4321", "jane_smith", "Jane Smith", 2 },
                    { 3, "789 Pine St", "C555123456", new DateTime(1985, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", true, "Password789", "555-123-4567", "michael_brown", "Michael Brown", 1 },
                    { 4, "101 Maple St", "C444987654", new DateTime(1992, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.jones@example.com", false, "Password101", "444-987-6543", "emily_jones", "Emily Jones", 2 },
                    { 5, "202 Oakwood Ave", "C333222111", new DateTime(1978, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert.smith@example.com", true, "Password202", "333-222-1111", "robert_smith", "Robert Smith", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "CapitalInformation");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "PawnContracts");

            migrationBuilder.DropTable(
                name: "ShopInformation");

            migrationBuilder.DropTable(
                name: "ShopItem");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
