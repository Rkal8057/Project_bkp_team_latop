using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjjjgjgjgjgjgjggssswwwwwsssssssssswwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckListMaster_CategoryMaster_category_id",
                table: "CheckListMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_ServiceSubCategoryM~",
                table: "CheckListMaster");

            migrationBuilder.DropIndex(
                name: "IX_CheckListMaster_ServiceSubCategoryMasterid",
                table: "CheckListMaster");

            migrationBuilder.DropColumn(
                name: "ServiceSubCategoryMasterid",
                table: "CheckListMaster");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_category_id",
                table: "CheckListMaster",
                column: "category_id",
                principalTable: "ServiceSubCategoryMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_category_id",
                table: "CheckListMaster");

            migrationBuilder.AddColumn<long>(
                name: "ServiceSubCategoryMasterid",
                table: "CheckListMaster",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckListMaster_ServiceSubCategoryMasterid",
                table: "CheckListMaster",
                column: "ServiceSubCategoryMasterid");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckListMaster_CategoryMaster_category_id",
                table: "CheckListMaster",
                column: "category_id",
                principalTable: "CategoryMaster",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_ServiceSubCategoryM~",
                table: "CheckListMaster",
                column: "ServiceSubCategoryMasterid",
                principalTable: "ServiceSubCategoryMaster",
                principalColumn: "id");
        }
    }
}
