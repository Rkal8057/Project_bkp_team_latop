using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjfjjff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 94)
                .OldAnnotation("Relational:ColumnOrder", 87);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "System_Records",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 92)
                .OldAnnotation("Relational:ColumnOrder", 85);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 93)
                .OldAnnotation("Relational:ColumnOrder", 86);

            migrationBuilder.AddColumn<string>(
                name: "agr_qty_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "damage_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "missing_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "opening_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "pc_rmt_pp_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "rent_rate_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "type_of_service",
                table: "PartyMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 30)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 29);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 31)
                .OldAnnotation("Relational:ColumnOrder", 29);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "agr_qty_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "damage_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "missing_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "opening_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "pc_rmt_pp_yn",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "rent_rate_yn",
                table: "System_Records");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 87)
                .OldAnnotation("Relational:ColumnOrder", 94);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "System_Records",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 85)
                .OldAnnotation("Relational:ColumnOrder", 92);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 86)
                .OldAnnotation("Relational:ColumnOrder", 93);

            migrationBuilder.AlterColumn<string>(
                name: "type_of_service",
                table: "PartyMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 29)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 30);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 29)
                .OldAnnotation("Relational:ColumnOrder", 31);
        }
    }
}
