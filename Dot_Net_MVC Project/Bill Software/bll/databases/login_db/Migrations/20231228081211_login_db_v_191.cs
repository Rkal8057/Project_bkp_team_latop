using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_191 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "discount_amount",
                table: "SalesMaster",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<decimal>(
                name: "discount_percentage",
                table: "SalesMaster",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<decimal>(
                name: "grand_total_after_discount",
                table: "SalesMaster",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount_amount",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "discount_percentage",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "grand_total_after_discount",
                table: "SalesMaster");
        }
    }
}
