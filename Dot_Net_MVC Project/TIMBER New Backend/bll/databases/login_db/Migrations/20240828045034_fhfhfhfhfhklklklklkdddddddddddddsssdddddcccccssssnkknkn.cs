using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhklklklklkdddddddddddddsssdddddcccccssssnkknkn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "task_status",
                table: "DailyTaskTans",
                newName: "task_work_status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "task_work_status",
                table: "DailyTaskTans",
                newName: "task_status");
        }
    }
}
