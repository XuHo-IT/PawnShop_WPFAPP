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
                name: "ShopItemn",
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
                    table.PrimaryKey("PK_ShopItemn", x => x.ShopItemId);
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
                    { 1, new DateTime(2024, 10, 24, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6866), 1, 1 },
                    { 2, new DateTime(2024, 10, 29, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6872), 2, 2 }
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
                    { 1, "14K Gold Ring", new DateTime(2024, 12, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6592), 0.05m, true, "Gold Ring", "Pending", 1, 250.00m },
                    { 2, "Luxury Watch", new DateTime(2025, 1, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6616), 0.10m, true, "Luxury Watch", "Active", 2, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "PawnContracts",
                columns: new[] { "ContractId", "ContractDate", "ExpirationDate", "ItemId", "LoanAmount", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 12, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6795), 1, 200.00m, 1 },
                    { 2, new DateTime(2024, 11, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6797), new DateTime(2025, 1, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6797), 2, 400.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "ShopInformation",
                columns: new[] { "Id", "ShopAddress", "ShopName", "Telephone" },
                values: new object[] { 1, "FPT University", "FPT Pawn Shop", "1234-5555" });

            migrationBuilder.InsertData(
                table: "ShopItemn",
                columns: new[] { "ShopItemId", "DateAdded", "Description", "IsExpired", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6759), "High performance laptop for gaming.", false, "Gaming Laptop", 750.00m },
                    { 2, new DateTime(2024, 11, 3, 21, 31, 4, 40, DateTimeKind.Local).AddTicks(6761), "Latest smartphone with advanced features.", false, "Latest Model Smartphone", 300.00m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Address", "CID", "Dob", "EmailAddress", "Gender", "Password", "Telephone", "UserName", "UserRealName", "UserRole" },
                values: new object[,]
                {
                    { 1, "123 Main St", "C123456789", new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "Password123", "123-456-7890", "john_doe", "John Doe", 1 },
                    { 2, "456 Oak St", "C987654321", new DateTime(1988, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", false, "Password456", "098-765-4321", "jane_smith", "Jane Smith", 2 }
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
                name: "ShopItemn");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
