using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hghghggdddeewwqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "party_category_under_account",
                table: "PartyCategoryMaster",
                newName: "balance_sheet_cate_name");

            migrationBuilder.RenameColumn(
                name: "party_category_type",
                table: "PartyCategoryMaster",
                newName: "table_flag");

            migrationBuilder.RenameColumn(
                name: "party_category_name",
                table: "PartyCategoryMaster",
                newName: "delete_option");

            migrationBuilder.RenameColumn(
                name: "party_category_main",
                table: "PartyCategoryMaster",
                newName: "category_name");

            migrationBuilder.AlterColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "PartyCategoryMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "active",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "balance_sheet_cate_name",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "table_flag",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "delete_option",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<long>(
                name: "balance_sheet_id",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<long>(
                name: "cate_id_if_sub_Selected",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<string>(
                name: "cate_name_if_sub_Selected",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cate_type",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "super_cate_id",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "balance_sheet_id",
                table: "PartyCategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_id_if_sub_Selected",
                table: "PartyCategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_name_if_sub_Selected",
                table: "PartyCategoryMaster");

            migrationBuilder.DropColumn(
                name: "cate_type",
                table: "PartyCategoryMaster");

            migrationBuilder.DropColumn(
                name: "super_cate_id",
                table: "PartyCategoryMaster");

            migrationBuilder.RenameColumn(
                name: "balance_sheet_cate_name",
                table: "PartyCategoryMaster",
                newName: "party_category_under_account");

            migrationBuilder.RenameColumn(
                name: "table_flag",
                table: "PartyCategoryMaster",
                newName: "party_category_type");

            migrationBuilder.RenameColumn(
                name: "delete_option",
                table: "PartyCategoryMaster",
                newName: "party_category_name");

            migrationBuilder.RenameColumn(
                name: "category_name",
                table: "PartyCategoryMaster",
                newName: "party_category_main");

            migrationBuilder.AlterColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "PartyCategoryMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AlterColumn<long>(
                name: "active",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<string>(
                name: "party_category_under_account",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "party_category_type",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "party_category_name",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "party_category_main",
                table: "PartyCategoryMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 2);
        }
    }
}
