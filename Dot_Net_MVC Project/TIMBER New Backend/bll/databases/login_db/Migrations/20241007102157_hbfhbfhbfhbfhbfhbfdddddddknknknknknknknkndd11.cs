using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hbfhbfhbfhbfhbfhbfdddddddknknknknknknknkndd11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "warranty_master_id",
                table: "WarrantyExtendedItemTran",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "long",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "warranty_item_mode",
                table: "WarrantyExtended",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "warranty_item_mode",
                table: "WarrantyExtended");

            migrationBuilder.AlterColumn<long>(
                name: "warranty_master_id",
                table: "WarrantyExtendedItemTran",
                type: "long",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
