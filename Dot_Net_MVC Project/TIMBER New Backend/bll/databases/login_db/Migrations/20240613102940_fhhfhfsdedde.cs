using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhhfhfsdedde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PartyMasterid",
                table: "SalesMaster",
                type: "bigint",
                nullable: true);

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
    }
}
