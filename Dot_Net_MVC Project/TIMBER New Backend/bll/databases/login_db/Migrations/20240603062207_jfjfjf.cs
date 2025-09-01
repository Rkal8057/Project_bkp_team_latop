using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjf : Migration
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
                .Annotation("Relational:ColumnOrder", 32)
                .OldAnnotation("Relational:ColumnOrder", 31);

            migrationBuilder.AddColumn<string>(
                name: "agreement_yn",
                table: "PartyMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "agreement_yn",
                table: "PartyMaster");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 31)
                .OldAnnotation("Relational:ColumnOrder", 32);
        }
    }
}
