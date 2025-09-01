using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhssssqqqmmmmnknnkknkknknnnnnnnnnnnddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Partyid",
                table: "GeneralRequestedDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestedDetail_Partyid",
                table: "GeneralRequestedDetail",
                column: "Partyid");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralRequestedDetail_PartyMaster_Partyid",
                table: "GeneralRequestedDetail",
                column: "Partyid",
                principalTable: "PartyMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralRequestedDetail_PartyMaster_Partyid",
                table: "GeneralRequestedDetail");

            migrationBuilder.DropIndex(
                name: "IX_GeneralRequestedDetail_Partyid",
                table: "GeneralRequestedDetail");

            migrationBuilder.DropColumn(
                name: "Partyid",
                table: "GeneralRequestedDetail");
        }
    }
}
