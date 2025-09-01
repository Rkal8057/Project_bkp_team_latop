using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhnknkknnknknnssas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 41)
                .OldAnnotation("Relational:ColumnOrder", 39);

            migrationBuilder.AddColumn<string>(
                name: "relation_type",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "swh_Name",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "case_Finance_Company",
                table: "CaseMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "case_Financed_Type",
                table: "CaseMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "case_relation_type",
                table: "CaseMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "relation_type",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "swh_Name",
                table: "PartyMaster");

            migrationBuilder.DropColumn(
                name: "case_Finance_Company",
                table: "CaseMaster");

            migrationBuilder.DropColumn(
                name: "case_Financed_Type",
                table: "CaseMaster");

            migrationBuilder.DropColumn(
                name: "case_relation_type",
                table: "CaseMaster");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 39)
                .OldAnnotation("Relational:ColumnOrder", 41);
        }
    }
}
