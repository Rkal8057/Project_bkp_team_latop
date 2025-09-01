using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class hgfhfhfhffsw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill_Rent_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bill_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_upto = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_from = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_to = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    itemname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    open_stock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    iss_stock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    rec_stock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    close_stock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    days = table.Column<long>(type: "bigint", nullable: true),
                    numbers = table.Column<long>(type: "bigint", nullable: true),
                    amt_number_wise = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    rent_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    vat_cst = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    vat_per = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tax_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    rounded_off_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    amt_after_vat_cst = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    cartage_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    trip_nos = table.Column<long>(type: "bigint", nullable: true),
                    misc_charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    misc_charges_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gross_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    outstanding_amt_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    outstanding_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    payment_rec_in_period = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    amount_due = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    amt_in_words = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    breakage_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    missing_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    add1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_from_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_to_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date_2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    final_y_n = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    invoice_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_on_pp_pc_rmt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_uni_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_item_balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    billno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    challanno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    auto_matic_billno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    igst_per = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    igst_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sgst_per = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sgst_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    cgst_per = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    cgst_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gst_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    b_hsn_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_name = table.Column<string>(type: " text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_gstno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_Rent_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_Rent_Master");
        }
    }
}
