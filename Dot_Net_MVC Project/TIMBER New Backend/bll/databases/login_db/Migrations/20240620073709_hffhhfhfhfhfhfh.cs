using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hffhhfhfhfhfhfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "vou_trn_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 21);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "vou_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "vou_list_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 13);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "UploadDocument",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "System_Records",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 95);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "Remark_Upload_Detail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "RecieptDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 31);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 43);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyItemRateTrans",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 30);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyContactTransMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 17);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyCategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "PartyAddressTransMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "ItemTransStockDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 14);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "ItemTransMixDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "ItemMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 51);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "IssueReceiptTransDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 40);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "IssueReceiptMiscTransDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "IssueReceiptMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 139);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "IssueReceiptBreakageTransDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "IssueItemExtraDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "ExtraDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "EMIDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "Challan_Single_Item_Master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "CategoryMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "CaseMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 41);

            migrationBuilder.AddColumn<long>(
                name: "old_software_code_ya_id",
                table: "AggrementMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "vou_trn_master");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "vou_master");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "vou_list_master");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "UploadDocument");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "RecieptDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "PartyItemRateTrans");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "PartyContactTransMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "PartyCategoryMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "PartyAddressTransMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "ItemTransStockDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "ItemTransMixDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "ItemMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "IssueReceiptTransDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "IssueReceiptMiscTransDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "IssueReceiptMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "IssueReceiptBreakageTransDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "IssueItemExtraDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "ExtraDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "EMIDetail");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "Challan_Single_Item_Master");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "CaseMaster");

            migrationBuilder.DropColumn(
                name: "old_software_code_ya_id",
                table: "AggrementMaster");
        }
    }
}
