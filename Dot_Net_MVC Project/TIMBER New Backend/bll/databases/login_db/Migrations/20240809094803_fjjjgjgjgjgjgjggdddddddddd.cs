using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fjjjgjgjgjgjgjggdddddddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    service_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceSubCategoryMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    service_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approx_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    approx_days = table.Column<int>(type: "int", nullable: true),
                    service_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSubCategoryMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_ServiceSubCategoryMaster_ServiceMaster_service_id",
                        column: x => x.service_id,
                        principalTable: "ServiceMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CheckListMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    document_required_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_required_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_id = table.Column<long>(type: "bigint", nullable: true),
                    ServiceSubCategoryMasterid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CheckListMaster_CategoryMaster_category_id",
                        column: x => x.category_id,
                        principalTable: "CategoryMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CheckListMaster_ServiceSubCategoryMaster_ServiceSubCategoryM~",
                        column: x => x.ServiceSubCategoryMasterid,
                        principalTable: "ServiceSubCategoryMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListMaster_category_id",
                table: "CheckListMaster",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListMaster_ServiceSubCategoryMasterid",
                table: "CheckListMaster",
                column: "ServiceSubCategoryMasterid");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSubCategoryMaster_service_id",
                table: "ServiceSubCategoryMaster",
                column: "service_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckListMaster");

            migrationBuilder.DropTable(
                name: "ServiceSubCategoryMaster");

            migrationBuilder.DropTable(
                name: "ServiceMaster");
        }
    }
}
