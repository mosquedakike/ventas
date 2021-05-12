using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MigracionUno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BrandProject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmployeeLastName_2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    EmployeePosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "BrandProject", "Status" },
                values: new object[,]
                {
                    { 1, "Quaker State", "Promotoria Quaker", true },
                    { 2, "Liverpool", "Promotoria", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "ProductDescription", "ProductName", "Status" },
                values: new object[,]
                {
                    { 1, "Quaker State", "25W50", "QS MAXIMA VISCOSIDAD SAE 25W50 CF4", true },
                    { 2, "Quaker State", "Anticongelante", "ANTICONGELANTE CONCENTRACION IDEAL", true },
                    { 3, "Quaker State", "GREEN OIL", "QS GREEN OIL SAE 140", true }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BrandId", "EmployeeLastName", "EmployeeLastName_2", "EmployeeName", "EmployeePosition", "Status" },
                values: new object[] { 1, 1, "Lopez", "Obrador", "Andres Manuel", "Vendedor", true });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BrandId", "EmployeeLastName", "EmployeeLastName_2", "EmployeeName", "EmployeePosition", "Status" },
                values: new object[] { 2, 1, "Navarrete", "Hernandez", "Miguel", "Vendedor", true });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "EmployeeId", "ProductId", "Quantity", "SaleDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 18, new DateTime(2021, 5, 12, 12, 30, 5, 802, DateTimeKind.Local).AddTicks(5699) },
                    { 5, 1, 1, 87, new DateTime(2021, 5, 12, 12, 30, 5, 809, DateTimeKind.Local).AddTicks(1994) },
                    { 2, 2, 3, 50, new DateTime(2021, 5, 12, 12, 30, 5, 809, DateTimeKind.Local).AddTicks(1892) },
                    { 3, 2, 2, 2, new DateTime(2021, 5, 12, 12, 30, 5, 809, DateTimeKind.Local).AddTicks(1975) },
                    { 4, 2, 2, 5, new DateTime(2021, 5, 12, 12, 30, 5, 809, DateTimeKind.Local).AddTicks(1986) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BrandId",
                table: "Employees",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
