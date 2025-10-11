using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmanaShop.DAL.Migrations
{
    public partial class setup_configoration_invoiceinvoicedetailcustomer_afterrevert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    NationalCode = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: true),
                    InvoiceNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.NationalCode);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceNumber = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WholePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceNumber);
                    table.ForeignKey(
                        name: "FK_Invoice_Customer_InvoiceNumber",
                        column: x => x.InvoiceNumber,
                        principalTable: "Customer",
                        principalColumn: "NationalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetil",
                columns: table => new
                {
                    InvoiceDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InavoiveDetailPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductQuntity = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetil", x => x.InvoiceDetailID);
                    table.ForeignKey(
                        name: "FK_InvoiceDetil_Invoice_InvoiceNumber",
                        column: x => x.InvoiceNumber,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetil_InvoiceNumber",
                table: "InvoiceDetil",
                column: "InvoiceNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceDetil");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
