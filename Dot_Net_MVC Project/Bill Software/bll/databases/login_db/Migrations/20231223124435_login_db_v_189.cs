using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_189 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesTrxMaster_SalesMaster_sales_master_id",
                table: "SalesTrxMaster");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "SalesTrxMaster");

            migrationBuilder.AlterColumn<long>(
                name: "sales_master_id",
                table: "SalesTrxMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "item_rate",
                table: "SalesTrxMaster",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "item_qty",
                table: "SalesTrxMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<decimal>(
                name: "item_amount",
                table: "SalesTrxMaster",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "mobile_number",
                table: "SalesMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesTrxMaster_SalesMaster_sales_master_id",
                table: "SalesTrxMaster",
                column: "sales_master_id",
                principalTable: "SalesMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesTrxMaster_SalesMaster_sales_master_id",
                table: "SalesTrxMaster");

            migrationBuilder.DropColumn(
                name: "item_amount",
                table: "SalesTrxMaster");

            migrationBuilder.AlterColumn<long>(
                name: "sales_master_id",
                table: "SalesTrxMaster",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "item_rate",
                table: "SalesTrxMaster",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "item_qty",
                table: "SalesTrxMaster",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "SalesTrxMaster",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "mobile_number",
                table: "SalesMaster",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesTrxMaster_SalesMaster_sales_master_id",
                table: "SalesTrxMaster",
                column: "sales_master_id",
                principalTable: "SalesMaster",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
