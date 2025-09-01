using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfhsasasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyContactTransMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 16)
                .OldAnnotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<long>(
                name: "case_master_id",
                table: "PartyContactTransMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyAddressTransMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 13)
                .OldAnnotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<long>(
                name: "case_master_id",
                table: "PartyAddressTransMaster",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<string>(
                name: "Hire_Name",
                table: "CaseMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Hire_SWH_Name",
                table: "CaseMaster",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PartyContactTransMaster_case_master_id",
                table: "PartyContactTransMaster",
                column: "case_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyAddressTransMaster_case_master_id",
                table: "PartyAddressTransMaster",
                column: "case_master_id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartyAddressTransMaster_CaseMaster_case_master_id",
                table: "PartyAddressTransMaster",
                column: "case_master_id",
                principalTable: "CaseMaster",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartyContactTransMaster_CaseMaster_case_master_id",
                table: "PartyContactTransMaster",
                column: "case_master_id",
                principalTable: "CaseMaster",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartyAddressTransMaster_CaseMaster_case_master_id",
                table: "PartyAddressTransMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PartyContactTransMaster_CaseMaster_case_master_id",
                table: "PartyContactTransMaster");

            migrationBuilder.DropIndex(
                name: "IX_PartyContactTransMaster_case_master_id",
                table: "PartyContactTransMaster");

            migrationBuilder.DropIndex(
                name: "IX_PartyAddressTransMaster_case_master_id",
                table: "PartyAddressTransMaster");

            migrationBuilder.DropColumn(
                name: "case_master_id",
                table: "PartyContactTransMaster");

            migrationBuilder.DropColumn(
                name: "case_master_id",
                table: "PartyAddressTransMaster");

            migrationBuilder.DropColumn(
                name: "Hire_Name",
                table: "CaseMaster");

            migrationBuilder.DropColumn(
                name: "Hire_SWH_Name",
                table: "CaseMaster");

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyContactTransMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 15)
                .OldAnnotation("Relational:ColumnOrder", 16);

            migrationBuilder.AlterColumn<long>(
                name: "delete_at",
                table: "PartyAddressTransMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 12)
                .OldAnnotation("Relational:ColumnOrder", 13);
        }
    }
}
