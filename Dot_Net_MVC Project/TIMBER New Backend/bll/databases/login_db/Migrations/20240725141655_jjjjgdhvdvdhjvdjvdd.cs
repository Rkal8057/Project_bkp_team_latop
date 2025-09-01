using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jjjjgdhvdvdhjvdjvdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_on",
                table: "ReviewMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 15)
                .OldAnnotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "ReviewMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AddColumn<long>(
                name: "position",
                table: "ReviewMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 13);

            migrationBuilder.AddColumn<long>(
                name: "position",
                table: "PortfolioMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 18);

            migrationBuilder.AddColumn<long>(
                name: "position",
                table: "ClientMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 18);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "position",
                table: "ReviewMaster");

            migrationBuilder.DropColumn(
                name: "position",
                table: "PortfolioMaster");

            migrationBuilder.DropColumn(
                name: "position",
                table: "ClientMaster");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_on",
                table: "ReviewMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("Relational:ColumnOrder", 15);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "ReviewMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 14);
        }
    }
}
