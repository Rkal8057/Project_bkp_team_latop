using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfasqww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_by",
                table: "Remark_Upload_Detail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "flag_master",
                table: "Remark_Upload_Detail",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "Remark_Upload_Detail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_by",
                table: "Remark_Upload_Detail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<long>(
                name: "party_master_id",
                table: "Remark_Upload_Detail",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.CreateIndex(
                name: "IX_Remark_Upload_Detail_party_master_id",
                table: "Remark_Upload_Detail",
                column: "party_master_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_Upload_Detail_PartyMaster_party_master_id",
                table: "Remark_Upload_Detail",
                column: "party_master_id",
                principalTable: "PartyMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remark_Upload_Detail_PartyMaster_party_master_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.DropIndex(
                name: "IX_Remark_Upload_Detail_party_master_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.DropColumn(
                name: "party_master_id",
                table: "Remark_Upload_Detail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_by",
                table: "Remark_Upload_Detail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "flag_master",
                table: "Remark_Upload_Detail",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "Remark_Upload_Detail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_by",
                table: "Remark_Upload_Detail",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 8);
        }
    }
}
