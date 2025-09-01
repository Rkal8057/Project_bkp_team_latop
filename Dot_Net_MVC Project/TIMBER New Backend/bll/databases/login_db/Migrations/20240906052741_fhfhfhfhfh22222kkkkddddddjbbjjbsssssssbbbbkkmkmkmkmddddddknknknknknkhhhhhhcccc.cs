using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhfhfhfh22222kkkkddddddjbbjjbsssssssbbbbkkmkmkmkmddddddknknknknknkhhhhhhcccc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralRequestRemark",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    general_request_id = table.Column<long>(type: "bigint", nullable: true),
                    general_req_key_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequestRemark", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralRequestRemark_GeneralRequestedDetail_general_request_~",
                        column: x => x.general_request_id,
                        principalTable: "GeneralRequestedDetail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestRemark_general_request_id",
                table: "GeneralRequestRemark",
                column: "general_request_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralRequestRemark");
        }
    }
}
