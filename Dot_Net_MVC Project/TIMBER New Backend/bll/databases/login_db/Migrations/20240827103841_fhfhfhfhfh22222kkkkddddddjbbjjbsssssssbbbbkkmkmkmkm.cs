using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh22222kkkkddddddjbbjjbsssssssbbbbkkmkmkmkm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "created_by",
                table: "DailyTaskTans",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_by",
                table: "DailyTaskTans");
        }
    }
}
