using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hffhhfhfhfhfhfhjbvjbjbjbjbjb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "item_short_code",
                table: "ItemMaster",
                newName: "item_short_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "item_short_name",
                table: "ItemMaster",
                newName: "item_short_code");
        }
    }
}
