using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jjrjrjr : Migration
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
                .Annotation("Relational:ColumnOrder", 42)
                .OldAnnotation("Relational:ColumnOrder", 41);

            migrationBuilder.AddColumn<string>(
                name: "case_master_case_no",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "case_master_case_no",
                table: "PartyMaster");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 41)
                .OldAnnotation("Relational:ColumnOrder", 42);
        }
    }
}
