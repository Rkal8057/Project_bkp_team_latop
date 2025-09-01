using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjfjfkkkkkkjjjjjkkkkkkddddddkkkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "extended_warranty_Item_id",
                table: "WarrantyExtended");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "WarrantyExtended",
                newName: "warranty_gst_percentage");

            migrationBuilder.AlterColumn<string>(
                name: "warranty_serial_no",
                table: "WarrantyExtended",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "party_code",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "item_code",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "coverage_details",
                table: "WarrantyExtended",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "warranty_gst_percentage",
                table: "WarrantyExtended",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<decimal>(
                name: "warranty_cost",
                table: "WarrantyExtended",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<decimal>(
                name: "warranty_final_amount",
                table: "WarrantyExtended",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<decimal>(
                name: "warranty_gst_amount",
                table: "WarrantyExtended",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "warranty_period",
                table: "WarrantyExtended",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "IssueReceiptTransWarrantyDetail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<string>(
                name: "warranty_flag",
                table: "IssueReceiptTransWarrantyDetail",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "warranty_cost",
                table: "WarrantyExtended");

            migrationBuilder.DropColumn(
                name: "warranty_final_amount",
                table: "WarrantyExtended");

            migrationBuilder.DropColumn(
                name: "warranty_gst_amount",
                table: "WarrantyExtended");

            migrationBuilder.DropColumn(
                name: "warranty_period",
                table: "WarrantyExtended");

            migrationBuilder.DropColumn(
                name: "warranty_flag",
                table: "IssueReceiptTransWarrantyDetail");

            migrationBuilder.RenameColumn(
                name: "warranty_gst_percentage",
                table: "WarrantyExtended",
                newName: "cost");

            migrationBuilder.AlterColumn<string>(
                name: "warranty_serial_no",
                table: "WarrantyExtended",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "party_code",
                table: "WarrantyExtended",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "item_code",
                table: "WarrantyExtended",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "coverage_details",
                table: "WarrantyExtended",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .Annotation("Relational:ColumnOrder", 0)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "WarrantyExtended",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<long>(
                name: "extended_warranty_Item_id",
                table: "WarrantyExtended",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "IssueReceiptTransWarrantyDetail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 11);
        }
    }
}
