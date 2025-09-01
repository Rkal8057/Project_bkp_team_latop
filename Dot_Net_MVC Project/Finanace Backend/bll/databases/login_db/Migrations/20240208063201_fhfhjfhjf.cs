using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class fhfhjfhjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMaster");

            migrationBuilder.DropTable(
                name: "SalesTrxMaster");

            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "SalesMaster");

            migrationBuilder.DropTable(
                name: "PartyMaster");

            migrationBuilder.AlterColumn<string>(
                name: "receipt_Instalment_No",
                table: "RecieptDetail",
                type: "text",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_pincode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_country = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_phone = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HelperDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_id = table.Column<long>(type: "bigint", nullable: true),
                    image_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelperDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_HelperDetail_CompanyDetail_company_id",
                        column: x => x.company_id,
                        principalTable: "CompanyDetail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_HelperDetail_company_id",
                table: "HelperDetail",
                column: "company_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelperDetail");

            migrationBuilder.DropTable(
                name: "CompanyDetail");

            migrationBuilder.AlterColumn<long>(
                name: "receipt_Instalment_No",
                table: "RecieptDetail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    active = table.Column<ulong>(type: "bit", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete_at = table.Column<ulong>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartyMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mobile_number = table.Column<long>(type: "bigint", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pincode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_id = table.Column<long>(type: "bigint", nullable: true),
                    item_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_amount = table.Column<long>(type: "bigint", nullable: true),
                    active = table.Column<ulong>(type: "bit", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete_at = table.Column<ulong>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItemMaster_CategoryMaster_category_id",
                        column: x => x.category_id,
                        principalTable: "CategoryMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sales_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mobile_number = table.Column<long>(type: "bigint", nullable: true),
                    completion_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grand_total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount_percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    grand_total_after_discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PartyMasterid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalesMaster_PartyMaster_PartyMasterid",
                        column: x => x.PartyMasterid,
                        principalTable: "PartyMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesTrxMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_qty = table.Column<long>(type: "bigint", nullable: true),
                    item_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sales_master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTrxMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalesTrxMaster_SalesMaster_sales_master_id",
                        column: x => x.sales_master_id,
                        principalTable: "SalesMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMaster_category_id",
                table: "ItemMaster",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesMaster_PartyMasterid",
                table: "SalesMaster",
                column: "PartyMasterid");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTrxMaster_sales_master_id",
                table: "SalesTrxMaster",
                column: "sales_master_id");
        }
    }
}
