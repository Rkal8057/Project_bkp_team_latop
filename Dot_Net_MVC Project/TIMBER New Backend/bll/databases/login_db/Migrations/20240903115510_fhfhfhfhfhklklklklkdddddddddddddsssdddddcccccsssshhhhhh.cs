using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhklklklklkdddddddddddddsssdddddcccccsssshhhhhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "party_id",
                table: "GeneralRequestedDetail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 31);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "party_id",
                table: "GeneralRequestedDetail");
        }
    }
}
