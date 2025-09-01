using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "master_id",
                table: "Remark_Upload_Detail",
                newName: "item_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_Upload_Detail_item_master_id",
                table: "Remark_Upload_Detail",
                column: "item_master_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_Upload_Detail_ItemMaster_item_master_id",
                table: "Remark_Upload_Detail",
                column: "item_master_id",
                principalTable: "ItemMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remark_Upload_Detail_ItemMaster_item_master_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Remark_Upload_Detail_item_master_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.RenameColumn(
                name: "item_master_id",
                table: "Remark_Upload_Detail",
                newName: "master_id");
        }
    }
}
