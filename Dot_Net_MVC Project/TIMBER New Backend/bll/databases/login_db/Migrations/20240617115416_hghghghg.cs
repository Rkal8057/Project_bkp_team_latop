using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hghghghg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "status",
                table: "vou_trn_master",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 20)
                .OldAnnotation("Relational:ColumnOrder", 18);

            migrationBuilder.AddColumn<long>(
                name: "month",
                table: "vou_trn_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 18);

            migrationBuilder.AddColumn<long>(
                name: "year",
                table: "vou_trn_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 19);

            migrationBuilder.AddColumn<long>(
                name: "month",
                table: "vou_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 19);

            migrationBuilder.AddColumn<long>(
                name: "year",
                table: "vou_master",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "month",
                table: "vou_trn_master");

            migrationBuilder.DropColumn(
                name: "year",
                table: "vou_trn_master");

            migrationBuilder.DropColumn(
                name: "month",
                table: "vou_master");

            migrationBuilder.DropColumn(
                name: "year",
                table: "vou_master");

            migrationBuilder.AlterColumn<long>(
                name: "status",
                table: "vou_trn_master",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 18)
                .OldAnnotation("Relational:ColumnOrder", 20);
        }
    }
}
