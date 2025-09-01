using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class v106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Registration_History_user_profile_master_user_profile_id",
                table: "User_Registration_History");

            migrationBuilder.DropIndex(
                name: "IX_User_Registration_History_user_code",
                table: "User_Registration_History");

            migrationBuilder.DropIndex(
                name: "IX_User_Registration_History_user_profile_id",
                table: "User_Registration_History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User_Registration_History_user_code",
                table: "User_Registration_History",
                column: "user_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Registration_History_user_profile_id",
                table: "User_Registration_History",
                column: "user_profile_id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Registration_History_user_profile_master_user_profile_id",
                table: "User_Registration_History",
                column: "user_profile_id",
                principalTable: "user_profile_master",
                principalColumn: "id");
        }
    }
}
