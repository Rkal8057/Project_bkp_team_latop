using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhghghgkkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_on",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<long>(
                name: "delete",
                table: "ActivityMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 14)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<string>(
                name: "activity_maintain_type",
                table: "ActivityMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "endDate",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.CreateTable(
                name: "ActivityTranxMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    slot_start = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slot_end = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duration = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_master_id = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    ActivityMasterid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTranxMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_ActivityTranxMaster_ActivityMaster_ActivityMasterid",
                        column: x => x.ActivityMasterid,
                        principalTable: "ActivityMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTranxMaster_ActivityMasterid",
                table: "ActivityTranxMaster",
                column: "ActivityMasterid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTranxMaster");

            migrationBuilder.DropColumn(
                name: "activity_maintain_type",
                table: "ActivityMaster");

            migrationBuilder.DropColumn(
                name: "endDate",
                table: "ActivityMaster");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "ActivityMaster");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_on",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 13);

            migrationBuilder.AlterColumn<long>(
                name: "delete",
                table: "ActivityMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("Relational:ColumnOrder", 14);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "ActivityMaster",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 12);
        }
    }
}
