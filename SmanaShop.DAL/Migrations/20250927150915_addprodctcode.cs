using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmanaShop.DAL.Migrations
{
    public partial class addprodctcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProducCode",
                table: "Product",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProducCode",
                table: "Product");
        }
    }
}
