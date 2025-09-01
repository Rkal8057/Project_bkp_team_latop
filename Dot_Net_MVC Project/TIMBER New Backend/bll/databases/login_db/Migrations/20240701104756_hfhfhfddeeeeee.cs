using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hfhfhfddeeeeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "balance_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "current_stock_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "discount_percentage_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "grand_total_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "gst_percentage_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "hsn_code_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "issue_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "packing_type_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "rate_after_gst_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "remarks_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sale_rate_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "scheme_type_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "total_amount_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "balance_qty_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "current_stock_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "discount_percentage_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "grand_total_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "gst_percentage_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "hsn_code_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "issue_qty_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "packing_type_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "rate_after_gst_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "remarks_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sale_rate_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "scheme_type_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "total_amount_yn",
                table: "System_Records");
        }
    }
}
