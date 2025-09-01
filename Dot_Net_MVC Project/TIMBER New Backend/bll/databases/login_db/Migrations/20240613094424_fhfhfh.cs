using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueReceiptTransDetail_AggrementMaster_aggrement_id",
                table: "IssueReceiptTransDetail");

            migrationBuilder.DropIndex(
                name: "IX_IssueReceiptTransDetail_aggrement_id",
                table: "IssueReceiptTransDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptTransDetail_aggrement_id",
                table: "IssueReceiptTransDetail",
                column: "aggrement_id");

            migrationBuilder.AddForeignKey(
                name: "FK_IssueReceiptTransDetail_AggrementMaster_aggrement_id",
                table: "IssueReceiptTransDetail",
                column: "aggrement_id",
                principalTable: "AggrementMaster",
                principalColumn: "id");
        }
    }
}
