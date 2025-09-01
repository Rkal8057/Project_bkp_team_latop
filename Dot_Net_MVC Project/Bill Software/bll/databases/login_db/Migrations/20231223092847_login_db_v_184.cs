using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_184 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesMaster_PartyMaster_party_id",
                table: "SalesMaster");

            migrationBuilder.DropIndex(
                name: "IX_SalesMaster_party_id",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "party_id",
                table: "SalesMaster");

            migrationBuilder.AlterColumn<decimal>(
                name: "grand_total",
                table: "SalesMaster",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "completion_flag",
                table: "SalesMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<long>(
                name: "PartyMasterid",
                table: "SalesMaster",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "SalesMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "SalesMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "mobile_number",
                table: "SalesMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "SalesMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SalesMaster_PartyMasterid",
                table: "SalesMaster",
                column: "PartyMasterid");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesMaster_PartyMaster_PartyMasterid",
                table: "SalesMaster",
                column: "PartyMasterid",
                principalTable: "PartyMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesMaster_PartyMaster_PartyMasterid",
                table: "SalesMaster");

            migrationBuilder.DropIndex(
                name: "IX_SalesMaster_PartyMasterid",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "PartyMasterid",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "address",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "email",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "mobile_number",
                table: "SalesMaster");

            migrationBuilder.DropColumn(
                name: "name",
                table: "SalesMaster");

            migrationBuilder.AlterColumn<decimal>(
                name: "grand_total",
                table: "SalesMaster",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "completion_flag",
                table: "SalesMaster",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<long>(
                name: "party_id",
                table: "SalesMaster",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.CreateIndex(
                name: "IX_SalesMaster_party_id",
                table: "SalesMaster",
                column: "party_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesMaster_PartyMaster_party_id",
                table: "SalesMaster",
                column: "party_id",
                principalTable: "PartyMaster",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
