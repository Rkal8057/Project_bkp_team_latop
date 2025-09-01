using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh22222kkkkdddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_category_id",
                table: "CheckListMaster");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "CheckListMaster",
                newName: "subservice_id");

            migrationBuilder.RenameIndex(
                name: "IX_CheckListMaster_category_id",
                table: "CheckListMaster",
                newName: "IX_CheckListMaster_subservice_id");

            migrationBuilder.AddColumn<long>(
                name: "item_category_sub_id",
                table: "ServiceSubCategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<long>(
                name: "item_category_main_id",
                table: "ServiceMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<long>(
                name: "helper_master_document_id",
                table: "CheckListMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<long>(
                name: "service_id",
                table: "CheckListMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_subservice_id",
                table: "CheckListMaster",
                column: "subservice_id",
                principalTable: "ServiceSubCategoryMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_subservice_id",
                table: "CheckListMaster");

            migrationBuilder.DropColumn(
                name: "item_category_sub_id",
                table: "ServiceSubCategoryMaster");

            migrationBuilder.DropColumn(
                name: "item_category_main_id",
                table: "ServiceMaster");

            migrationBuilder.DropColumn(
                name: "helper_master_document_id",
                table: "CheckListMaster");

            migrationBuilder.DropColumn(
                name: "service_id",
                table: "CheckListMaster");

            migrationBuilder.RenameColumn(
                name: "subservice_id",
                table: "CheckListMaster",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_CheckListMaster_subservice_id",
                table: "CheckListMaster",
                newName: "IX_CheckListMaster_category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckListMaster_ServiceSubCategoryMaster_category_id",
                table: "CheckListMaster",
                column: "category_id",
                principalTable: "ServiceSubCategoryMaster",
                principalColumn: "id");
        }
    }
}
