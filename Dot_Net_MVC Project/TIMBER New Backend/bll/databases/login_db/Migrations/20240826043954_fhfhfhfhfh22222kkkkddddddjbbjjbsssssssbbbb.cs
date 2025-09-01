using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh22222kkkkddddddjbbjjbsssssssbbbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "DailyTaskTans",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<long>(
                name: "task_trans_delete",
                table: "DailyTaskTans",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.CreateIndex(
                name: "IX_DailyTaskTans_daily_task_id",
                table: "DailyTaskTans",
                column: "daily_task_id");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyTaskTans_DailyTask_daily_task_id",
                table: "DailyTaskTans",
                column: "daily_task_id",
                principalTable: "DailyTask",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyTaskTans_DailyTask_daily_task_id",
                table: "DailyTaskTans");

            migrationBuilder.DropIndex(
                name: "IX_DailyTaskTans_daily_task_id",
                table: "DailyTaskTans");

            migrationBuilder.DropColumn(
                name: "task_trans_delete",
                table: "DailyTaskTans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "DailyTaskTans",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);
        }
    }
}
