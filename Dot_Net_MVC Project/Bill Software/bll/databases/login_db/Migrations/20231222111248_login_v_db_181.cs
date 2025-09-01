using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_v_db_181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "item_price",
                table: "ItemMaster",
                newName: "item_qty");

            migrationBuilder.AlterColumn<string>(
                name: "item_type",
                table: "ItemMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "item_amount",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<ulong>(
                name: "delete_at",
                table: "ItemMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "ItemMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "category_id",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<ulong>(
                name: "active",
                table: "ItemMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "item_qty",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<ulong>(
                name: "delete_at",
                table: "CategoryMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "CategoryMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.CreateIndex(
                name: "IX_ItemMaster_category_id",
                table: "ItemMaster",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMaster_CategoryMaster_category_id",
                table: "ItemMaster",
                column: "category_id",
                principalTable: "CategoryMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemMaster_CategoryMaster_category_id",
                table: "ItemMaster");

            migrationBuilder.DropIndex(
                name: "IX_ItemMaster_category_id",
                table: "ItemMaster");

            migrationBuilder.RenameColumn(
                name: "item_qty",
                table: "ItemMaster",
                newName: "item_price");

            migrationBuilder.AlterColumn<string>(
                name: "item_type",
                table: "ItemMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "item_amount",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<ulong>(
                name: "delete_at",
                table: "ItemMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "ItemMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "category_id",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<ulong>(
                name: "active",
                table: "ItemMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "item_price",
                table: "ItemMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<ulong>(
                name: "delete_at",
                table: "CategoryMaster",
                type: "bit",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "CategoryMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);
        }
    }
}
