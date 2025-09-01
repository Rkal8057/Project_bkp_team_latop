using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class gfggfgfgfgfgfgfw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "vou_gross_amt",
                table: "vou_trn_master",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 24);

            migrationBuilder.AddColumn<decimal>(
                name: "vou_gst_amt",
                table: "vou_trn_master",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 22);

            migrationBuilder.AddColumn<decimal>(
                name: "vou_gst_per",
                table: "vou_trn_master",
                type: "decimal(18,2)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 23);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vou_gross_amt",
                table: "vou_trn_master");

            migrationBuilder.DropColumn(
                name: "vou_gst_amt",
                table: "vou_trn_master");

            migrationBuilder.DropColumn(
                name: "vou_gst_per",
                table: "vou_trn_master");
        }
    }
}
