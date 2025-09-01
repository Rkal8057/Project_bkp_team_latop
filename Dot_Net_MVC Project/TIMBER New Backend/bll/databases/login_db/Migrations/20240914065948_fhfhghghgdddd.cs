using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhghghgdddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityTranxMaster_ActivityMaster_ActivityMasterid",
                table: "ActivityTranxMaster");

            migrationBuilder.DropIndex(
                name: "IX_ActivityTranxMaster_ActivityMasterid",
                table: "ActivityTranxMaster");

            migrationBuilder.DropColumn(
                name: "ActivityMasterid",
                table: "ActivityTranxMaster");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTranxMaster_activity_master_id",
                table: "ActivityTranxMaster",
                column: "activity_master_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityTranxMaster_ActivityMaster_activity_master_id",
                table: "ActivityTranxMaster",
                column: "activity_master_id",
                principalTable: "ActivityMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityTranxMaster_ActivityMaster_activity_master_id",
                table: "ActivityTranxMaster");

            migrationBuilder.DropIndex(
                name: "IX_ActivityTranxMaster_activity_master_id",
                table: "ActivityTranxMaster");

            migrationBuilder.AddColumn<long>(
                name: "ActivityMasterid",
                table: "ActivityTranxMaster",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTranxMaster_ActivityMasterid",
                table: "ActivityTranxMaster",
                column: "ActivityMasterid");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityTranxMaster_ActivityMaster_ActivityMasterid",
                table: "ActivityTranxMaster",
                column: "ActivityMasterid",
                principalTable: "ActivityMaster",
                principalColumn: "id");
        }
    }
}
