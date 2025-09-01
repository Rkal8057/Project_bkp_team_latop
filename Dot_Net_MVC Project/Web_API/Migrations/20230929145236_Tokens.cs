using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API.Migrations
{
    /// <inheritdoc />
    public partial class Tokens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Tokens",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   UserId = table.Column<int>(type: "int", nullable: false),
                   Tokens = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                   FcmToken = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                   DeviceId = table.Column<string>(type: "nvarchar(250)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Tokens", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Tokens");

        }
    }
}
