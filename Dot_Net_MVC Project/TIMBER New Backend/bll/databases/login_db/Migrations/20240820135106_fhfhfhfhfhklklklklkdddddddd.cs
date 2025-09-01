using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhklklklklkdddddddd : Migration
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
                .Annotation("Relational:ColumnOrder", 22)
                .OldAnnotation("Relational:ColumnOrder", 18);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 21)
                .OldAnnotation("Relational:ColumnOrder", 17);

            migrationBuilder.AddColumn<string>(
                name: "general_req_commission_amt",
                table: "GeneralRequestedDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "general_req_commission_percentage",
                table: "GeneralRequestedDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "general_req_commission_type",
                table: "GeneralRequestedDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "general_req_key_amt",
                table: "GeneralRequestedDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "general_req_commission_amt",
                table: "GeneralRequestedDetail");

            migrationBuilder.DropColumn(
                name: "general_req_commission_percentage",
                table: "GeneralRequestedDetail");

            migrationBuilder.DropColumn(
                name: "general_req_commission_type",
                table: "GeneralRequestedDetail");

            migrationBuilder.DropColumn(
                name: "general_req_key_amt",
                table: "GeneralRequestedDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 18)
                .OldAnnotation("Relational:ColumnOrder", 22);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "GeneralRequestedDetail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 17)
                .OldAnnotation("Relational:ColumnOrder", 21);
        }
    }
}
