using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActivityMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    activity_name_id = table.Column<long>(type: "bigint", nullable: true),
                    activity_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_date = table.Column<DateTime>(type: "date", nullable: true),
                    activity_time = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_duration = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_note = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    activity_start_time = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_end_time = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_maintain_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActivityNameMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    activity_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityNameMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auth_Token",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    crypto_key = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_code = table.Column<long>(type: "bigint(10)", nullable: false),
                    creation_dttm = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_Token", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "balance_sheet_master",
                columns: table => new
                {
                    cat_code = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cat_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_main = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supermain = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drcr = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    todo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    window = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mindex = table.Column<long>(type: "bigint", nullable: true),
                    del_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balance_sheet_master", x => x.cat_code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "BlogMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_category_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_content = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    blog_status = table.Column<long>(type: "bigint", nullable: true),
                    deleted = table.Column<long>(type: "bigint", nullable: true),
                    img_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    icon_img_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BusinessContent",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    label = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    label_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    icon = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    button_alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    business_section_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    business_section_id = table.Column<long>(type: "bigint", nullable: true),
                    business_user_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    business_content_hide = table.Column<long>(type: "bigint", nullable: true),
                    content_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessContent", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BusinessSection",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_font_size = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    section_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    business_user_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    business_section_hide = table.Column<long>(type: "bigint", nullable: true),
                    section_multiple = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    section_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSection", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BusinessUserDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_img = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_id = table.Column<long>(type: "bigint", nullable: true),
                    party_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    theme_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    user_profile_id = table.Column<long>(type: "bigint", nullable: true),
                    user_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUserDetail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BussinessUserContentDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    label = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    label_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    icon = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    button_alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    business_section_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    business_section_id = table.Column<long>(type: "bigint", nullable: true),
                    business_user_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    business_content_hide = table.Column<long>(type: "bigint", nullable: true),
                    content_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    drop_value = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussinessUserContentDetail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BussinessUserSectionDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_alignment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_bold = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_font_size = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    section_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    business_user_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    business_section_hide = table.Column<long>(type: "bigint", nullable: true),
                    section_multiple = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    section_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BussinessUserSectionDetail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CaseMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Case_Financed_Item = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Finance_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Duration_Value = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Duration_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Instalments = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Montly_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_Amt_Due = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_Cost = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_ADVANCE_REQ = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_TOTAL_ADV_REQ = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Due_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Case_Payment_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Chq_NO = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Case_Remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Interest_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_F_O_CHARGE = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_hp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_X = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Rate_of_Interest = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_hp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Extra_Inst = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Instalments_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Finance_Amt_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Pending_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_end_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Case_Manual_Lg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Dealer_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Curr_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Case_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Case_stage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Ac_Close = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Ac_Close_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Case_Block_YN = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Financed_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Finance_Company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Relation_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_F_O_Select = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_RoundOff_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    delete_at = table.Column<ulong>(type: "bit", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    category_content = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_image = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    online_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    balance_sheet_id = table.Column<long>(type: "bigint", nullable: true),
                    balance_sheet_cate_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_id_if_sub_Selected = table.Column<long>(type: "bigint", nullable: true),
                    cate_name_if_sub_Selected = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    super_cate_id = table.Column<long>(type: "bigint", nullable: true),
                    table_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClientMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_feedback = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_status = table.Column<long>(type: "bigint", nullable: true),
                    deleted = table.Column<long>(type: "bigint", nullable: true),
                    img_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    irflag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    firstname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phn_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subject = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    message = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seen_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sent_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    seen_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seen_by_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DailyTask",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    task_title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_priority = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_mode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_assigned_by = table.Column<long>(type: "bigint", nullable: true),
                    task_delete = table.Column<long>(type: "bigint", nullable: true),
                    task_schedule_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specific_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_schedule_time = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_single_day = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTask", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Form_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    form_id = table.Column<int>(type: "int(10)", nullable: false),
                    form_name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_table = table.Column<string>(type: "varchar(90)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_created_type = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_for_id = table.Column<int>(type: "int(10)", nullable: false),
                    form_for = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_significance = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_title = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_sub_title = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_save = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_head = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_groups = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_groups_hidden = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_created_on = table.Column<DateTime>(type: "datetime", nullable: false),
                    form_updated_on = table.Column<DateTime>(type: "datetime", nullable: false),
                    form_verification = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_status = table.Column<int>(type: "int(2)", nullable: false),
                    form_search_control_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_view_control_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_form_for = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_form_type = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_cate = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    segm = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gran_acce_to_prof = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grant_access_profile = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_display_in_dashboard = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_group = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    active_section = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock_field_name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_have_stock_item = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock_field_name_2 = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock_field_display_name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quick_menu_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quick_link_menu_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock_field_name_4_min_inventory = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    user_profile = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_mobile = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "forms_master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    form_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_table = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_title = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_display_status = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_master_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    form_display_color = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_href = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    user_profile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forms_master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HelperFlagMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    helper_flag_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    active = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelperFlagMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HelperMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    form_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_data = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deleted = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelperMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueReceiptMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    billno_automatic = table.Column<long>(type: "bigint", nullable: true),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    pname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pname_short_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_code_old = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_no_old = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_short_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_group_code = table.Column<long>(type: "bigint", nullable: true),
                    item_group_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    challanno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_qty = table.Column<double>(type: "double", nullable: true),
                    recv_qty = table.Column<double>(type: "double", nullable: true),
                    irflag = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billfr = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    billto = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    rent_rate = table.Column<double>(type: "double", nullable: true),
                    broken_amt = table.Column<double>(type: "double", nullable: true),
                    frshop = table.Column<double>(type: "double", nullable: true),
                    froffice = table.Column<double>(type: "double", nullable: true),
                    brok_qty = table.Column<double>(type: "double", nullable: true),
                    brok_rate = table.Column<double>(type: "double", nullable: true),
                    miss_flag = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    misc_ac_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    misc_exp_total = table.Column<double>(type: "double", nullable: true),
                    cartcode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_amt = table.Column<double>(type: "double", nullable: true),
                    remark_note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prnnarr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stkvalue = table.Column<double>(type: "double", nullable: true),
                    misc1 = table.Column<double>(type: "double", nullable: true),
                    misc2 = table.Column<double>(type: "double", nullable: true),
                    misc3 = table.Column<double>(type: "double", nullable: true),
                    misc4 = table.Column<double>(type: "double", nullable: true),
                    misc5 = table.Column<double>(type: "double", nullable: true),
                    misc6 = table.Column<double>(type: "double", nullable: true),
                    sno = table.Column<long>(type: "bigint", nullable: true),
                    contact_prs_ph = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transporter_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gr_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vehicleno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    driver_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dl_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    permit_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_prs_ph_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apx_weight = table.Column<double>(type: "double", nullable: true),
                    apx_value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_enter_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    trip_no = table.Column<long>(type: "bigint", nullable: true),
                    bill_amt = table.Column<double>(type: "double", nullable: true),
                    rec_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tnx_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unit_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    itemtype = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_code = table.Column<long>(type: "bigint", nullable: true),
                    tax_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_per = table.Column<double>(type: "double", nullable: true),
                    tax_amt = table.Column<double>(type: "double", nullable: true),
                    dis_per = table.Column<double>(type: "double", nullable: true),
                    dis_amt = table.Column<double>(type: "double", nullable: true),
                    gross_amt = table.Column<double>(type: "double", nullable: true),
                    tot_qty = table.Column<double>(type: "double", nullable: true),
                    add_off_site = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hsn_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_yn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    igst_per = table.Column<double>(type: "double", nullable: true),
                    igst_amt = table.Column<double>(type: "double", nullable: true),
                    sgst_per = table.Column<double>(type: "double", nullable: true),
                    sgst_amt = table.Column<double>(type: "double", nullable: true),
                    cgst_per = table.Column<double>(type: "double", nullable: true),
                    cgst_amt = table.Column<double>(type: "double", nullable: true),
                    reverse_charge = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    electronic_ref_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weight_of_one_pcs = table.Column<double>(type: "double", nullable: true),
                    tot_weight_of_pcs = table.Column<double>(type: "double", nullable: true),
                    manual_billno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ord_date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_code = table.Column<double>(type: "double", nullable: true),
                    trx_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pkg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_form = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    net_amt = table.Column<double>(type: "double", nullable: true),
                    tot_amt = table.Column<double>(type: "double", nullable: true),
                    transporter_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fraight = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_prs = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    site_add = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    todo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    amt_in_wor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duedate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    round_off_yn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    round_off_amt = table.Column<double>(type: "double", nullable: true),
                    station_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qty_kg = table.Column<double>(type: "double", nullable: true),
                    tot_kg = table.Column<double>(type: "double", nullable: true),
                    add1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add3_location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add4_city = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add5_state = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add6_pincode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add7_state_code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addr_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    addr_gst_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gstno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rent_on_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    opening_qty = table.Column<double>(type: "double", nullable: true),
                    issued_bal_on_chal_date = table.Column<double>(type: "double", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    contact_prs_whts_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    irflag_detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_po_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cart_po_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_transport_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_fraight_topay_paid = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_amt_transporter = table.Column<float>(type: "float", nullable: true),
                    cart_per_tax_transporter = table.Column<float>(type: "float", nullable: true),
                    cart_amt_with_gst_transporter = table.Column<float>(type: "float", nullable: true),
                    cart_amt_final = table.Column<float>(type: "float", nullable: true),
                    cart_tcs_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    station = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    roundoff_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    roundoff_amount = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    cart_tcs_value = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    cart_tax_amount_transporter = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    cart_amt_maintain_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_transporter_cartage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_tcs_percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    final_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReceiptMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_short_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group_id = table.Column<long>(type: "bigint", nullable: true),
                    hsn_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_per = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    convertion_of_pcs = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price_purchase_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_value_per_pcs = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_avg_weight_per_pcs = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_opening_stock_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    opening_stock_shop = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    stock_shop = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    opening_stock_godown = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    stock_godown = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_stock = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    item_packing_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price_purchase_discount_percentage = table.Column<float>(type: "float", nullable: true),
                    price_purchase_discount_amt = table.Column<float>(type: "float", nullable: true),
                    price_purchase_amount_after_discount = table.Column<float>(type: "float", nullable: true),
                    price_purchase_packing_cost = table.Column<float>(type: "float", nullable: true),
                    price_purchase_packing_cost_incl_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price_purchase_amount_with_packing_cost = table.Column<float>(type: "float", nullable: true),
                    price_purchase_gst_percentage = table.Column<float>(type: "float", nullable: true),
                    price_purchase_gst_amount = table.Column<float>(type: "float", nullable: true),
                    price_purchase_amount_with_gst = table.Column<float>(type: "float", nullable: true),
                    price_purchase_margin_profit_percentage = table.Column<float>(type: "float", nullable: true),
                    price_purchase_margin_profit_amount = table.Column<float>(type: "float", nullable: true),
                    price_purchase_rate_approx = table.Column<float>(type: "float", nullable: true),
                    price_sell_rate = table.Column<float>(type: "float", nullable: true),
                    price_sell_discount_percentage = table.Column<float>(type: "float", nullable: true),
                    price_sell_discount_amount = table.Column<float>(type: "float", nullable: true),
                    price_sell_amount_after_discount = table.Column<float>(type: "float", nullable: true),
                    price_sell_gst_percentage = table.Column<float>(type: "float", nullable: true),
                    price_sell_gst_amount = table.Column<float>(type: "float", nullable: true),
                    price_sell_amount_with_gst = table.Column<float>(type: "float", nullable: true),
                    item_barcode_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_remark_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purchase_unit_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purchase_unit_qty = table.Column<float>(type: "float", nullable: true),
                    sale_unit_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_min_qty = table.Column<float>(type: "float", nullable: true),
                    item_reorder_qty = table.Column<float>(type: "float", nullable: true),
                    item_max_qty = table.Column<float>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    warranty_yes_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_period = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Multi_Purpose_Type_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    multi_purpose_flag = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multi_purpose_code = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multi_purpose_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multi_purpose_remark = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multi_purpose_delete_allow_yn = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    user_profile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_mobile = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multi_Purpose_Type_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartyCategoryMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    balance_sheet_id = table.Column<long>(type: "bigint", nullable: true),
                    balance_sheet_cate_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_id_if_sub_Selected = table.Column<long>(type: "bigint", nullable: true),
                    cate_name_if_sub_Selected = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    super_cate_id = table.Column<long>(type: "bigint", nullable: true),
                    delete_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    active = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyCategoryMaster", x => x.id);
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
                    pincode = table.Column<long>(type: "bigint", nullable: true),
                    hire_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agreement_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tax_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    percentage = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    dr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gstin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GSTIN_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pay_Term_Days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Addhar_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PAN_NO = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ac_Opening_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Op_Bal = table.Column<long>(type: "bigint", nullable: true),
                    Dr_Cr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_group_category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_commission = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_agr_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_group_category_id = table.Column<long>(type: "bigint", nullable: true),
                    agreement_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    type_of_service = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agreement_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DL_NO = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    martital_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dob = table.Column<DateTime>(type: "datetime", nullable: true),
                    anniversary = table.Column<DateTime>(type: "datetime", nullable: true),
                    loyalty = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    important = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    relation_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    swh_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    case_master_case_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    status_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PortfolioMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    portfolio_image = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    position = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReviewMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vendor_code = table.Column<long>(type: "bigint", nullable: true),
                    vendor_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rating_stars = table.Column<long>(type: "bigint", nullable: true),
                    product_review = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deleted = table.Column<long>(type: "bigint", nullable: true),
                    product_id = table.Column<long>(type: "bigint", nullable: true),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    position = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewMaster", x => x.id);
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
                    grand_total_after_discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    service_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_category_main_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Slider_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_title = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_status = table.Column<long>(type: "bigint", nullable: true),
                    deleted = table.Column<long>(type: "bigint", nullable: true),
                    img_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "State_Master",
                columns: table => new
                {
                    State_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    State_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State_Code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State_Short_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State_Master", x => x.State_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StyleMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    background_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    link_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    header_top_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    header_bottom_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    text_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    header_text_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    review_hover_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    review_content_background_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    review_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_background_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    footer_background_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_us_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    footer_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    theme_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    service_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chooseus_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StyleMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "System_Records",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    home_state_code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    default_tax_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    default_tax_per = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    default_unit = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    default_hsn_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    default_company_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address_1 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_phone = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_retrun_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    sale_return_name_default = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    sale_name_default = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    bank_name_default = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cash_name_default = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cash_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    year_from = table.Column<DateTime>(type: "datetime", nullable: true),
                    year_to = table.Column<DateTime>(type: "datetime", nullable: true),
                    display_height = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    saledatabaselock = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    database_1_path = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    database_2_path = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    auto_raw_yes_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weekly_off_day = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_format = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_state = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sender = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_receiver = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ss_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pp_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pr_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    po_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rc_bill_header_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qu_bill_header_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rounded_off = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rta_id = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_operator_id = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_register_comp_add = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_validation_check_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cart_tcs_value = table.Column<float>(type: "float", nullable: true),
                    bill_type_method = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brand = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dealer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    round_off = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transporter_cartage_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maintain_accounting_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    challan_master_method = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purchase_rate_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    profit_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_amount_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_rate_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_amount_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_profit_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_weight_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_rate_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pc_rmt_pp_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rent_rate_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    missing_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    damage_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    opening_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    irflag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    otp_req_deletion_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hsn_code_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packing_type_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    scheme_type_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remarks_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_rate_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    discount_percentage_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grand_total_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_percentage_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rate_after_gst_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_amount_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    current_stock_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    balance_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recv_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sale_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purchase_qty_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    system_invoice = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_about = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_image = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_logo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    facebook_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    twitter_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    youtube_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    linkedin_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    map_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    private_policy = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    business_card_link = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Records", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    log_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    log_user_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    log_user_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    log_user_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    log_in_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_out_time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Log_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_profile_master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_profile = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modify_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    print_only = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    report_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    view_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_profile_master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vou_list_master",
                columns: table => new
                {
                    vou_type_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    vou_type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_list_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vou_list_master", x => x.vou_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vou_master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_type_id = table.Column<long>(type: "bigint", nullable: true),
                    vou_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_fa_year = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_ref_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_date = table.Column<DateTime>(type: "date", nullable: true),
                    vou_cash_bank_id = table.Column<long>(type: "bigint", nullable: true),
                    vou_cash_bank_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_vou_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    month = table.Column<long>(type: "bigint", nullable: true),
                    year = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vou_master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WarrantyExtended",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    party_code = table.Column<long>(type: "bigint", nullable: true),
                    warranty_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    warranty_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    warranty_period = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coverage_details = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    warranty_gst_percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    warranty_gst_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    warranty_final_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    warranty_serial_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_challan_single_item_id = table.Column<long>(type: "bigint", nullable: true),
                    warranty_visit_slot = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyExtended", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    activity_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duration = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    activity_master_id = table.Column<long>(type: "bigint", nullable: true),
                    activity_default_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTranxMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_ActivityTranxMaster_ActivityMaster_activity_master_id",
                        column: x => x.activity_master_id,
                        principalTable: "ActivityMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CaseHireMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Hire_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Ph_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Company_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Off_Ph_Nos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Ph_No2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Post = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Profession = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Area = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Whatsapp_Phone = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseHireMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CaseHireMaster_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EMIDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    emi_PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    emi_Monthly_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Interest_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Monthly_Interest_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMIDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMIDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExtraDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    extra_Registration_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Hirer_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Item_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Manufacturer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Model_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Year_of_Registration = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Given = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Taken_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Chassis_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Engine_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_NOC_Made = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Taken_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Addhaar_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Pan_Card_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_DL_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Given_Date = table.Column<DateTime>(type: "date", nullable: true),
                    extra_Date = table.Column<DateTime>(type: "date", nullable: true),
                    extra_Date_Taken_By = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ExtraDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Guarantor1Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guarantor1_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Phones_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Campany_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Off_Phone_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor1Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Guarantor1Detail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Guarantor2Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guarantor2_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Phones_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Campany_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Off_Phone_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor2Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Guarantor2Detail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecieptDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    receipt_System_Bill_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Instalment_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Deposit_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Receipt_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Receipt_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Party_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Due_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_No_of_Inst_of_Int = table.Column<long>(type: "bigint", nullable: true),
                    receipt_Rec_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_By_Cash_Bank = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Cheque_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Chq_Deposit = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Bank_Chgs_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Late_Bounse = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Current_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_A_c_Close = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Close_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Case_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Pric1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Hp1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Pric2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Hp2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Chq_Bounce = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Bank_Chgs_Amt_Rec = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Late_Boun_Rec = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_RecieptDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UploadDocument",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    upload_document_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    upload_document_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadDocument", x => x.id);
                    table.ForeignKey(
                        name: "FK_UploadDocument_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DailyTaskTans",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_assigned_id = table.Column<long>(type: "bigint", nullable: true),
                    task_work_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_remarks = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    daily_task_id = table.Column<long>(type: "bigint", nullable: true),
                    task_trans_delete = table.Column<long>(type: "bigint", nullable: true),
                    task_schedule_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTaskTans", x => x.id);
                    table.ForeignKey(
                        name: "FK_DailyTaskTans_DailyTask_daily_task_id",
                        column: x => x.daily_task_id,
                        principalTable: "DailyTask",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Challan_Single_Item_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_purchase_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_rate_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_profit_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_qty = table.Column<long>(type: "bigint", nullable: true),
                    item_discount_percentage_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_discount_amount_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_discount_rate_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_gross_amount_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_gst_percenatge_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_gst_amt_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_gst_rate_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_rate_after_gst_one_pc = table.Column<float>(type: "float", nullable: true),
                    total_amount_with_gst_one_pc = table.Column<float>(type: "float", nullable: true),
                    profit_amount_one_pc = table.Column<float>(type: "float", nullable: true),
                    item_hsn_code_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_packing_type_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_remarks_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_weight_one_pc = table.Column<float>(type: "float", nullable: true),
                    issue_master_id = table.Column<long>(type: "bigint", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challan_Single_Item_Master", x => x.id);
                    table.ForeignKey(
                        name: "FK_Challan_Single_Item_Master_IssueReceiptMaster_issue_master_id",
                        column: x => x.issue_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueItemExtraDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_stock_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    item_stock_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_stock_qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_stock_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_stock_value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    challan_master_id = table.Column<long>(type: "bigint", nullable: true),
                    item_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_brand = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_agent = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_dealer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    irflag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    aggrement_id = table.Column<long>(type: "bigint", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueItemExtraDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IssueItemExtraDetail_IssueReceiptMaster_challan_master_id",
                        column: x => x.challan_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueReceiptBreakageTransDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rate = table.Column<float>(type: "float", nullable: true),
                    qty = table.Column<float>(type: "float", nullable: true),
                    amt = table.Column<float>(type: "float", nullable: true),
                    narr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    damage = table.Column<float>(type: "float", nullable: true),
                    missing = table.Column<float>(type: "float", nullable: true),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    challan_master_id = table.Column<long>(type: "bigint", nullable: true),
                    challan_trans_id = table.Column<long>(type: "bigint", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReceiptBreakageTransDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IssueReceiptBreakageTransDetail_IssueReceiptMaster_challan_m~",
                        column: x => x.challan_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueReceiptMiscTransDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bill_no_automatic = table.Column<long>(type: "bigint", nullable: true),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_code_old = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    exp_ac_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exp_amt = table.Column<long>(type: "bigint", nullable: true),
                    exp_remarks = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ir_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fo_oh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    challan_master_id = table.Column<long>(type: "bigint", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReceiptMiscTransDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IssueReceiptMiscTransDetail_IssueReceiptMaster_challan_maste~",
                        column: x => x.challan_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueReceiptTransWarrantyDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    warranty_serial_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_period = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_visit_slot = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_visit_charge = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    challan_master_id = table.Column<long>(type: "bigint", nullable: true),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    warranty_visit_date = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReceiptTransWarrantyDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IssueReceiptTransWarrantyDetail_IssueReceiptMaster_challan_m~",
                        column: x => x.challan_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IssueReceiptTransDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    challan_master_id = table.Column<long>(type: "bigint", nullable: true),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    item_short_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_group_code = table.Column<long>(type: "bigint", nullable: true),
                    item_group_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unit_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    itemtype = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    recv_qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    irflag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rent_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    rate_of_one_pcs = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weight_of_one_pcs = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    unique_number = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    opening_qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    aggrement_id = table.Column<long>(type: "bigint", nullable: true),
                    item_purchase_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_rate_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_profit_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_qty = table.Column<long>(type: "bigint", nullable: true),
                    item_discount_percentage_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_discount_amount_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_discount_rate_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_gross_amount_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_gst_percenatge_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_gst_amt_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_gst_rate_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_rate_after_gst_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_amount_with_gst_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    profit_amount_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_hsn_code_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_packing_type_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_remarks_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_weight_one_pc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_scheme_type_one_pc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    item_warranty_mode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_warranty_period = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_warranty_visit_count = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warranty_serial_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_warranty_expiry_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReceiptTransDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IssueReceiptTransDetail_IssueReceiptMaster_challan_master_id",
                        column: x => x.challan_master_id,
                        principalTable: "IssueReceiptMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_IssueReceiptTransDetail_ItemMaster_item_code",
                        column: x => x.item_code,
                        principalTable: "ItemMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemTransMixDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    item_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    item_master_id = table.Column<long>(type: "bigint", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    item_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTransMixDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItemTransMixDetail_ItemMaster_item_master_id",
                        column: x => x.item_master_id,
                        principalTable: "ItemMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemTransStockDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_stock_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    item_stock_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_stock_qty = table.Column<float>(type: "float", nullable: true),
                    item_stock_rate = table.Column<float>(type: "float", nullable: true),
                    item_stock_value = table.Column<float>(type: "float", nullable: true),
                    item_master_id = table.Column<long>(type: "bigint", nullable: true),
                    item_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_style = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_brand = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_color = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_agent = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_dealer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTransStockDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItemTransStockDetail_ItemMaster_item_master_id",
                        column: x => x.item_master_id,
                        principalTable: "ItemMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AggrementMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    pname_short_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_code_old = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_no_old = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_status_agr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    item_short_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_group_code = table.Column<long>(type: "bigint", nullable: true),
                    item_group_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mix_item_yes_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_loc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rent_rate = table.Column<float>(type: "float", nullable: true),
                    broken_chg = table.Column<float>(type: "float", nullable: true),
                    agr_qty = table.Column<float>(type: "float", nullable: true),
                    agr_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    opening_qty = table.Column<float>(type: "float", nullable: true),
                    rate_on_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    missing_rate = table.Column<float>(type: "float", nullable: true),
                    notaxrate = table.Column<float>(type: "float", nullable: true),
                    s_no = table.Column<long>(type: "bigint", nullable: true),
                    rate_of_one_pcs = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weight_of_one_pcs = table.Column<float>(type: "float", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    party_master_id = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggrementMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_AggrementMaster_ItemMaster_item_code",
                        column: x => x.item_code,
                        principalTable: "ItemMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_AggrementMaster_PartyMaster_party_master_id",
                        column: x => x.party_master_id,
                        principalTable: "PartyMaster",
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
                    service_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subservice_id = table.Column<long>(type: "bigint", nullable: true),
                    subservice_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gen_approx_amount = table.Column<long>(type: "bigint", nullable: true),
                    gen_approx_days = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_disc_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_disc_per = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_disc_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_after_disc_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_receive_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_pending_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_final_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_commission_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_commission_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_commission_percentage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_key_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_key_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receiver_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_document_img_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_payment_mode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_payment_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    party_id = table.Column<long>(type: "bigint", nullable: true),
                    general_req_transaction_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_req_transaction_image = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Partyid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequestedDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralRequestedDetail_PartyMaster_Partyid",
                        column: x => x.Partyid,
                        principalTable: "PartyMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartyAddressTransMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    party_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_pincode = table.Column<long>(type: "bigint", nullable: true),
                    party_state = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_country = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_address_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_gst_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_gst_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_gst_address_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_master_id = table.Column<long>(type: "bigint", nullable: true),
                    party_address_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_address_area_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    case_master_id = table.Column<long>(type: "bigint", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyAddressTransMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartyAddressTransMaster_CaseMaster_case_master_id",
                        column: x => x.case_master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PartyAddressTransMaster_PartyMaster_party_master_id",
                        column: x => x.party_master_id,
                        principalTable: "PartyMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartyContactTransMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    party_contact_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_whatsapp_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_landline_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_department = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_designation = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_twitter_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_fb_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_youtube_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_contact_instagram_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    party_master_id = table.Column<long>(type: "bigint", nullable: true),
                    case_master_id = table.Column<long>(type: "bigint", nullable: true),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyContactTransMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartyContactTransMaster_CaseMaster_case_master_id",
                        column: x => x.case_master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PartyContactTransMaster_PartyMaster_party_master_id",
                        column: x => x.party_master_id,
                        principalTable: "PartyMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PartyItemRateTrans",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcode = table.Column<long>(type: "bigint", nullable: true),
                    party_master_id = table.Column<long>(type: "bigint", nullable: true),
                    item_short_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agr_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    price_sell_rate = table.Column<float>(type: "float", nullable: true),
                    price_sell_discount_percentage = table.Column<float>(type: "float", nullable: true),
                    price_sell_discount_amount = table.Column<float>(type: "float", nullable: true),
                    price_sell_amount_after_discount = table.Column<float>(type: "float", nullable: true),
                    price_sell_gst_percentage = table.Column<float>(type: "float", nullable: true),
                    price_sell_gst_amount = table.Column<float>(type: "float", nullable: true),
                    price_sell_amount_with_gst = table.Column<float>(type: "float", nullable: true),
                    item_code = table.Column<long>(type: "bigint", nullable: true),
                    delete = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyItemRateTrans", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartyItemRateTrans_PartyMaster_party_master_id",
                        column: x => x.party_master_id,
                        principalTable: "PartyMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Remark_Upload_Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    upload_document_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remarks = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    attended_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_master_id = table.Column<long>(type: "bigint", nullable: true),
                    party_master_id = table.Column<long>(type: "bigint", nullable: true),
                    flag_master = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_at = table.Column<long>(type: "bigint", nullable: true),
                    created_by = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<DateTime>(type: "datetime", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remark_Upload_Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Remark_Upload_Detail_ItemMaster_item_master_id",
                        column: x => x.item_master_id,
                        principalTable: "ItemMaster",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Remark_Upload_Detail_PartyMaster_party_master_id",
                        column: x => x.party_master_id,
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
                    service_id = table.Column<long>(type: "bigint", nullable: true),
                    commission_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    commission_percentage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    commission_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cashback_amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cashback_percentage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cashback_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_category_sub_id = table.Column<long>(type: "bigint", nullable: true)
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
                name: "User_Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_code = table.Column<long>(type: "bigint(10)", nullable: false),
                    user_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_profile = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_pass = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modify_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cs_save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cs_modi_del_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    print_only = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_mobile = table.Column<long>(type: "bigint(10)", nullable: false),
                    user_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_email_pass = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    software_version = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_allotement_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    report_yes_no = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    view_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_profile_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_pancard = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Detail_user_profile_master_user_profile_id",
                        column: x => x.user_profile_id,
                        principalTable: "user_profile_master",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Registration_History",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_code = table.Column<long>(type: "bigint(10)", nullable: false),
                    user_name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_profile = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_pass = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modify_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cs_save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cs_modi_del_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    print_only = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_mobile = table.Column<long>(type: "bigint(10)", nullable: false),
                    user_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_email_pass = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    software_version = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_allotement_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    report_yes_no = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    view_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_profile_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_pancard = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Registration_History", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Registration_History_user_profile_master_user_profile_id",
                        column: x => x.user_profile_id,
                        principalTable: "user_profile_master",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vou_trn_master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unique_trn_id = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_code = table.Column<long>(type: "bigint", nullable: true),
                    client_purchaser_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    agent_code = table.Column<long>(type: "bigint", nullable: true),
                    agent_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vender_code = table.Column<long>(type: "bigint", nullable: true),
                    vender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    voucher_master_id = table.Column<long>(type: "bigint", nullable: true),
                    vou_p_id = table.Column<long>(type: "bigint", nullable: true),
                    vou_pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_chq_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_narr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vou_agst_bill = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    month = table.Column<long>(type: "bigint", nullable: true),
                    year = table.Column<long>(type: "bigint", nullable: true),
                    status = table.Column<long>(type: "bigint", nullable: true),
                    old_software_code_ya_id = table.Column<long>(type: "bigint", nullable: true),
                    vou_gst_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    vou_gst_per = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    vou_gross_amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vou_trn_master", x => x.id);
                    table.ForeignKey(
                        name: "FK_vou_trn_master_vou_master_voucher_master_id",
                        column: x => x.voucher_master_id,
                        principalTable: "vou_master",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneralRequestCheckListDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    required_info = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    required_info_data = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    required_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    required_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    general_requested_detail_id = table.Column<long>(type: "bigint", nullable: true),
                    required_col_size = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    required_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequestCheckListDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralRequestCheckListDetail_GeneralRequestedDetail_general~",
                        column: x => x.general_requested_detail_id,
                        principalTable: "GeneralRequestedDetail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneralRequestCommunicationDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    general_request_id = table.Column<long>(type: "bigint", nullable: true),
                    general_request_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequestCommunicationDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralRequestCommunicationDetail_GeneralRequestedDetail_gen~",
                        column: x => x.general_request_id,
                        principalTable: "GeneralRequestedDetail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    document_required_position = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subservice_id = table.Column<long>(type: "bigint", nullable: true),
                    service_id = table.Column<long>(type: "bigint", nullable: true),
                    helper_master_document_id = table.Column<long>(type: "bigint", nullable: true),
                    document_required_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_required_col_size = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CheckListMaster_ServiceSubCategoryMaster_subservice_id",
                        column: x => x.subservice_id,
                        principalTable: "ServiceSubCategoryMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "forms_trx_master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    form_master_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    save_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modify_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    print_only = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    report_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    view_yes_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forms_trx_master", x => x.id);
                    table.ForeignKey(
                        name: "FK_forms_trx_master_forms_master_form_master_id",
                        column: x => x.form_master_id,
                        principalTable: "forms_master",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_forms_trx_master_User_Detail_user_id",
                        column: x => x.user_id,
                        principalTable: "User_Detail",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserMultiAddDetails",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<long>(type: "bigint(10)", nullable: false),
                    m_form_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    m_address = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    m_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    m_pin_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    m_country = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    m_address_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMultiAddDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserMultiAddDetails_User_Detail_userId",
                        column: x => x.userId,
                        principalTable: "User_Detail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_otp_transaction",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    u_verification = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    u_purpose = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    u_otpno = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_register_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_status = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_otp_transaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_otp_transaction_User_Detail_user_id",
                        column: x => x.user_id,
                        principalTable: "User_Detail",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_otp_transaction_User_Registration_History_user_register~",
                        column: x => x.user_register_id,
                        principalTable: "User_Registration_History",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTranxMaster_activity_master_id",
                table: "ActivityTranxMaster",
                column: "activity_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_AggrementMaster_item_code",
                table: "AggrementMaster",
                column: "item_code");

            migrationBuilder.CreateIndex(
                name: "IX_AggrementMaster_party_master_id",
                table: "AggrementMaster",
                column: "party_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_CaseHireMaster_Case_Master_id",
                table: "CaseHireMaster",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_Single_Item_Master_issue_master_id",
                table: "Challan_Single_Item_Master",
                column: "issue_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListMaster_subservice_id",
                table: "CheckListMaster",
                column: "subservice_id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyTaskTans_daily_task_id",
                table: "DailyTaskTans",
                column: "daily_task_id");

            migrationBuilder.CreateIndex(
                name: "IX_EMIDetail_Case_Master_id",
                table: "EMIDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraDetail_Case_Master_id",
                table: "ExtraDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_forms_trx_master_form_master_id",
                table: "forms_trx_master",
                column: "form_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_forms_trx_master_user_id",
                table: "forms_trx_master",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestCheckListDetail_general_requested_detail_id",
                table: "GeneralRequestCheckListDetail",
                column: "general_requested_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestCommunicationDetail_general_request_id",
                table: "GeneralRequestCommunicationDetail",
                column: "general_request_id");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestedDetail_Partyid",
                table: "GeneralRequestedDetail",
                column: "Partyid");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequestRemark_general_request_id",
                table: "GeneralRequestRemark",
                column: "general_request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor1Detail_Case_Master_id",
                table: "Guarantor1Detail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor2Detail_Case_Master_id",
                table: "Guarantor2Detail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueItemExtraDetail_challan_master_id",
                table: "IssueItemExtraDetail",
                column: "challan_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptBreakageTransDetail_challan_master_id",
                table: "IssueReceiptBreakageTransDetail",
                column: "challan_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptMiscTransDetail_challan_master_id",
                table: "IssueReceiptMiscTransDetail",
                column: "challan_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptTransDetail_challan_master_id",
                table: "IssueReceiptTransDetail",
                column: "challan_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptTransDetail_item_code",
                table: "IssueReceiptTransDetail",
                column: "item_code");

            migrationBuilder.CreateIndex(
                name: "IX_IssueReceiptTransWarrantyDetail_challan_master_id",
                table: "IssueReceiptTransWarrantyDetail",
                column: "challan_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransMixDetail_item_master_id",
                table: "ItemTransMixDetail",
                column: "item_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransStockDetail_item_master_id",
                table: "ItemTransStockDetail",
                column: "item_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyAddressTransMaster_case_master_id",
                table: "PartyAddressTransMaster",
                column: "case_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyAddressTransMaster_party_master_id",
                table: "PartyAddressTransMaster",
                column: "party_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyContactTransMaster_case_master_id",
                table: "PartyContactTransMaster",
                column: "case_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyContactTransMaster_party_master_id",
                table: "PartyContactTransMaster",
                column: "party_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_PartyItemRateTrans_party_master_id",
                table: "PartyItemRateTrans",
                column: "party_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptDetail_Case_Master_id",
                table: "RecieptDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_Upload_Detail_item_master_id",
                table: "Remark_Upload_Detail",
                column: "item_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_Upload_Detail_party_master_id",
                table: "Remark_Upload_Detail",
                column: "party_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTrxMaster_sales_master_id",
                table: "SalesTrxMaster",
                column: "sales_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSubCategoryMaster_service_id",
                table: "ServiceSubCategoryMaster",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_UploadDocument_Case_Master_id",
                table: "UploadDocument",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Detail_user_code",
                table: "User_Detail",
                column: "user_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Detail_user_profile_id",
                table: "User_Detail",
                column: "user_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_otp_transaction_user_id",
                table: "user_otp_transaction",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_otp_transaction_user_register_id",
                table: "user_otp_transaction",
                column: "user_register_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Registration_History_user_code",
                table: "User_Registration_History",
                column: "user_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Registration_History_user_profile_id",
                table: "User_Registration_History",
                column: "user_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserMultiAddDetails_userId",
                table: "UserMultiAddDetails",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_vou_trn_master_voucher_master_id",
                table: "vou_trn_master",
                column: "voucher_master_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityNameMaster");

            migrationBuilder.DropTable(
                name: "ActivityTranxMaster");

            migrationBuilder.DropTable(
                name: "AggrementMaster");

            migrationBuilder.DropTable(
                name: "Auth_Token");

            migrationBuilder.DropTable(
                name: "balance_sheet_master");

            migrationBuilder.DropTable(
                name: "Bill_Rent_Master");

            migrationBuilder.DropTable(
                name: "BlogMaster");

            migrationBuilder.DropTable(
                name: "BusinessContent");

            migrationBuilder.DropTable(
                name: "BusinessSection");

            migrationBuilder.DropTable(
                name: "BusinessUserDetail");

            migrationBuilder.DropTable(
                name: "BussinessUserContentDetail");

            migrationBuilder.DropTable(
                name: "BussinessUserSectionDetail");

            migrationBuilder.DropTable(
                name: "CaseHireMaster");

            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "Challan_Single_Item_Master");

            migrationBuilder.DropTable(
                name: "CheckListMaster");

            migrationBuilder.DropTable(
                name: "ClientMaster");

            migrationBuilder.DropTable(
                name: "ContactMaster");

            migrationBuilder.DropTable(
                name: "DailyTaskTans");

            migrationBuilder.DropTable(
                name: "EMIDetail");

            migrationBuilder.DropTable(
                name: "ExtraDetail");

            migrationBuilder.DropTable(
                name: "Form_Master");

            migrationBuilder.DropTable(
                name: "forms_trx_master");

            migrationBuilder.DropTable(
                name: "GeneralRequestCheckListDetail");

            migrationBuilder.DropTable(
                name: "GeneralRequestCommunicationDetail");

            migrationBuilder.DropTable(
                name: "GeneralRequestRemark");

            migrationBuilder.DropTable(
                name: "Guarantor1Detail");

            migrationBuilder.DropTable(
                name: "Guarantor2Detail");

            migrationBuilder.DropTable(
                name: "HelperFlagMaster");

            migrationBuilder.DropTable(
                name: "HelperMaster");

            migrationBuilder.DropTable(
                name: "IssueItemExtraDetail");

            migrationBuilder.DropTable(
                name: "IssueReceiptBreakageTransDetail");

            migrationBuilder.DropTable(
                name: "IssueReceiptMiscTransDetail");

            migrationBuilder.DropTable(
                name: "IssueReceiptTransDetail");

            migrationBuilder.DropTable(
                name: "IssueReceiptTransWarrantyDetail");

            migrationBuilder.DropTable(
                name: "ItemTransMixDetail");

            migrationBuilder.DropTable(
                name: "ItemTransStockDetail");

            migrationBuilder.DropTable(
                name: "Location_Master");

            migrationBuilder.DropTable(
                name: "Multi_Purpose_Type_Master");

            migrationBuilder.DropTable(
                name: "PartyAddressTransMaster");

            migrationBuilder.DropTable(
                name: "PartyCategoryMaster");

            migrationBuilder.DropTable(
                name: "PartyContactTransMaster");

            migrationBuilder.DropTable(
                name: "PartyItemRateTrans");

            migrationBuilder.DropTable(
                name: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "RecieptDetail");

            migrationBuilder.DropTable(
                name: "Remark_Upload_Detail");

            migrationBuilder.DropTable(
                name: "ReviewMaster");

            migrationBuilder.DropTable(
                name: "SalesTrxMaster");

            migrationBuilder.DropTable(
                name: "Slider_Master");

            migrationBuilder.DropTable(
                name: "State_Master");

            migrationBuilder.DropTable(
                name: "StyleMaster");

            migrationBuilder.DropTable(
                name: "System_Records");

            migrationBuilder.DropTable(
                name: "UploadDocument");

            migrationBuilder.DropTable(
                name: "User_Log_Master");

            migrationBuilder.DropTable(
                name: "user_otp_transaction");

            migrationBuilder.DropTable(
                name: "UserMultiAddDetails");

            migrationBuilder.DropTable(
                name: "vou_list_master");

            migrationBuilder.DropTable(
                name: "vou_trn_master");

            migrationBuilder.DropTable(
                name: "WarrantyExtended");

            migrationBuilder.DropTable(
                name: "ActivityMaster");

            migrationBuilder.DropTable(
                name: "ServiceSubCategoryMaster");

            migrationBuilder.DropTable(
                name: "DailyTask");

            migrationBuilder.DropTable(
                name: "forms_master");

            migrationBuilder.DropTable(
                name: "GeneralRequestedDetail");

            migrationBuilder.DropTable(
                name: "IssueReceiptMaster");

            migrationBuilder.DropTable(
                name: "ItemMaster");

            migrationBuilder.DropTable(
                name: "SalesMaster");

            migrationBuilder.DropTable(
                name: "CaseMaster");

            migrationBuilder.DropTable(
                name: "User_Registration_History");

            migrationBuilder.DropTable(
                name: "User_Detail");

            migrationBuilder.DropTable(
                name: "vou_master");

            migrationBuilder.DropTable(
                name: "ServiceMaster");

            migrationBuilder.DropTable(
                name: "PartyMaster");

            migrationBuilder.DropTable(
                name: "user_profile_master");
        }
    }
}
