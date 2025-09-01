using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh22222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "balance_sheet_cate_name",
                table: "CategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "balance_sheet_id",
                table: "CategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "cate_id_if_sub_Selected",
                table: "CategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 13);

            migrationBuilder.AddColumn<string>(
                name: "cate_name_if_sub_Selected",
                table: "CategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cate_type",
                table: "CategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "super_cate_id",
                table: "CategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<string>(
                name: "table_flag",
                table: "CategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "balance_sheet_cate_name",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "balance_sheet_id",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_id_if_sub_Selected",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_name_if_sub_Selected",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_type",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "super_cate_id",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "table_flag",
                table: "CategoryMaster");
        }
    }
}
