using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmanaShop.DAL.Migrations
{
    public partial class invoice_to_invoicedetail_ontomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WholePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceNumber);
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
        }
    }
}
