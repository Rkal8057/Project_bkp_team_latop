using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class gjggsssssss : Migration
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
                .Annotation("Relational:ColumnOrder", 87)
                .OldAnnotation("Relational:ColumnOrder", 85);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "System_Records",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 85)
                .OldAnnotation("Relational:ColumnOrder", 84);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 86)
                .OldAnnotation("Relational:ColumnOrder", 84);

            migrationBuilder.AddColumn<string>(
                name: "gst_rate_yn",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gst_rate_yn",
                table: "System_Records");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 85)
                .OldAnnotation("Relational:ColumnOrder", 87);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "System_Records",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 84)
                .OldAnnotation("Relational:ColumnOrder", 85);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "System_Records",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 84)
                .OldAnnotation("Relational:ColumnOrder", 86);
        }
    }
}
