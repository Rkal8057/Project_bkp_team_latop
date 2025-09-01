using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhklklklklkdddddddddddddsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 27)
                .OldAnnotation("Relational:ColumnOrder", 23);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 26)
                .OldAnnotation("Relational:ColumnOrder", 22);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 23)
                .OldAnnotation("Relational:ColumnOrder", 27);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 22)
                .OldAnnotation("Relational:ColumnOrder", 26);
        }
    }
}
