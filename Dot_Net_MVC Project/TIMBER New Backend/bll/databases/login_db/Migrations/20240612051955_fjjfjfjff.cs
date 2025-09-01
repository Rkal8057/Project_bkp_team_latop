using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjjfjfjff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "case_relation_type",
                table: "CaseMaster",
                newName: "Case_Relation_Type");

            migrationBuilder.RenameColumn(
                name: "case_financed_item",
                table: "CaseMaster",
                newName: "Case_Financed_Item");

            migrationBuilder.RenameColumn(
                name: "case_Financed_Type",
                table: "CaseMaster",
                newName: "Case_Financed_Type");

            migrationBuilder.RenameColumn(
                name: "case_Finance_Company",
                table: "CaseMaster",
                newName: "Case_Finance_Company");

            migrationBuilder.RenameColumn(
                name: "case_Duration_Value",
                table: "CaseMaster",
                newName: "Case_Duration_Value");

            migrationBuilder.RenameColumn(
                name: "case_Duration_Type",
                table: "CaseMaster",
                newName: "Case_Duration_Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Case_Relation_Type",
                table: "CaseMaster",
                newName: "case_relation_type");

            migrationBuilder.RenameColumn(
                name: "Case_Financed_Type",
                table: "CaseMaster",
                newName: "case_Financed_Type");

            migrationBuilder.RenameColumn(
                name: "Case_Financed_Item",
                table: "CaseMaster",
                newName: "case_financed_item");

            migrationBuilder.RenameColumn(
                name: "Case_Finance_Company",
                table: "CaseMaster",
                newName: "case_Finance_Company");

            migrationBuilder.RenameColumn(
                name: "Case_Duration_Value",
                table: "CaseMaster",
                newName: "case_Duration_Value");

            migrationBuilder.RenameColumn(
                name: "Case_Duration_Type",
                table: "CaseMaster",
                newName: "case_Duration_Type");
        }
    }
}
