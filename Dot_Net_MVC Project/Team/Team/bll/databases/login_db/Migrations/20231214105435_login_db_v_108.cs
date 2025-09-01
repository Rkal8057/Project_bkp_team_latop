using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nature_of_complaint",
                table: "Complaint_Trx_Master");

            migrationBuilder.DropColumn(
                name: "nature_of_complaint_detail",
                table: "Complaint_Trx_Master");

            migrationBuilder.DropColumn(
                name: "nature_of_complaint_remark",
                table: "Complaint_Trx_Master");

            migrationBuilder.DropColumn(
                name: "reason_of_reject_remark",
                table: "Complaint_Trx_Master");

            migrationBuilder.DropColumn(
                name: "reject_yn",
                table: "Complaint_Trx_Master");

            migrationBuilder.AlterColumn<long>(
                name: "master_id",
                table: "Complaint_Trx_Master",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Complaint_Trx_Master",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Complaint_Master",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime")
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "attached_file",
                table: "Complaint_Master",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint",
                table: "Complaint_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint_detail",
                table: "Complaint_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint_remark",
                table: "Complaint_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nature_of_complaint",
                table: "Complaint_Master");

            migrationBuilder.DropColumn(
                name: "nature_of_complaint_detail",
                table: "Complaint_Master");

            migrationBuilder.DropColumn(
                name: "nature_of_complaint_remark",
                table: "Complaint_Master");

            migrationBuilder.AlterColumn<long>(
                name: "master_id",
                table: "Complaint_Trx_Master",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Complaint_Trx_Master",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime")
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint",
                table: "Complaint_Trx_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint_detail",
                table: "Complaint_Trx_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nature_of_complaint_remark",
                table: "Complaint_Trx_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "reason_of_reject_remark",
                table: "Complaint_Trx_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "reject_yn",
                table: "Complaint_Trx_Master",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Complaint_Master",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime")
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<string>(
                name: "attached_file",
                table: "Complaint_Master",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 14);
        }
    }
}
