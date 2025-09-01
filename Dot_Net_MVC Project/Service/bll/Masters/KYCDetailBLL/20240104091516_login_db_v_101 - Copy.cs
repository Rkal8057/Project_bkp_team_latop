using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CorrespondenceRequest",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reply_date = table.Column<DateTime>(type: "date", nullable: true),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    work_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purpose = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_mobile = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    current_date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceRequest", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "CategoryMaster",
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
                    table.PrimaryKey("PK_CategoryMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CategoryMaster_ServiceMaster_service_id",
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
                    category_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CheckListMaster_CategoryMaster_category_id",
                        column: x => x.category_id,
                        principalTable: "CategoryMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneralRequestedDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    service_id = table.Column<long>(type: "bigint", nullable: true),
                    category_id = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequestedDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralRequestedDetail_CategoryMaster_category_id",
                        column: x => x.category_id,
                        principalTable: "CategoryMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GeneralRequestedDetail_ServiceMaster_service_id",
                        column: x => x.service_id,
                        principalTable: "ServiceMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProcessRequestDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    required_info = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    required_info_data = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_requested_detail_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessRequestDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProcessRequestDetail_GeneralRequestedDetail_general_requeste~",
                        column: x => x.general_requested_detail_id,
                        principalTable: "GeneralRequestedDetail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMaster_service_id",
                table: "CategoryMaster",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListMaster_category_id",
                table: "CheckListMaster",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestedDetail_category_id",
                table: "GeneralRequestedDetail",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestedDetail_service_id",
                table: "GeneralRequestedDetail",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessRequestDetail_general_requested_detail_id",
                table: "ProcessRequestDetail",
                column: "general_requested_detail_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckListMaster");

            migrationBuilder.DropTable(
                name: "CorrespondenceRequest");

            migrationBuilder.DropTable(
                name: "ProcessRequestDetail");

            migrationBuilder.DropTable(
                name: "GeneralRequestedDetail");

            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "ServiceMaster");
        }
    }
}
