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
                name: "A_Pas_6_Master_Tmp",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    isin_no_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_company_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_qty = table.Column<float>(type: "float", nullable: true),
                    deposi_nsdl_qty = table.Column<float>(type: "float", nullable: true),
                    deposi_cdsl_qty = table.Column<float>(type: "float", nullable: true),
                    deposi_phy_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_cdsl_total = table.Column<float>(type: "float", nullable: true),
                    mismatch_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    from_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    upto_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pas_6_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pas_6_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_address_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website_address_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    compliance_officer_current = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_make_current = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_name_current = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    registered_office_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    corporate_office_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cin_no_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan_no_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ph_nos_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    member_in_exchange_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    depository_participant_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_detail_rta = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    printed_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Pas_6_Master_Tmp", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "A_Pas_6_Qty_Master_Tmp",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_company_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sno = table.Column<float>(type: "float", nullable: true),
                    particular_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    within_21_days_qty_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beyound_21_days_qty_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    within_21_days_qty_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beyound_21_days_qty_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    registered_office = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    corporate_office = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ph_nos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Pas_6_Qty_Master_Tmp", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "A1_Dn_Test",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    old_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    dn_from = table.Column<float>(type: "float", nullable: true),
                    dn_upto = table.Column<float>(type: "float", nullable: true),
                    share_qty = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A1_Dn_Test", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ac_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cat_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_main_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_main = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supermain_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    undercode = table.Column<long>(type: "bigint(10)", nullable: true),
                    undername = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ac_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "All_Comp_Holding_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    file_exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_no_dt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holding_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_noshares_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_shlock_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_plbal_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_benlock = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benblk = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benplg = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benplglk = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benplgun = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benplgcloc = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benrem = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_benremloc = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_bencmidpos = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_cmpool = table.Column<float>(type: "float", nullable: true),
                    nsdl_nsdl_ccsett = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_All_Comp_Holding_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointment_Master_2022",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    app_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    app_date_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    close_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    close_date_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    office_date_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_category_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_priority_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_mobile = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_comment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holiday_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment_Master_2022", x => x.id);
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
                name: "Balance_Sheet",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cat_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_main = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supermain = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drcr = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    todo = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    window = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mindex = table.Column<long>(type: "bigint(10)", nullable: true),
                    del_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance_Sheet", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Benpos_Path_Master_1718",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    path_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    path_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benpos_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benpos_flag = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benpos_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benpos_Path_Master_1718", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Benpos_Process_Control_Mst_1718",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    process_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    process_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    process_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_isin = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benpos_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    nsdl_done_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_holding = table.Column<float>(type: "float", nullable: true),
                    error_in_nsdl_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_detail_nsdl = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_done_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_holding = table.Column<float>(type: "float", nullable: true),
                    error_in_cdsl_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_detail_cdsl = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_done_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_holding = table.Column<float>(type: "float", nullable: true),
                    error_in_phy_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_detail_phy = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benpos_Process_Control_Mst_1718", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Benpos_Process_Master_1718",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ben_pro_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    bene_pro_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    database_name_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    database_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_isin_found_yn_in_db = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bespos_exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bespos_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benpos_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    benpos_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pro_nsdl_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_01_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_02_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_03_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_has_error_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_error_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_position = table.Column<float>(type: "float", nullable: true),
                    nsdl_total_no_records = table.Column<float>(type: "float", nullable: true),
                    nsdl_holding_master_update_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pro_cdsl_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_01_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_02_found_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_has_error_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_error_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_position = table.Column<float>(type: "float", nullable: true),
                    cdsl_total_no_records = table.Column<float>(type: "float", nullable: true),
                    cdsl_holding_master_update_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pro_phy_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_has_error_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_error_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_position = table.Column<float>(type: "float", nullable: true),
                    phy_total_no_records = table.Column<float>(type: "float", nullable: true),
                    phy_holding_master_update_yn = table.Column<float>(type: "float", nullable: true),
                    over_all_error_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    over_all_error_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bespos_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benpos_Process_Master_1718", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ca_Codes_Type_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    s_no = table.Column<float>(type: "float", nullable: true),
                    ca_desc_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ca_main_discription = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ca_value = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ca_under_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ca_type_main_sub = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_status = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca_Codes_Type_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ca_Upload_Cdsl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trfno = table.Column<float>(type: "float", nullable: true),
                    total_number_of_records = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_current_quantity = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_freeze_quantity = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_lock_in_quantity = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_number_of_records_in_02 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_number_of_records_in_03 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca_Upload_Cdsl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ca_Upload_Cdsl_03",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id_03 = table.Column<long>(type: "bigint(10)", nullable: true),
                    trfno = table.Column<float>(type: "float", nullable: true),
                    sno_num = table.Column<float>(type: "float", nullable: true),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ca_isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dn_from = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dn_to = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dn_quantity = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    debit_credit_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca_Upload_Cdsl_03", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cat_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_main_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_main = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supermain_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    undercode = table.Column<long>(type: "bigint(10)", nullable: true),
                    undername = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category_Master_4_All_Exchange",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cate_id = table.Column<float>(type: "float", nullable: true),
                    cate_id_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unique_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_code_1 = table.Column<float>(type: "float", nullable: true),
                    cate_code_2 = table.Column<float>(type: "float", nullable: true),
                    cate_code_3 = table.Column<float>(type: "float", nullable: true),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_discreption = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    page_name_group = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    main_category_header_index_no = table.Column<float>(type: "float", nullable: true),
                    main_category_header_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_index_no = table.Column<float>(type: "float", nullable: true),
                    sub_categroy_index_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_index_no_2 = table.Column<float>(type: "float", nullable: true),
                    sub_categroy_name_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    clinet_details_under_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_details = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    page_name_group_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    main_category_header_index_no_modify = table.Column<float>(type: "float", nullable: true),
                    main_category_header_name_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_index_no_modify = table.Column<float>(type: "float", nullable: true),
                    sub_categroy_index_code_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_name_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_categroy_index_no_2_modify = table.Column<float>(type: "float", nullable: true),
                    sub_categroy_name_2_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    clinet_details_under_category_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_details_modify = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Master_4_All_Exchange", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categroy_Master_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cate_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    cate_id_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unique_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_code_1 = table.Column<float>(type: "float", nullable: true),
                    cate_code_2 = table.Column<float>(type: "float", nullable: true),
                    cate_code_3 = table.Column<float>(type: "float", nullable: true),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_discreption = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categroy_Master_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categroy_Master_Phy",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cate_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    cate_id_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unique_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdsl_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_unique_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cate_code_1 = table.Column<float>(type: "float", nullable: true),
                    cate_code_2 = table.Column<float>(type: "float", nullable: true),
                    cate_code_3 = table.Column<float>(type: "float", nullable: true),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_discreption = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categroy_Master_Phy", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cdsl_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cdsl_create_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    bosubtype = table.Column<float>(type: "float", nullable: true),
                    bosubtype_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    custtype = table.Column<float>(type: "float", nullable: true),
                    custtype_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bopr = table.Column<float>(type: "float", nullable: true),
                    bopr_nmae = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soft_uniq_code = table.Column<float>(type: "float", nullable: true),
                    soft_uniq_types = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_ph = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdsl_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cdsl_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_details = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holder_share_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_lock_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_plg_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    non_promoter = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other_number1_sno = table.Column<float>(type: "float", nullable: true),
                    other_number2_sno = table.Column<float>(type: "float", nullable: true),
                    other_number3_sno = table.Column<float>(type: "float", nullable: true),
                    other_number4_sno = table.Column<float>(type: "float", nullable: true),
                    other_number5_sno = table.Column<float>(type: "float", nullable: true),
                    isincd = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dpid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    names = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jt1 = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jt2 = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gname = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnname = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fname = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mf = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bdt = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    acstat = table.Column<float>(type: "float", nullable: true),
                    bocat = table.Column<float>(type: "float", nullable: true),
                    bopr = table.Column<float>(type: "float", nullable: true),
                    custtype = table.Column<float>(type: "float", nullable: true),
                    bosubtype = table.Column<float>(type: "float", nullable: true),
                    occupation = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan1 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan2 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan3 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bofrflag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    frrscode = table.Column<float>(type: "float", nullable: true),
                    isinst = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    opdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    sebirno = table.Column<string>(type: "varchar(24)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seid = table.Column<float>(type: "float", nullable: true),
                    chcid = table.Column<float>(type: "float", nullable: true),
                    cmid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbino = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiapdt = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tds = table.Column<float>(type: "float", nullable: true),
                    nation = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pincode = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcity = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pstate = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcont = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ppin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telno1 = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telno2 = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bofax = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    boemail = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ecsmandate = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divmicrno = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divbkbr = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bknm = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad1 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad2 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad3 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkcity = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkst = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkcont = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divcr = table.Column<float>(type: "float", nullable: true),
                    divbkty = table.Column<float>(type: "float", nullable: true),
                    divbknm = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    noshares = table.Column<float>(type: "float", nullable: true),
                    shlock = table.Column<float>(type: "float", nullable: true),
                    plbal = table.Column<float>(type: "float", nullable: true),
                    sfkpbal = table.Column<float>(type: "float", nullable: true),
                    earmarkbal = table.Column<float>(type: "float", nullable: true),
                    pnremat = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    freebal = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pndmver = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pndmconf = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateofben = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bdt1 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdsl_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cdsl_Master_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_by_username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailed_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailed_sent_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    tot_qty = table.Column<float>(type: "float", nullable: true),
                    tot_transit_qtu = table.Column<float>(type: "float", nullable: true),
                    tot_free_qty = table.Column<float>(type: "float", nullable: true),
                    tot_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_block_qty = table.Column<float>(type: "float", nullable: true),
                    tot_pledged_qty = table.Column<float>(type: "float", nullable: true),
                    tot_pledged_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_unconfirmed_pldg_qty = table.Column<float>(type: "float", nullable: true),
                    tot_uncon_pldg_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_olidt_qty = table.Column<float>(type: "float", nullable: true),
                    tot_remat_qty = table.Column<float>(type: "float", nullable: true),
                    tot_remat_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine1_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine2_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine3_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine4_qty = table.Column<float>(type: "float", nullable: true),
                    filler_1 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_2 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_records = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdsl_Master_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cdsl_Master_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isincd = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dpid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    names = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jt1 = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jt2 = table.Column<string>(type: "varchar(164)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gname = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnname = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fname = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mf = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bdt = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    acstat = table.Column<float>(type: "float", nullable: true),
                    bocat = table.Column<float>(type: "float", nullable: true),
                    bopr = table.Column<float>(type: "float", nullable: true),
                    custtype = table.Column<float>(type: "float", nullable: true),
                    bosubtype = table.Column<float>(type: "float", nullable: true),
                    occupation = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan1 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan2 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan3 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bofrflag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    frrscode = table.Column<float>(type: "float", nullable: true),
                    isinst = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    opdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    sebirno = table.Column<string>(type: "varchar(24)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seid = table.Column<float>(type: "float", nullable: true),
                    chcid = table.Column<float>(type: "float", nullable: true),
                    cmid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trid = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbino = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiapdt = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tds = table.Column<float>(type: "float", nullable: true),
                    nation = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pincode = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcity = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pstate = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcont = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ppin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telno1 = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telno2 = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bofax = table.Column<string>(type: "varchar(17)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    boemail = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ecsmandate = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divmicrno = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divbkbr = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bknm = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad1 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad2 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkad3 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkcity = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkst = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkcont = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bkpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    divcr = table.Column<float>(type: "float", nullable: true),
                    divbkty = table.Column<float>(type: "float", nullable: true),
                    divbknm = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    noshares = table.Column<float>(type: "float", nullable: true),
                    shlock = table.Column<float>(type: "float", nullable: true),
                    plbal = table.Column<float>(type: "float", nullable: true),
                    sfkpbal = table.Column<float>(type: "float", nullable: true),
                    earmarkbal = table.Column<float>(type: "float", nullable: true),
                    pnremat = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    freebal = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pndmver = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pndmconf = table.Column<string>(type: "varchar(22)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateofben = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bdt1 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdsl_Master_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Check_List_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    check_list_master_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_flag_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checking_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_vou_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    check_list_detail_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    check_list_for = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    check_list_type_mo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_by_username = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_status_msg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    maker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    checker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    current_status_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    current_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check_List_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comp_Name",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    compno = table.Column<float>(type: "float", nullable: true),
                    compaddress = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    compname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phones = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_owner_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gstin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_ac_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_ifsc = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_address_2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_address_3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_address_4 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_state_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_state_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_company_pcode = table.Column<float>(type: "float", nullable: true),
                    rta_company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_company_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_upload_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_operator_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_type_of_security = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_amt_per_share = table.Column<float>(type: "float", nullable: true),
                    p_register_comp_add = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Name", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comp_Per_Day_Holding_Det",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trx_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<float>(type: "float", nullable: true),
                    lock_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mix_match_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    import_day_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_op = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    cdsl_in_nsdl_out_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_in_cdsl_out_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_closing_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exch_closing_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_cls = table.Column<float>(type: "float", nullable: true),
                    paid_up_capital_qty_cls_reco_nsdl = table.Column<float>(type: "float", nullable: true),
                    paid_up_capital_qty_cls_reco_cdsl = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Per_Day_Holding_Det", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comp_Per_Day_Holding_Det_All_Comp",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trx_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<float>(type: "float", nullable: true),
                    lock_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mix_match_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    import_day_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_op = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    cdsl_in_nsdl_out_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_in_cdsl_out_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_closing_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exch_closing_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_cls = table.Column<float>(type: "float", nullable: true),
                    paid_up_capital_qty_cls_reco_nsdl = table.Column<float>(type: "float", nullable: true),
                    paid_up_capital_qty_cls_reco_cdsl = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Per_Day_Holding_Det_All_Comp", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comp_Selection_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    c_comp_sno = table.Column<float>(type: "float", nullable: true),
                    c_comp_isin = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_short_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_paid_up_capital = table.Column<float>(type: "float", nullable: true),
                    c_add1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add4 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phones = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gstin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gst_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pan = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ac_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bcity = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ifsc = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_micr = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_create_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_share_face_value = table.Column<float>(type: "float", nullable: true),
                    c_folio_no_auto_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_sub_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_more_isin_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_master_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_shares_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tan = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pay_term_days = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_pay_term_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_activate = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_apply = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_creation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_created_by = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_updation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_updated_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph = table.Column<long>(type: "bigint(10)", nullable: true),
                    c_contact_ph2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode_2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_list_to_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_top10_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_rpt_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_source_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    c_maintain_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_data_tyep_description = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_demat_both = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_group_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_issuer_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_weekly_email_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_old_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tot_equity = table.Column<double>(type: "double(18,3)", nullable: true),
                    cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no_auto_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tot_equity_fully = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_tot_equity_partly = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_share_face_value_partly = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_sign_image_path_auto_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_scrip_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_name_of_scrip = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_class_of_security = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_convert_to_numrice_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cert_convert_to_numrice_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    test_coloum = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    listing_on_bse_nse = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_agreement_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_date_agree = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_date_agree = table.Column<DateTime>(type: "datetime", nullable: true),
                    company_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_lenght = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    listing_on_bse_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    listing_on_nse_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    listing_on_mse_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Selection_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comp_Selection_Master_Recently",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    c_comp_sno = table.Column<float>(type: "float", nullable: true),
                    c_comp_isin = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_short_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_paid_up_capital = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add4 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phones = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gstin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gst_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pan = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ac_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bcity = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ifsc = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_micr = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_create_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_share_face_value = table.Column<float>(type: "float", nullable: true),
                    c_folio_no_auto_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_sub_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_more_isin_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_master_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_shares_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tan = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pay_term_days = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_pay_term_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_activate = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_apply = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_creation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_updation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_updated_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode_2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_list_to_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_top10_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_rpt_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_source_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_maintain_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_data_tyep_description = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_demat_both = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_group_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_issuer_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_weekly_email_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_old_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tot_equity = table.Column<double>(type: "double(18,3)", nullable: true),
                    cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no_auto_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    used_on_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_comp_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_tot_equity_fully = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_tot_equity_partly = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_share_face_value_partly = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_sign_image_path_auto_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cert_convert_to_numrice_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_convert_to_numrice_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    listing_on_bse_nse = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_agreement_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_date_agree = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_date_agree = table.Column<DateTime>(type: "datetime", nullable: true),
                    company_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_class_of_security = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_name_of_scrip = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_scrip_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_lenght = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp_Selection_Master_Recently", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Complaint_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: " bigint(10)", nullable: true),
                    user_code = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    phone = table.Column<long>(type: "bigint", nullable: true),
                    subject = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complaint_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Complaint_Rec_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cplt_rec_id_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    cplt_rec_entry_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_checker_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_rec_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_in_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_inward_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_sender_contact = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_cl_id_folio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_drn_rr_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_in_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_finish_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_finish_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_finish_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_req_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_req_comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_req_comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_req_comp_sno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_id = table.Column<float>(type: "float", nullable: true),
                    req_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_reject_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imported_iw_in_atuo_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    imported_iw_out_atuo_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    folio_no = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    cplt_rec_naturn_of_complaint = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_nature_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint_Rec_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Complaint_Rec_Trn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cplt_rec_trn_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    cplt_rec_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    cplt_rec_maker_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_maker_entry_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_checker_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_checker_entry_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_naturn_of_complaint = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_nature_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_reject_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reply_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_action_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_action_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint_Rec_Trn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Complaint_Reply_Trn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cplt_rec_trn_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    cplt_rec_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    cplt_rec_maker_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_maker_entry_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_checker_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_checker_entry_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_reply_to = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_naturn_of_complaint = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_nature_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_verify_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_reject_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_reply_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    cplt_rec_action_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_action_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint_Reply_Trn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Correspondence_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    trx_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    work_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_contact_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pod_trx_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    work_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_req_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_req_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id = table.Column<float>(type: "float", nullable: true),
                    req_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_form_master = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    in_ward_id = table.Column<float>(type: "float", nullable: true),
                    in_ward_id_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    work_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chargable_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chargable_unit = table.Column<double>(type: "double(18,3)", nullable: true),
                    chargable_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    chargable_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondence_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Delete_And_Create_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    del_create_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    del_create_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    auto_create_table_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delete_And_Create_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demat_Batch_Id_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_upload_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    trx_business_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    batch_no = table.Column<float>(type: "float", nullable: true),
                    batch_no_text = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_code = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_id_sr_bp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operator_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_no_of_records = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_flag = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_extension_text = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_extension_no = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demat_Batch_Id_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demat_Out_Cdsl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    business_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_number_of_records = table.Column<float>(type: "float", nullable: true),
                    total_number_of_successful_records = table.Column<float>(type: "float", nullable: true),
                    total_number_of_failed_records = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demat_Out_Cdsl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demat_Out_Cdsl_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_number_in_the_file = table.Column<float>(type: "float", nullable: true),
                    upload_type = table.Column<float>(type: "float", nullable: true),
                    field_1 = table.Column<string>(type: "varchar(13)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_2 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity = table.Column<float>(type: "float", nullable: true),
                    internal_reference_number = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    business_date = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn = table.Column<float>(type: "float", nullable: true),
                    destat_type_restat_type = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_3 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_4 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_sequence_number = table.Column<float>(type: "float", nullable: true),
                    field_5 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reason_code = table.Column<float>(type: "float", nullable: true),
                    number_of_dn_ranges = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_7 = table.Column<string>(type: "varchar(13)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_request_form_number_drf = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verified_accepted_quantity_mutual_fund_amount = table.Column<float>(type: "float", nullable: true),
                    verified_rejected_quantity = table.Column<float>(type: "float", nullable: true),
                    confirmed_accepted_quantity = table.Column<float>(type: "float", nullable: true),
                    confirmed_rejected_quantity = table.Column<float>(type: "float", nullable: true),
                    confirmation_rejected_part_quantity = table.Column<float>(type: "float", nullable: true),
                    all_quantity_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lock_in_status = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_8 = table.Column<float>(type: "float", nullable: true),
                    field_9 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_number = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_10 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_11 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_description = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_12 = table.Column<float>(type: "float", nullable: true),
                    field_13 = table.Column<float>(type: "float", nullable: true),
                    verification_confirmation_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_14 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_15 = table.Column<float>(type: "float", nullable: true),
                    field_16 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_17 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_18 = table.Column<float>(type: "float", nullable: true),
                    request_receive_date = table.Column<string>(type: "varchar(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_1_document_type = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_2 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_3 = table.Column<float>(type: "float", nullable: true),
                    error_code = table.Column<string>(type: "varchar(9)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demat_Out_Cdsl_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demat_Out_Nsdl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_number = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_code = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_bp_id = table.Column<string>(type: "varchar(80)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bp_role = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_acceptance_status = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_demat_accepted_position = table.Column<float>(type: "float", nullable: true),
                    total_demat_rejected_position = table.Column<float>(type: "float", nullable: true),
                    total_remat_accepted_position = table.Column<float>(type: "float", nullable: true),
                    total_remat_rejected_position = table.Column<float>(type: "float", nullable: true),
                    total_repurchase_accepted_position = table.Column<float>(type: "float", nullable: true),
                    total_repurchase_rejected_position = table.Column<float>(type: "float", nullable: true),
                    total_number_of_detail_records_7 = table.Column<float>(type: "float", nullable: true),
                    current_business_date = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id_upload = table.Column<string>(type: "varchar(36)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_01 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demat_Out_Nsdl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Demat_Out_Nsdl_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_number = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_number = table.Column<float>(type: "float", nullable: true),
                    transaction_type = table.Column<float>(type: "float", nullable: true),
                    transaction_flag = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    instruction_id = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    internal_reference_number = table.Column<string>(type: "varchar(235)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_reference_number_1 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_reference_number_2 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_02 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demat_Out_Nsdl_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Despatch_By_Mst",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    despatch_by_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    despatch_by_id = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despatch_By_Mst", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destination_Mst",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desti_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    desti_id = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination_Mst", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Distribution_Slab_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    disti_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    start_qty = table.Column<float>(type: "float", nullable: true),
                    end_qty = table.Column<float>(type: "float", nullable: true),
                    remark_note = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_Slab_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Docs_Multi_Save_Trx_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_type_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    inward_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs_Multi_Save_Trx_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Docu_Type_Mst",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    docu_type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_type_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    docu_flag = table.Column<string>(type: "varchar(150)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docu_Type_Mst", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dp_Cl_Id_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_nm = table.Column<string>(type: "varchar(2255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_pan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_pan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_pan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benphn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benfax = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomgur = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benbank = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bannmbr = table.Column<string>(type: "varchar(135)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    micrno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ifsc = table.Column<string>(type: "varchar(111)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnktype = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dp_Cl_Id_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dp_Import_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date_text = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dp_Import_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dp_Master_Nsdl_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_first_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_date_from = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_date_to = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_type_role = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_type_description = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_address_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_address_4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_country = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_zip = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_phone_1 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_phone_2 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_fax = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    associated_cc_id_nsdl = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    associated_dp_id_nsdl = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    associated_cc_cm_id_nsdl = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bp_category_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bp_name_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bp_stat_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_status = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_status_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_number = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parent_dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parent_dp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_id = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_id = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_account = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_account_currency = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_account_currency_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_accounting_indicator = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_id = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_guarantee_level = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_billing_cycle = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_frequency = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billing_frequency_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_first_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_middle_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_last_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_address_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_country = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_zip = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_phone_1 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_phone_2 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_fax = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    poa_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title_cdsl = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    registered_contact_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    suffix_cdsl = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_address_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_country = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_zip = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_phone_1 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_phone_2 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_fax = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operational_contact_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_accounting_type = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_accounting_type_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maximum_users = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cds_no_of_shares = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    electronic_confirmation = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_net_worth = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_net_worth_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    suspended_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_number_count = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_number_2 = table.Column<string>(type: "varchar(32)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_status = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dp_Master_Nsdl_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dp_Master_Nsdl_Cdsl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_record_date_text = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    full_incremental_flag = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    incremental_reference_datetime = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_number_of_detail_records = table.Column<float>(type: "float", nullable: true),
                    filler = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dp_Master_Nsdl_Cdsl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email_log_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    email_sent_on_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    email_sent_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sent_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sent_bb_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sent_cc_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sender_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_subject = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_body_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_attach_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_attach_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_attach_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_sent_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_log_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_log_created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email_Log_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email_Sender_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sender_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    sender_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_password = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email_Sender_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email_Sent_To_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sent_to_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    sent_to_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sent__to_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sent_to_created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email_Sent_To_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email_Smtserver_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    smtserver_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    smtserver_set_default_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtserver_port = table.Column<string>(type: "varchar(55)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtserver_host = table.Column<string>(type: "varchar(55)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtserver_enable_ssl_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smt_server_flag = table.Column<string>(type: "varchar(55)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email_Smtserver_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Email_Users_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email_user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    email_user_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_created_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email_Users_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Error_Code_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_code_description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_status = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Error_Code_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Event_Multi_Save_Trx_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    inward_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    event_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    event_sno = table.Column<double>(type: "double(18,3)", nullable: true),
                    event_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Multi_Save_Trx_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exch_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    p_pi_pn = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exch_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exch_Category_Master_Software",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    software_categroy_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    software_category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    software_qtr_categroy_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exch_Category_Master_Software", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exch_Sub_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    category_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    main_cate_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    main_cate_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exch_Sub_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Field_Master_4_Error",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    error_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    error_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    error_table_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reason_or_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    database_used = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    update_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on_datetime = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field_Master_4_Error", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Field_Master_4_Update",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    field_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    field_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    field_lenght = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_name_4_update = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reason_or_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    database_used = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    update_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on_datetime = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field_Master_4_Update", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filling_Doc_Maintain_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    filling_master_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    filling_sno = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filling_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    file_status_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transfer_no = table.Column<float>(type: "float", nullable: true),
                    transfer_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inword_no = table.Column<float>(type: "float", nullable: true),
                    inword_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_no = table.Column<float>(type: "float", nullable: true),
                    req_rec_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tran_no_from_to_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tran_no_from = table.Column<float>(type: "float", nullable: true),
                    tran_no_upto = table.Column<float>(type: "float", nullable: true),
                    transaction_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filling_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filling_comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filling_comp_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filebox_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    colour_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    location_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rack_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cell_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_through = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_file_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_by_username = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_status_msg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    maker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    checker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    current_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filling_Doc_Maintain_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filling_Doc_Trx_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    filling_trx_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    filling_master_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    filling_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    transfer_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transfer_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_form_master = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inword_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inword_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inward_rec_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    scan_path_by_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filling_Doc_Trx_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fin_Year_Selection_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fa_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    fa_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    fa_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    fa_financial_year = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fa_financial_year_short = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fa_financial_year_selected = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    working_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    working_end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    working_financial_year = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    working_financial_year_short = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    working_financial_year_selected = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fin_Year_Selection_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Folio_Multi_Dist_Save_Trx_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    inward_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_sno = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_folio_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_share_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_certi_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_dist_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_dist_upto = table.Column<double>(type: "double(18,3)", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folio_Multi_Dist_Save_Trx_Master", x => x.id);
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
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forms_master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Holiday_Master_2022",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    holiday_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    holiday_date_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    office_date_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holiday_category_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holiday_comment = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday_Master_2022", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Iepf_Detail_Ndsl_Ndsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sno_num = table.Column<float>(type: "float", nullable: true),
                    c2_m_r_i = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c3_m_rec_l_no = table.Column<string>(type: "varchar(5)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c4_m_cr_dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c5_m_cr_ci_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c6_m_cr_ci_ac_cate = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c7_m_dr_dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c8_m_dr_cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c9_m_dr_ci_ac_cate = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c10_m_cr_qty = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c11_m_dr_qty = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c13_o_cr_l_in_qty_code = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c14_o_cr_l_in_release_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c15_o_dr_l_in_qty_code = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c16_o_dr_l_in_release_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iepf_Detail_Ndsl_Ndsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Ac_Purc",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    image_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_purc_bill_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    image_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Ac_Purc", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Ac_Req_Iss",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    image_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_req_iss_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    image_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Ac_Req_Iss", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Ac_Req_Rec",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    image_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_req_rec_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    image_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Ac_Req_Rec", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Ac_Sale",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    image_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_sale_bill_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    image_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Ac_Sale", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Companies",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Companies", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_In_Ward",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_In_Ward", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Out_Ward",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Out_Ward", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Images_Store_Master_Req_Rec",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_Store_Master_Req_Rec", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "In_Out_Ward_Cate_Mst",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    in_out_ward_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    ward_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ward_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ward_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_In_Out_Ward_Cate_Mst", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inter_Depository_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    int_dep_01_ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    int_dep_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deli_dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reci_dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_trans_qty = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_pre_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_pre_time = table.Column<string>(type: "varchar(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_det_rec = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(9)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inter_Depository_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inter_Depository_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    int_dep_02_ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    int_dep_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_no = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transfer_qty = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inst_rece_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inst_acpt_rejt_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inst_conf_rele_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conf_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_code1 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_code2 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_code3 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_code4 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inter_Depository_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inter_Depository_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    idt_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inter_Depository_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isin_Status_Import_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date_text = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isin_Status_Import_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isin_Status_Master_Nsdl_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_status_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    national_security_code_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    booking_basis_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_code_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    found_on_company_master_nsdl = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    found_on_company_master_cdsl = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_numeric_code_1 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_alpha_code_2 = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_short_name_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_description_4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_id_5 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_name_6 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_address_1_7 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_address_2_8 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_address_3_9 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_city_10 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_state_11 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_country_12 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_zip_code_13 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_phone_1_14 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_phone_2_15 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_fax_16 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_email_17 = table.Column<string>(type: "varchar(180)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issuer_contact_person_name_18 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_designation_19 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_address_1_20 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_address_2_21 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_address_3_22 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_city_23 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_state_24 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_country_25 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_zip_code_26 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_phone_1_27 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_phone_2_28 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_fax_29 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_person_email_30 = table.Column<string>(type: "varchar(180)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_id_31_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_name_32_nsdl = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_date_from_33_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sebi_registration_date_to_34_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_address_1_35 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_address_2_36 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_address_3_37 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_city_38 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_state_39 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_country_40 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_zip_code_41 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_phone_1_42 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_phone_2_43 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_fax_44 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_email_45 = table.Column<string>(type: "varchar(180)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_share_name_46 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_second_name_47 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_last_name_48 = table.Column<string>(type: "varchar(120)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_address_1_49 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_address_2_50 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_address_3_51 = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_city_52 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_state_53 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_country_54 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_zip_code_55 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_phone_1_56 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_phone_2_57 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_fax_58 = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_email_59 = table.Column<string>(type: "varchar(180)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_type_60 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_type_description_61 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    market_type_62 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    market_type_description_63 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_status_64_nsdl = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_status_description_65_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hold_demat_flag_66 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hold_remat_flag_67 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    expiry_date_68_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    market_lot_69 = table.Column<float>(type: "float", nullable: true),
                    cfi_code_70 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    par_value_71_nsdl = table.Column<float>(type: "float", nullable: true),
                    paidup_value_72_nsdl = table.Column<float>(type: "float", nullable: true),
                    redemption_price_73 = table.Column<float>(type: "float", nullable: true),
                    redemption_date_74 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    close_price_75 = table.Column<float>(type: "float", nullable: true),
                    close_date_76 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_date_77_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    on_going_conversion_78 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conversion_date_79_nsdl = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    distinct_range_exists_80 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_decimal_code_81_nsdl = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_decimal_code_description_82 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_suspended_83 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_suspended_description_84 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    money_due_date_85 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_complete_86 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remarks_87 = table.Column<string>(type: "varchar(180)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_status = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isin_Status_Master_Nsdl_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isin_Status_Master_Nsdl_Cdsl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_status_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    isin_status_record_date_text = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_status_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    full_incremental_flag = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    incremental_reference_datetime = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_number_of_detail_records = table.Column<float>(type: "float", nullable: true),
                    filler = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isin_Status_Master_Nsdl_Cdsl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ISR_1",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PanCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    BankDetailCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    SignatureCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    MobileNumberCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    EmailIdCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    AddressCheckbox = table.Column<ulong>(type: "bit", nullable: false),
                    FirstHolder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecondHolder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThirdHolder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Securities = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FaceValue = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DistinctiveNumbers = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pan_LinkedToAadhaar = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstHolderName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecondHolderName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThirdHolderName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DPIDClientID_CDSLClientID = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProofAddress_Aadhaar = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_ResidenceOrDrivingLicense = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_FlatMaintenance = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_UtilityBills = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_IdentityCard = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_FIIOrSubAccount = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_SpouseAddressProof = table.Column<ulong>(type: "bit", nullable: false),
                    ProofAddress_ClientMasterList = table.Column<ulong>(type: "bit", nullable: false),
                    IFSCCode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountNumber = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BranchName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MobileNumber = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    currentDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISR_1", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isr_2",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bank_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_branch_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_address1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_address2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_address3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_pin_code = table.Column<int>(type: "int(6)", nullable: false),
                    branch_phone = table.Column<long>(type: "bigint", nullable: false),
                    branch_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_account_number = table.Column<long>(type: "bigint", nullable: false),
                    account_opening_date = table.Column<DateTime>(type: "Date", nullable: false),
                    account_first_holder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_joint1_holder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_joint2_holder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_holder1_photo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_holder2_photo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_holder3_photo = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_address1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_address2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_address3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_pin_code = table.Column<int>(type: "int", nullable: false),
                    investor_number = table.Column<long>(type: "bigint", nullable: false),
                    investor_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_signature1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_signature2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    investor_signature3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_manager_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employee_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    place = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isr_2", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isr_3",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_phone = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isr_3", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item_Group_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cat_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_type = table.Column<string>(type: "varchar(5)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cat_main_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    cat_main = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supermain_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    delete_option = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other1 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other2 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other_num1 = table.Column<long>(type: "bigint(10)", nullable: true),
                    other_num2 = table.Column<long>(type: "bigint(10)", nullable: true),
                    gst_tax_slab = table.Column<double>(type: "double(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Group_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    item_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    group_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pur_rate = table.Column<double>(type: "double(18,3)", nullable: true),
                    sal_rate = table.Column<double>(type: "double(18,3)", nullable: true),
                    op_stock = table.Column<double>(type: "double(18,3)", nullable: true),
                    remark_note = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    lower_unit = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    upper_unit = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other3 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    con_qty_1 = table.Column<double>(type: "double(18,3)", nullable: true),
                    min_qty = table.Column<long>(type: "bigint(10)", nullable: true),
                    max_qty = table.Column<long>(type: "bigint(10)", nullable: true),
                    con_qty_2 = table.Column<long>(type: "bigint(10)", nullable: true),
                    other_num5 = table.Column<long>(type: "bigint(10)", nullable: true),
                    nag_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    bag_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    loose_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    nag_conv = table.Column<double>(type: "double(18,3)", nullable: true),
                    bag_conv = table.Column<double>(type: "double(18,3)", nullable: true),
                    nag_packing = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bag_packing = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    loose_packing = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packing_cost = table.Column<double>(type: "double(18,3)", nullable: true),
                    hsn_code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_tax_rate = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_slab_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item_Service_Type_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    item_service_type_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    item_service_type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Service_Type_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Item_Trn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pcode = table.Column<long>(type: "bigint(10)", nullable: true),
                    pname = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    itemcode = table.Column<long>(type: "bigint(10)", nullable: true),
                    itemname = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    against_bill_no = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    auto_bill_nos = table.Column<long>(type: "bigint(10)", nullable: true),
                    group_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    group_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    billno = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    bill_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    iss_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    qty_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    rate_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    amt_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    sub_tot1 = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    gross_tot1 = table.Column<double>(type: "double(18,3)", nullable: true),
                    tax_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    tax_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    taxper = table.Column<double>(type: "double(18,3)", nullable: true),
                    tax_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    net_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    tot_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ir_flag = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vou_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_1 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qty_remark = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    username = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nag_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    bag_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    loose_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    packing_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cartage_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    delivery_date = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_yn = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    form_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bt_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    veh_no = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    station_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    transport_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gr_rr_no = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fraight = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordno = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ord_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_no = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ch_date = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pkg_wgt = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rnd_off_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_per_2 = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt_2 = table.Column<double>(type: "double(18,3)", nullable: true),
                    all_dis_tot = table.Column<double>(type: "double(18,3)", nullable: true),
                    hsn_code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gst_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cartage_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    igst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    igst_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    sgst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    sgst_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    cgst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    cgst_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    reverse_charge = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    electronic_ref_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_no_numric = table.Column<double>(type: "double(18,3)", nullable: true),
                    sub_tot_1st_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_per_1st = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt_1st = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt_1st_tot = table.Column<double>(type: "double(18,3)", nullable: true),
                    rate_after_dis_1st = table.Column<double>(type: "double(18,3)", nullable: true),
                    sub_tot_2nd_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_per_2nd = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt_2nd = table.Column<double>(type: "double(18,3)", nullable: true),
                    dis_amt_2nd_tot = table.Column<double>(type: "double(18,3)", nullable: true),
                    rate_after_dis_2nd = table.Column<double>(type: "double(18,3)", nullable: true),
                    sub_tot_3rd_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    f_rate_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    gst_per_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    gst_amt_on_f_rate_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    gst_amt_tot_trn = table.Column<double>(type: "double(18,3)", nullable: true),
                    rate_after_gst = table.Column<double>(type: "double(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Trn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Letter_Alert_4_Phy",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    letter_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no_master = table.Column<float>(type: "float", nullable: true),
                    req_id_master = table.Column<float>(type: "float", nullable: true),
                    in_ward_id_master = table.Column<float>(type: "float", nullable: true),
                    out_ward_id_master = table.Column<float>(type: "float", nullable: true),
                    req_trx_form_master = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    letter_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    letter_date_issue = table.Column<DateTime>(type: "datetime", nullable: true),
                    letter_date_close = table.Column<DateTime>(type: "datetime", nullable: true),
                    letter_date_next = table.Column<DateTime>(type: "datetime", nullable: true),
                    next_remi_after_days_no = table.Column<float>(type: "float", nullable: true),
                    next_remi_after_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letter_Alert_4_Phy", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Letter_Alert_4_Phy_Trx",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    master_trx_table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    master_table_id = table.Column<float>(type: "float", nullable: true),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    letter_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no_master = table.Column<float>(type: "float", nullable: true),
                    req_id_master = table.Column<float>(type: "float", nullable: true),
                    in_ward_id_master = table.Column<float>(type: "float", nullable: true),
                    out_ward_id_master = table.Column<float>(type: "float", nullable: true),
                    trfdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    trfolio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certno_old = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    distno = table.Column<float>(type: "float", nullable: true),
                    distno_upto = table.Column<float>(type: "float", nullable: true),
                    old_distno = table.Column<float>(type: "float", nullable: true),
                    shares = table.Column<float>(type: "float", nullable: true),
                    letter_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    letter_date_issue = table.Column<DateTime>(type: "datetime", nullable: true),
                    letter_date_close = table.Column<DateTime>(type: "datetime", nullable: true),
                    letter_date_next = table.Column<DateTime>(type: "datetime", nullable: true),
                    next_remi_after_days_no = table.Column<float>(type: "float", nullable: true),
                    next_remi_after_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letter_Alert_4_Phy_Trx", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Log_Comp_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    c_comp_no = table.Column<float>(type: "float", nullable: true),
                    c_id = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_short_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_paid_up_capital = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add4 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phones = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gstin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gst_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pan = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ac_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bcity = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ifsc = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_micr = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_create_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_share_face_value = table.Column<float>(type: "float", nullable: true),
                    c_folio_no_auto_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_no_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    c_company_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_sub_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_more_isin_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_master_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_shares_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tan = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pay_term_days = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_pay_term_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_activate = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_apply = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_creation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_updation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_updated_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode_2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_list_to_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_top10_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_rpt_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_source_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    used_on_date_time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log_Comp_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maker_Checker_Ac_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    maker_checker_log_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_checker_log_id_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_no = table.Column<long>(type: "bigint(10)", nullable: true),
                    bill_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    vou_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    checker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    current_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maker_Checker_Ac_Log_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maker_Checker_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    maker_checker_log_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_checker_log_id_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trfno = table.Column<long>(type: "bigint(10)", nullable: true),
                    trfdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    vou_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    checker_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_status_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    current_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maker_Checker_Log_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Masters_Show_Allow_User",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    master_form_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    master_form_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    master_form_show_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_code = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters_Show_Allow_User", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mker_Cker_Trans_Status_Msg_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    status_msg_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    status_msg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status_msg_for = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mker_Cker_Trans_Status_Msg_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Model_Req",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model_Req", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Multi_Purpose_Type_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
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
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multi_Purpose_Type_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Name_Change_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name_change_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    change_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    change_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    change_flag = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_nm = table.Column<string>(type: "varchar(2255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name_Change_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nominee_Change_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nominee_change_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    change_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    change_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    change_flag = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomgur = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominee_Change_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nsdl_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nsdl_create_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    ben_type = table.Column<float>(type: "float", nullable: true),
                    sub_type = table.Column<float>(type: "float", nullable: true),
                    type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soft_uniq_types = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soft_uniq_code = table.Column<float>(type: "float", nullable: true),
                    p_pi_pn = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_ph = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsdl_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nsdl_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_details = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holder_share_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_lock_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_plg_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    non_promoter = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other_number1_sno = table.Column<float>(type: "float", nullable: true),
                    other_number2_sno = table.Column<float>(type: "float", nullable: true),
                    other_number3_sno = table.Column<float>(type: "float", nullable: true),
                    other_number4_sno = table.Column<float>(type: "float", nullable: true),
                    other_number5_sno = table.Column<float>(type: "float", nullable: true),
                    rtype = table.Column<float>(type: "float", nullable: true),
                    lno = table.Column<float>(type: "float", nullable: true),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ac_num = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_sub_tp = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bacccat = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benocc = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benphn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benfax = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndfhn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thfhn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fil1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    istpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomgur = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dob = table.Column<DateTime>(type: "datetime", nullable: true),
                    minor = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benbank = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bannmbr = table.Column<string>(type: "varchar(135)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiref = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiapdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    sebireg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bentaxst = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benstat = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_positi = table.Column<float>(type: "float", nullable: true),
                    benlock = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benblk = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplglk = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplgun = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplgcloc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benrem = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benremloc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bencmidpos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cmpool = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ccsett = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    micrno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ifsc = table.Column<string>(type: "varchar(111)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnktype = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fstmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fstemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsdl_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nsdl_Master_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_by_username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailed_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailed_sent_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    tot_qty = table.Column<float>(type: "float", nullable: true),
                    tot_transit_qtu = table.Column<float>(type: "float", nullable: true),
                    tot_free_qty = table.Column<float>(type: "float", nullable: true),
                    tot_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_block_qty = table.Column<float>(type: "float", nullable: true),
                    tot_pledged_qty = table.Column<float>(type: "float", nullable: true),
                    tot_pledged_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_unconfirmed_pldg_qty = table.Column<float>(type: "float", nullable: true),
                    tot_uncon_pldg_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    tot_olidt_qty = table.Column<float>(type: "float", nullable: true),
                    tot_remat_qty = table.Column<float>(type: "float", nullable: true),
                    tot_remat_lock_in_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine1_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine2_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine3_qty = table.Column<float>(type: "float", nullable: true),
                    col_not_difine4_qty = table.Column<float>(type: "float", nullable: true),
                    filler_1 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_2 = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_records = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsdl_Master_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nsdl_Master_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_header_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_pn_details = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holder_share_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_lock_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_plg_yn = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    non_promoter = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other_number1_sno = table.Column<float>(type: "float", nullable: true),
                    other_number2_sno = table.Column<float>(type: "float", nullable: true),
                    other_number3_sno = table.Column<float>(type: "float", nullable: true),
                    other_number4_sno = table.Column<float>(type: "float", nullable: true),
                    other_number5_sno = table.Column<float>(type: "float", nullable: true),
                    rtype = table.Column<float>(type: "float", nullable: true),
                    lno = table.Column<float>(type: "float", nullable: true),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ac_num = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_sub_tp = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bacccat = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benocc = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fst_hld_fh = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pa4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_ad_pin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benphn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benfax = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    snd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndfhn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thd_hld_nm = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thfhn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fil1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    istpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdpan = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomgur = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ngpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dob = table.Column<DateTime>(type: "datetime", nullable: true),
                    minor = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benbank = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bannmbr = table.Column<string>(type: "varchar(135)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkad4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnkpin = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiref = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rbiapdt = table.Column<DateTime>(type: "datetime", nullable: true),
                    sebireg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bentaxst = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benstat = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ben_positi = table.Column<float>(type: "float", nullable: true),
                    benlock = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benblk = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplglk = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplgun = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benplgcloc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benrem = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    benremloc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bencmidpos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cmpool = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ccsett = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    micrno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ifsc = table.Column<string>(type: "varchar(111)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bnktype = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fstmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdmapin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fstemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sndemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thdemail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fill4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsdl_Master_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nsdl_Master_03",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    benpos_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    import_id = table.Column<float>(type: "float", nullable: true),
                    import_id_txt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_sno = table.Column<float>(type: "float", nullable: true),
                    comp_isin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_by_username = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_position_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_positions = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lock_in_indicator = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lock_in_reason_code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lock_in_release_date = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_number = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsdl_Master_03", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Partymaster",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pcode = table.Column<long>(type: "bigint(10)", nullable: true),
                    pname = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_option = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    group_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    group_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gmain_code = table.Column<long>(type: "bigint(10)", nullable: true),
                    gmain_g_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mr_mrs_ms = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    marital_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    d_o_birth = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    anni_date = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lovelty = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remarks = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    landline_phno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mobile_phno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add5 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add6 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add7 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add8 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    add9 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    op_bal = table.Column<float>(type: "float", nullable: true),
                    dr_cr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gstin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cst_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_opening_date = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    depart_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    designation = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    entry_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    transport_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other6 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other7 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other8 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other9 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other10 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_dis_per = table.Column<long>(type: "bigint(10)", nullable: true),
                    gst_tax_rate = table.Column<long>(type: "bigint(10)", nullable: true),
                    other13 = table.Column<long>(type: "bigint(10)", nullable: true),
                    other14 = table.Column<long>(type: "bigint(10)", nullable: true),
                    other15 = table.Column<long>(type: "bigint(10)", nullable: true),
                    pay_term_days = table.Column<long>(type: "bigint(10)", nullable: true),
                    bill_dis_per_2 = table.Column<double>(type: "double(18,3)", nullable: true),
                    addhar_no = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pcode_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_id = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partymaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Partytrn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    party_cd = table.Column<long>(type: "bigint(10)", nullable: true),
                    party_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_group_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    ac_group_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_and_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fin_year = table.Column<string>(type: "varchar(9)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bill_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    narr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    debit = table.Column<double>(type: "double(18,3)", nullable: true),
                    credit = table.Column<double>(type: "double(18,3)", nullable: true),
                    inwoutno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gross_amt_all = table.Column<double>(type: "double(18,3)", nullable: true),
                    gst_amt_all = table.Column<double>(type: "double(18,3)", nullable: true),
                    grand_amt_all = table.Column<double>(type: "double(18,3)", nullable: true),
                    tax_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tax_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    tax_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    aganist_narr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chequeno = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio = table.Column<double>(type: "double(18,3)", nullable: true),
                    folio_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    upd_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    del_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_qty = table.Column<double>(type: "double(18,3)", nullable: true),
                    rate = table.Column<double>(type: "double(18,3)", nullable: true),
                    spot_ind = table.Column<long>(type: "bigint(10)", nullable: true),
                    value_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    group_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    groupx = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    report_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mode_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    auto_bill_nos = table.Column<long>(type: "bigint(10)", nullable: true),
                    s_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_no_bill_no = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_day_name = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_date = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_month_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_month_name = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_year = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_gst_type = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ptrn_gross_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_tot_gst = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_vou_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_igst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_igst_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_sgst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_sgst_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_cgst_per = table.Column<double>(type: "double(18,3)", nullable: true),
                    ptrn_cgst_amt = table.Column<double>(type: "double(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partytrn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Ac_Purc",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pdf_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pdf_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_purc_bill_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pdf_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Ac_Purc", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Ac_Req_Iss",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pdf_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pdf_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_req_iss_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pdf_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Ac_Req_Iss", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Ac_Req_Rec",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pdf_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pdf_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_req_rec_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pdf_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Ac_Req_Rec", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Ac_Sale",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pdf_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pdf_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ac_sale_bill_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pdf_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Ac_Sale", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Companies",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Companies", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_In_Ward",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_In_Ward", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Out_Ward",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Out_Ward", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pdf_Store_Master_Req_Rec",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    store_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    record_insert_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    store_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phy_cdsl_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdf_Store_Master_Req_Rec", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pendency_Event_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pendency_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pendency_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_assign_to = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendency_Event_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pendency_Event_Master_Log",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pendency_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pendency_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_assign_to = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendency_Event_Master_Log", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pendency_Event_Master_Trn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pendency_trn_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    pendency_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    pendency_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_assign_to = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    pendency_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pendency_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendency_Event_Master_Trn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Per_Day_Holding_All_Comp",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trx_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_id = table.Column<float>(type: "float", nullable: true),
                    lock_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mix_match_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    import_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    import_day_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_op = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    pre_day_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    cdsl_in_nsdl_out_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_in_cdsl_out_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_re_demat_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    cdsl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    nsdl_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_credit_qty = table.Column<float>(type: "float", nullable: true),
                    phy_ca_debit_qty = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_phy = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    cur_holding_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_closing_qty_cdsl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exch_closing_qty_nsdl = table.Column<float>(type: "float", nullable: true),
                    exch_cls_qty_remark_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    paid_up_capital_qty_cls = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Per_Day_Holding_All_Comp", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phy_Category_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    phy_create_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    ben_type = table.Column<float>(type: "float", nullable: true),
                    sub_type = table.Column<float>(type: "float", nullable: true),
                    type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soft_uniq_types = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soft_uniq_code = table.Column<float>(type: "float", nullable: true),
                    p_pi_pn = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    p_pi_ph = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phy_Category_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Protal_Link_Maitain_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    portal_link_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portal_link_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portal_link_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portal_link_url = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protal_Link_Maitain_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Purpose_Mst",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purpose_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purpose_id = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purpose_Mst", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recent_Comp_Selection_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    c_comp_sno = table.Column<float>(type: "float", nullable: true),
                    c_comp_isin = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_comp_short_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_paid_up_capital = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add4 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_website = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phones = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gstin = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_gst_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pan = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ac_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd1 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_badd3 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bcity = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bstate_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_ifsc = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_bank_micr = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_create_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_share_face_value = table.Column<float>(type: "float", nullable: true),
                    c_folio_no_auto_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_sub_code = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_database_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_more_isin_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_isin = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_master_comp_code = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_master_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_nsdl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_cdsl_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_shares_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tan = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pay_term_days = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_pay_term_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_activate = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_apply = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_d_o_creation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_d_o_updation = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_updated_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_person2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_ph2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_contact_p_email2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add1_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add2_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_add3_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_city2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode_2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_state_code2 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_list_to_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_top10_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_other_rpt_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_source_email_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_maintain_type = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_data_tyep_description = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_isin_type = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_demat_both = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_pincode = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_group_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_issuer_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_phy_conn_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_rep_weekly_email_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_company_old_code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    c_tot_equity = table.Column<double>(type: "double(18,3)", nullable: true),
                    cin_bcin_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no_auto_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    temp_comp_id = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    used_on_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    c_comp_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_tot_equity_fully = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_tot_equity_partly = table.Column<double>(type: "double(18,3)", nullable: true),
                    c_share_face_value_partly = table.Column<double>(type: "double(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recent_Comp_Selection_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Cdsl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reco_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_time = table.Column<string>(type: "varchar(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_det_rec = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Cdsl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Cdsl_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    reco_import_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_alpha_code_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_description_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_status_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirm_description_4 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cds_opening_balance_5 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_opening_balance_6 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_demat_confirmation_balance_7 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_demat_confirmation_balance_8 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_remat_confirmation_balance_9 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_remat_confirmation_balance_10 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_inter_depository_transfer_in_balance_11 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_inter_depository_transfer_in_balance_12 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_inter_depository_transfer_out_balance_13 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_inter_depository_transfer_out_balance_14 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_corporate_actions_transfer_additions_15 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_corporate_actions_transfer_additions_16 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_corporate_actions_transfer_subtractions_17 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_corporate_actions_transfer_subtractions_18 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_ipo_additions_19 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_ipo_additions_20 = table.Column<double>(type: "double(18,3)", nullable: true),
                    cds_closing_balance_21 = table.Column<double>(type: "double(18,3)", nullable: true),
                    rta_closing_balance_22 = table.Column<double>(type: "double(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Cdsl_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Import_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    reco_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_time = table.Column<string>(type: "varchar(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_det_rec = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Import_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Import_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    reco_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_no = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_short = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flag_for_decimal_isin = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_free_positions = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_lock_positions = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_unlock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_lock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_demat_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_remat_free_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_remat_lock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_delivery_transit_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_receipt_transit_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(162)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler2 = table.Column<string>(type: "varchar(13)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Import_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Import_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Import_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Nsdl_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reco_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_dt = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_pre_time = table.Column<string>(type: "varchar(6)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tot_no_of_det_rec = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Nsdl_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Nsdl_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reco_import_trx_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_no = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_short = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flag_for_decimal_isin = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_free_positions = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_lock_positions = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_unlock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_lock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_demat_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_remat_free_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pending_remat_lock_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_delivery_transit_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nsdl_receipt_transit_balance = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler = table.Column<string>(type: "varchar(162)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler2 = table.Column<string>(type: "varchar(13)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Nsdl_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Nsdl_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Nsdl_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Process_Report_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    reco_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    procces_started_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    procces_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    day_procesed = table.Column<float>(type: "float", nullable: true),
                    mix_match_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mis_match_days = table.Column<float>(type: "float", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    paid_up_capital_qty_op = table.Column<float>(type: "float", nullable: true),
                    paid_up_capital_qty_cls = table.Column<float>(type: "float", nullable: true),
                    diff_in_capital_qty = table.Column<float>(type: "float", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Process_Report_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reco_Row_File_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reco_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reco_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reco_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folder_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reco_Row_File_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reject_Code_Msg_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rej_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    reject_code = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_reason = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_flag = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nature_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flag_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reject_Code_Msg_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reject_Code_Msg_Master_Trx",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    old_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    rej_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    rej_reason_trx = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reject_Code_Msg_Master_Trx", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rejres",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rej_id = table.Column<float>(type: "float", nullable: true),
                    reject_code = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_reason = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rej_flag = table.Column<string>(type: "varchar(60)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejres", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Drn_Status",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    setup_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    setup_complete_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    document_recv_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    second_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    third_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    share_qty_drn = table.Column<double>(type: "double(18,3)", nullable: true),
                    drn_no = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_running_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trf_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    trf_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    trf_days_count = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id_reject_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_id_days_count = table.Column<double>(type: "double(18,3)", nullable: true),
                    in_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    in_w_id_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    in_w_id_days_count = table.Column<double>(type: "double(18,3)", nullable: true),
                    out_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    out_w_id_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    out_w_id_days_count = table.Column<double>(type: "double(18,3)", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Drn_Status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Drn_Status_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    drn_no = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_vou_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_running_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trf_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id_reject_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    in_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    out_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_rec_complete_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Drn_Status_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Drn_Status_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    drn_no = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_vou_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_running_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trf_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_id_reject_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    in_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    out_w_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_rec_complete_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Drn_Status_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    req_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_ref_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_ref_entry_dt = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_flag_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checking_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_holder_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_foliono = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_certi_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_dist_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_sha_qty = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_form_master = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_entry_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unique_trn_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_by_username = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_status_msg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    suggestion_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    derno = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id_delete_status = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_id_delete_status_id = table.Column<float>(type: "float", nullable: true),
                    req_holder_name_2 = table.Column<string>(type: "varchar(150)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_holder_name_3 = table.Column<string>(type: "varchar(150)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multiple_folio = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    master_trfno = table.Column<float>(type: "float", nullable: true),
                    master_req_id = table.Column<float>(type: "float", nullable: true),
                    multiple_trx_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multiple_req_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multiple_req_ref_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multiple_req_flag_codes_and_names = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    setup_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    share_qty_tot = table.Column<float>(type: "float", nullable: true),
                    certificate_tot = table.Column<float>(type: "float", nullable: true),
                    partial_demat_request_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_holder_name_as_per_record_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_holder_name_as_per_record_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_holder_name_as_per_record_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mis_match_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mis_match_present_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    kyc_status = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_from_setup_file_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    validate_inward_id_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_folio_no_req = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    multi_folio_count = table.Column<float>(type: "float", nullable: true),
                    allow_drn_setup_mismatch_folio_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Master_Comp",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    request_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_isin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rec_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    work_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sender_contact_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pod_rec_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cl_id_folio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    work_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_req_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schedule_req_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trfno = table.Column<float>(type: "float", nullable: true),
                    trf_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    verify_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    item_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    work_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chargable_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chargable_unit = table.Column<double>(type: "double(18,3)", nullable: true),
                    chargable_amt = table.Column<double>(type: "double(18,3)", nullable: true),
                    chargable_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Master_Comp", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Master_Comp_Docus",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    docu_type_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Master_Comp_Docus", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Master_Comp_Schedule",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    schedule_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schedule_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    schedule_sno = table.Column<double>(type: "double(18,3)", nullable: true),
                    schedule_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Master_Comp_Schedule", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Master_Multi",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_flag_name_id = table.Column<float>(type: "float", nullable: true),
                    req_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    master_req_id = table.Column<float>(type: "float", nullable: true),
                    req_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_flag_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trfno = table.Column<float>(type: "float", nullable: true),
                    trfdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    vou_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Master_Multi", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_01_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_bp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_name = table.Column<string>(type: "varchar(135)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_demat_positions_conversion_of_units_request = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_requested = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_requested = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_num_of_dmat_conversion_of_units_instr = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_num_of_remat_instr_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_repurchase_redemption_instr_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_partially_pending_demat_conversion_of_units_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_partially_pending_remat_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_partially_pending_repurchase_redemption_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_fully_pending_demat_conversion_of_units_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_fully_pending_remat_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_fully_pending_repurchase_redemption_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_detail_records_7 = table.Column<float>(type: "float", nullable: true),
                    full_incremental_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    incremental_reference_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_01 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_01_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_01_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_bp_id = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sr_name = table.Column<string>(type: "varchar(135)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statement_preparation_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_demat_positions_conversion_of_units_request = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_demat_positions_conversion_of_units_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_requested = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_remat_positions_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_requested = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_accepted = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_rejected = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_repurchase_redemption_position_pending = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_num_of_dmat_conversion_of_units_instr = table.Column<double>(type: "double(18,3)", nullable: true),
                    total_num_of_remat_instr_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_repurchase_redemption_instr_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_partially_pending_demat_conversion_of_units_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_partially_pending_remat_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_partially_pending_repurchase_redemption_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_fully_pending_demat_conversion_of_units_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_fully_pending_remat_8 = table.Column<float>(type: "float", nullable: true),
                    total_num_of_fully_pending_repurchase_redemption_8 = table.Column<float>(type: "float", nullable: true),
                    total_number_of_detail_records_7 = table.Column<float>(type: "float", nullable: true),
                    full_incremental_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    incremental_reference_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_01 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_01_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_02_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    setup_complete_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    document_recv_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_rta_id_0 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_dp_id_1 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_request_number_2 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity_type_code_3 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity_type_description_4 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_requested_quantity_5 = table.Column<float>(type: "float", nullable: true),
                    accepted_quantity_6 = table.Column<float>(type: "float", nullable: true),
                    rejected_qty_7 = table.Column<float>(type: "float", nullable: true),
                    lock_in_quantity_8 = table.Column<float>(type: "float", nullable: true),
                    lock_in_reason_code_9 = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lock_in_reason_description_10 = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_of_certificates_11 = table.Column<float>(type: "float", nullable: true),
                    demat_request_status_code_12 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_request_status_description_13 = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_14 = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_name_15 = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_type_16 = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    security_description_17 = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_setup_date_dd_mon_yyyy_18 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_received_date_by_rta_dd_mon_yyyy_19 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_closed_date_by_rta_dd_mon_yyyy_20 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_account_number_21 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drf_no_22 = table.Column<string>(type: "varchar(32)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rta_internal_reference_number_23 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    number_of_days_pending_24 = table.Column<float>(type: "float", nullable: true),
                    days_remaining_to_confirm_25 = table.Column<float>(type: "float", nullable: true),
                    name_first_sole_holder_name_26 = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_joint_holders_name_27 = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    second_joint_holders_name_28 = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_address_line_1_29 = table.Column<string>(type: "varchar(155)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_address_line_2_30 = table.Column<string>(type: "varchar(155)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_address_line_3_31 = table.Column<string>(type: "varchar(155)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_towncity_32 = table.Column<string>(type: "varchar(125)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_state_33 = table.Column<string>(type: "varchar(125)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_country_34 = table.Column<string>(type: "varchar(125)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_pin_code_35 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bo_poa_name_36 = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rejection_sequence_37 = table.Column<float>(type: "float", nullable: true),
                    rejected_quantity_38 = table.Column<float>(type: "float", nullable: true),
                    rejection_code_39 = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_40 = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_02_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_02_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    setup_complete_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    document_recv_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_number = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_remat_soa_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn_crn = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_account_number = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_02_1 = table.Column<string>(type: "varchar(115)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    second_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    third_holders_name = table.Column<string>(type: "varchar(142)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    free_lock_flag = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    locked_in_reason_code = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    locked_in_release_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    requested_quantity = table.Column<double>(type: "double(18,3)", nullable: true),
                    internal_reference_number = table.Column<string>(type: "varchar(35)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    instruction_receive_date_setup_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    drf_rrf_receive_date_crf_receive_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn_status_crn_status = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_number = table.Column<string>(type: "varchar(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_date = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    accepted_quantity = table.Column<double>(type: "double(18,3)", nullable: true),
                    rejected_quantity = table.Column<double>(type: "double(18,3)", nullable: true),
                    confirmation_capture_date_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_release_date_time = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    instruction_receipt_date_time_from_nsdl_dm = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirmation_status = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_1 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_2 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_3 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_reason_4 = table.Column<string>(type: "varchar(4)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_of_certificates = table.Column<string>(type: "varchar(8)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    all_units_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    all_units_final_confirmation_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_sub_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_address_part_1_bp_addr_1 = table.Column<string>(type: "varchar(136)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_address_part_2_bp_addr_2 = table.Column<string>(type: "varchar(136)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_address_part_3_bp_addr_3 = table.Column<string>(type: "varchar(136)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_address_part_4_bp_addr_4 = table.Column<string>(type: "varchar(136)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_address_pin_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holder_pan = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    second_holder_pan = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    third_holder_pan = table.Column<string>(type: "varchar(130)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holder_phone_number = table.Column<string>(type: "varchar(24)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holder_bank_name = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_holder_bank_account_no = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    micr_code = table.Column<string>(type: "varchar(9)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    indian_financial_system_code_ifsc = table.Column<string>(type: "varchar(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_status = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_02_2 = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_02_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_03_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rtm8_trx_no = table.Column<float>(type: "float", nullable: true),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_number = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_remat_soa_indicator = table.Column<string>(type: "varchar(28)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn_crn = table.Column<string>(type: "varchar(24)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_account_number = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_number = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certificate_number = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certificate_number_upto = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dnr_from = table.Column<float>(type: "float", nullable: true),
                    dnr_to = table.Column<float>(type: "float", nullable: true),
                    quantity = table.Column<float>(type: "float", nullable: true),
                    name_mismatch_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_03 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_03_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_03_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    line_number = table.Column<string>(type: "varchar(7)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dp_id = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    demat_remat_soa_indicator = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn_crn = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    beneficiary_account_number = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_number = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certificate_number = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dnr_from = table.Column<float>(type: "float", nullable: true),
                    dnr_to = table.Column<float>(type: "float", nullable: true),
                    quantity = table.Column<float>(type: "float", nullable: true),
                    name_mismatch_indicator = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filler_03 = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    certificate_number_upto = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_03_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_01",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    rtm8_01_ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rtm8_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_identifier = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total_records = table.Column<double>(type: "double(18,3)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_Cdsl_Rtm8_01", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_02",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    rtm8_02_ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rtm8_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    rec_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_identifier = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    drn_rrn_crn = table.Column<string>(type: "varchar(40)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    record_number = table.Column<double>(type: "double(18,3)", nullable: true),
                    ranges_from_number_dnfrm = table.Column<double>(type: "double(18,3)", nullable: true),
                    ranges_to_number_dnto = table.Column<double>(type: "double(18,3)", nullable: true),
                    folio_number = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cert_frm = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cert_to = table.Column<string>(type: "varchar(18)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alrt_flag = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mismatch_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_Cdsl_Rtm8_02", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_Row_File",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    ref_no = table.Column<double>(type: "double(18,3)", nullable: true),
                    ref_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "varchar(1000)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    tmp_trx_no = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_batch_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    rtm8_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_Cdsl_Rtm8_Row_File", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_Row_File_Cdsl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folder_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_Row_File_Cdsl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rec_Online_Row_File_Nsdl",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    trx_no = table.Column<float>(type: "float", nullable: true),
                    trx_no_text = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trx_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_online_isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_online_isin_company = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_record_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_record_date_text = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    enter_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    row_file_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_exchange_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_text1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    row_header_type = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folder_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    computer_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rec_Online_Row_File_Nsdl", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Recv_Master_Online_Alert",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    exchange_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alert_code_no = table.Column<float>(type: "float", nullable: true),
                    alert_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alert_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Recv_Master_Online_Alert", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Req_Rej_Flag_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rr_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    rr_flag_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rr_flag_form_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rejection_days = table.Column<float>(type: "float", nullable: true),
                    rej_days_incl_holidays = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comform_days = table.Column<float>(type: "float", nullable: true),
                    comform_days_incl_holidays = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rr_flag_form_name_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rr_trx_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Req_Rej_Flag_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rta_Company_Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    upload_id_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operator_id_cdsl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    upload_id_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operator_id_nsdl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ph_nos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    owner_nanme = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_pcode = table.Column<double>(type: "double(18,3)", nullable: true),
                    company_short = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    de_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tan_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pan_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_gstin = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_country = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_country = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_pincode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_state_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_state_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_add_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_add_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_pincode = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_mobile_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_landline_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    branch_off_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resister_mobile_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resister_landline_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resister_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_add_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_add_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    register_state_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_contact_person = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_mobile_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_landline_ph = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bstate_country = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bstate = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bcity = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    badd3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    badd2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    badd1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_micr = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_ifsc = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_ac_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bank_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    depository_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    member_in_exchange = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    compliance_officer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    compliance_officer_mob = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rta_Company_Detail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sample_Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    profession = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    institute = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isActive = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_Detail", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sh_13",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptions3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_dob = table.Column<DateTime>(type: "date", nullable: true),
                    particulars_nominee_father_mother_spouse_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_occupation = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_nationality = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_pincode = table.Column<long>(type: "bigint", nullable: true),
                    particulars_nominee_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_security_holder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_dob = table.Column<DateTime>(type: "date", nullable: true),
                    minor_nominee_date_of_attaining_majority = table.Column<DateTime>(type: "date", nullable: true),
                    minor_nominee_guardian_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_pincode = table.Column<long>(type: "bigint", nullable: true),
                    minor_nominee_status = table.Column<ulong>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sh_13", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sh_14",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    company_address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nominee_type_cancel = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nominate_type_required = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_dob = table.Column<DateTime>(type: "date", nullable: true),
                    particulars_nominee_father_mother_spouse_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_occupation = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_nationality = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_address_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_pincode = table.Column<long>(type: "bigint", nullable: true),
                    particulars_nominee_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    particulars_nominee_security_holder = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_dob = table.Column<DateTime>(type: "date", nullable: true),
                    minor_nominee_date_of_attaining_majority = table.Column<DateTime>(type: "date", nullable: true),
                    minor_nominee_guardian_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_address_line_3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_city = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_pincode = table.Column<long>(type: "bigint", nullable: true),
                    holder1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holder2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    holder3 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minor_nominee_status = table.Column<ulong>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sh_14", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "State_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    state_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    state_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_no = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_code = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "System_Display_Helper_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_auto_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    table_field_extra_string_before = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_field_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_field_extra_string_after = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    table_field_display_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    selected_table = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    selected_table_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    index_no = table.Column<long>(type: "bigint(10)", nullable: true),
                    diplay_status = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_by = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    help_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    help_updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Display_Helper_Master", x => x.id);
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
                    other2 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other3 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other4 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other5 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other6 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other7 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other8 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other9 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other10 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other11 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other12 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other13 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other14 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other15 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other16 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other17 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other18 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other19 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other20 = table.Column<DateTime>(type: "datetime", nullable: true),
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
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Records", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Task_Event_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    task_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    task_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_assign_to_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task_Event_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Task_Event_Master_Log",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    task_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    task_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_assign_to_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task_Event_Master_Log", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Task_Event_Master_Trn",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    task_trn_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    task_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    task_created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_detail_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_assign_to_user = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_enable_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_yn = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_updated_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_verify_checker_status_msg = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_verify_checker_verify_remark = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_start_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_end_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_run_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_weekdays = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_months = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_selected_days = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_activate_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    task_completed_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    task_completed_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task_Event_Master_Trn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Unit_Type_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unit_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    unit_type_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Type_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
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
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
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
                name: "Verify_Log_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    verify_log_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    verify_log_detail = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_captcha = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_checker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_checker_mobile = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_checker_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_maker_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_maker_mobile = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_maker_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_updated_by_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_used_for = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    verify_log_updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verify_Log_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vers_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    vers_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    version_detail = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version_updated_on = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vers_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ward_Master_In",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    iw_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    iw_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_rec_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_in_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_inward_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_contact = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_cl_id_folio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_drn_rr_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_in_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_id = table.Column<float>(type: "float", nullable: true),
                    req_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_reject_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imported_iw_atuo_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    trfno = table.Column<float>(type: "float", nullable: true),
                    vou_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filling_master_auto_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    filling_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    un_delivered_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    un_delivered_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    un_delivered_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pod_rec_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    courier_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward_Master_In", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ward_Master_Out",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    iw_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    iw_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_rec_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_in_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_inward_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_despatch_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_destination = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_despatch_wt = table.Column<float>(type: "float", nullable: true),
                    iw_despatch_amt = table.Column<float>(type: "float", nullable: true),
                    iw_despatch_to_be_bill = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_contact = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_cl_id_folio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_drn_rr_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_in_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_comp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_id = table.Column<float>(type: "float", nullable: true),
                    req_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_rec_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    req_rec_reject_yn = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imported_iw_atuo_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cplt_rec_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    despatch_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    entry_date_4_despatch = table.Column<DateTime>(type: "datetime", nullable: true),
                    un_delivered_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    un_delivered_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    un_delivered_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exchange_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    courier_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward_Master_Out", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ward_Master_Out1",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    iw_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    iw_status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_pod_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_manual_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_rec_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_rec_compl_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_in_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    iw_inward_category = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_despatch_by = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_destination = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_despatch_wt = table.Column<float>(type: "float", nullable: true),
                    iw_despatch_amt = table.Column<float>(type: "float", nullable: true),
                    iw_despatch_to_be_bill = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_sender_contact = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail1 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_address_detail2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_dp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_cl_id_folio = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_drn_rr_no = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_receiver_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_maker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_checker_flag = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_docu_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_purpose_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iw_in_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    io_finish_datetime_auto = table.Column<DateTime>(type: "datetime", nullable: true),
                    io_finish_user_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward_Master_Out1", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comp_db",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompMstId = table.Column<long>(type: "bigint(10)", nullable: false),
                    server = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    db_name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    db_user = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    db_pass = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comp_db", x => x.id);
                    table.ForeignKey(
                        name: "FK_comp_db_Comp_Selection_Master_CompMstId",
                        column: x => x.CompMstId,
                        principalTable: "Comp_Selection_Master",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Complaint_Trx_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    reply_to = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reply_date = table.Column<DateTime>(type: "date", nullable: true),
                    master_id = table.Column<long>(type: "bigint", nullable: false),
                    action_taken = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    action_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reject_yn = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reason_of_reject_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nature_of_complaint = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nature_of_complaint_detail = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nature_of_complaint_remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint_Trx_Master", x => x.id);
                    table.ForeignKey(
                        name: "FK_Complaint_Trx_Master_Complaint_Master_master_id",
                        column: x => x.master_id,
                        principalTable: "Complaint_Master",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "forms_trx_master",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    form_master_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    user_name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_code = table.Column<long>(type: "bigint(10)", nullable: true),
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
                    table.PrimaryKey("PK_forms_trx_master", x => x.id);
                    table.ForeignKey(
                        name: "FK_forms_trx_master_forms_master_form_master_id",
                        column: x => x.form_master_id,
                        principalTable: "forms_master",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Folio_Master",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<long>(type: "bigint", nullable: false),
                    security_qty = table.Column<long>(type: "bigint", nullable: false),
                    securities_facevalue = table.Column<long>(type: "bigint", nullable: false),
                    securities_distinctive_number = table.Column<long>(type: "bigint", nullable: false),
                    master_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folio_Master", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Folio_Master_ISR_1_master_id",
                        column: x => x.master_id,
                        principalTable: "ISR_1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Holders_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    signature = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    address1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    address3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    pin_code = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    master_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holders_Master", x => x.id);
                    table.ForeignKey(
                        name: "FK_Holders_Master_ISR_1_master_id",
                        column: x => x.master_id,
                        principalTable: "ISR_1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Isr_3_securities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nature_securities = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<int>(type: "int", nullable: false),
                    no_of_securities = table.Column<int>(type: "int", nullable: false),
                    certificate_no = table.Column<int>(type: "int", nullable: false),
                    distinctive_no = table.Column<int>(type: "int", nullable: false),
                    master_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isr_3_securities", x => x.id);
                    table.ForeignKey(
                        name: "FK_Isr_3_securities_Isr_3_master_id",
                        column: x => x.master_id,
                        principalTable: "Isr_3",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sh_13_securities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nature_securities = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<int>(type: "int", nullable: false),
                    no_of_securities = table.Column<int>(type: "int", nullable: false),
                    certificate_no = table.Column<int>(type: "int", nullable: false),
                    distinctive_no = table.Column<int>(type: "int", nullable: false),
                    master_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sh_13_securities", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sh_13_securities_Sh_13_master_id",
                        column: x => x.master_id,
                        principalTable: "Sh_13",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sh_14_securities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nature_securities = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folio_no = table.Column<int>(type: "int", nullable: false),
                    no_of_securities = table.Column<int>(type: "int", nullable: false),
                    certificate_no = table.Column<int>(type: "int", nullable: false),
                    distinctive_no = table.Column<int>(type: "int", nullable: false),
                    master_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sh_14_securities", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sh_14_securities_Sh_14_master_id",
                        column: x => x.master_id,
                        principalTable: "Sh_14",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User_Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: " bigint(10) auto_increment", nullable: false)
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
                    user_profile_id = table.Column<long>(type: "bigint(10)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_comp_db_CompMstId",
                table: "comp_db",
                column: "CompMstId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_Trx_Master_master_id",
                table: "Complaint_Trx_Master",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Folio_Master_master_id",
                table: "Folio_Master",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_forms_trx_master_form_master_id",
                table: "forms_trx_master",
                column: "form_master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Holders_Master_master_id",
                table: "Holders_Master",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Isr_3_securities_master_id",
                table: "Isr_3_securities",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sh_13_securities_master_id",
                table: "Sh_13_securities",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sh_14_securities_master_id",
                table: "Sh_14_securities",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Detail_user_code",
                table: "User_Detail",
                column: "user_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Detail_user_profile_id",
                table: "User_Detail",
                column: "user_profile_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_Pas_6_Master_Tmp");

            migrationBuilder.DropTable(
                name: "A_Pas_6_Qty_Master_Tmp");

            migrationBuilder.DropTable(
                name: "A1_Dn_Test");

            migrationBuilder.DropTable(
                name: "Ac_Category_Master");

            migrationBuilder.DropTable(
                name: "All_Comp_Holding_Master");

            migrationBuilder.DropTable(
                name: "Appointment_Master_2022");

            migrationBuilder.DropTable(
                name: "Auth_Token");

            migrationBuilder.DropTable(
                name: "Balance_Sheet");

            migrationBuilder.DropTable(
                name: "Benpos_Path_Master_1718");

            migrationBuilder.DropTable(
                name: "Benpos_Process_Control_Mst_1718");

            migrationBuilder.DropTable(
                name: "Benpos_Process_Master_1718");

            migrationBuilder.DropTable(
                name: "Ca_Codes_Type_Master");

            migrationBuilder.DropTable(
                name: "Ca_Upload_Cdsl_01");

            migrationBuilder.DropTable(
                name: "Ca_Upload_Cdsl_03");

            migrationBuilder.DropTable(
                name: "Category_Master");

            migrationBuilder.DropTable(
                name: "Category_Master_4_All_Exchange");

            migrationBuilder.DropTable(
                name: "Categroy_Master_Nsdl");

            migrationBuilder.DropTable(
                name: "Categroy_Master_Phy");

            migrationBuilder.DropTable(
                name: "Cdsl_Category_Master");

            migrationBuilder.DropTable(
                name: "Cdsl_Master");

            migrationBuilder.DropTable(
                name: "Cdsl_Master_01");

            migrationBuilder.DropTable(
                name: "Cdsl_Master_02");

            migrationBuilder.DropTable(
                name: "Check_List_Master");

            migrationBuilder.DropTable(
                name: "comp_db");

            migrationBuilder.DropTable(
                name: "Comp_Name");

            migrationBuilder.DropTable(
                name: "Comp_Per_Day_Holding_Det");

            migrationBuilder.DropTable(
                name: "Comp_Per_Day_Holding_Det_All_Comp");

            migrationBuilder.DropTable(
                name: "Comp_Selection_Master_Recently");

            migrationBuilder.DropTable(
                name: "Complaint_Rec_Master");

            migrationBuilder.DropTable(
                name: "Complaint_Rec_Trn");

            migrationBuilder.DropTable(
                name: "Complaint_Reply_Trn");

            migrationBuilder.DropTable(
                name: "Complaint_Trx_Master");

            migrationBuilder.DropTable(
                name: "Correspondence_Master");

            migrationBuilder.DropTable(
                name: "Delete_And_Create_Master");

            migrationBuilder.DropTable(
                name: "Demat_Batch_Id_Master");

            migrationBuilder.DropTable(
                name: "Demat_Out_Cdsl_01");

            migrationBuilder.DropTable(
                name: "Demat_Out_Cdsl_02");

            migrationBuilder.DropTable(
                name: "Demat_Out_Nsdl_01");

            migrationBuilder.DropTable(
                name: "Demat_Out_Nsdl_02");

            migrationBuilder.DropTable(
                name: "Despatch_By_Mst");

            migrationBuilder.DropTable(
                name: "Destination_Mst");

            migrationBuilder.DropTable(
                name: "Distribution_Slab_Master");

            migrationBuilder.DropTable(
                name: "Docs_Multi_Save_Trx_Master");

            migrationBuilder.DropTable(
                name: "Docu_Type_Mst");

            migrationBuilder.DropTable(
                name: "Dp_Cl_Id_Master");

            migrationBuilder.DropTable(
                name: "Dp_Import_Row_File");

            migrationBuilder.DropTable(
                name: "Dp_Master_Nsdl_Cdsl");

            migrationBuilder.DropTable(
                name: "Dp_Master_Nsdl_Cdsl_01");

            migrationBuilder.DropTable(
                name: "Email_Log_Master");

            migrationBuilder.DropTable(
                name: "Email_Sender_Master");

            migrationBuilder.DropTable(
                name: "Email_Sent_To_Master");

            migrationBuilder.DropTable(
                name: "Email_Smtserver_Master");

            migrationBuilder.DropTable(
                name: "Email_Users_Master");

            migrationBuilder.DropTable(
                name: "Error_Code_Master");

            migrationBuilder.DropTable(
                name: "Event_Multi_Save_Trx_Master");

            migrationBuilder.DropTable(
                name: "Exch_Category_Master");

            migrationBuilder.DropTable(
                name: "Exch_Category_Master_Software");

            migrationBuilder.DropTable(
                name: "Exch_Sub_Category_Master");

            migrationBuilder.DropTable(
                name: "Field_Master_4_Error");

            migrationBuilder.DropTable(
                name: "Field_Master_4_Update");

            migrationBuilder.DropTable(
                name: "Filling_Doc_Maintain_Master");

            migrationBuilder.DropTable(
                name: "Filling_Doc_Trx_Master");

            migrationBuilder.DropTable(
                name: "Fin_Year_Selection_Master");

            migrationBuilder.DropTable(
                name: "Folio_Master");

            migrationBuilder.DropTable(
                name: "Folio_Multi_Dist_Save_Trx_Master");

            migrationBuilder.DropTable(
                name: "forms_trx_master");

            migrationBuilder.DropTable(
                name: "Holders_Master");

            migrationBuilder.DropTable(
                name: "Holiday_Master_2022");

            migrationBuilder.DropTable(
                name: "Iepf_Detail_Ndsl_Ndsl");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Ac_Purc");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Ac_Req_Iss");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Ac_Req_Rec");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Ac_Sale");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Companies");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_In_Ward");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Out_Ward");

            migrationBuilder.DropTable(
                name: "Images_Store_Master_Req_Rec");

            migrationBuilder.DropTable(
                name: "In_Out_Ward_Cate_Mst");

            migrationBuilder.DropTable(
                name: "Inter_Depository_01");

            migrationBuilder.DropTable(
                name: "Inter_Depository_02");

            migrationBuilder.DropTable(
                name: "Inter_Depository_Row_File");

            migrationBuilder.DropTable(
                name: "Isin_Status_Import_Row_File");

            migrationBuilder.DropTable(
                name: "Isin_Status_Master_Nsdl_Cdsl");

            migrationBuilder.DropTable(
                name: "Isin_Status_Master_Nsdl_Cdsl_01");

            migrationBuilder.DropTable(
                name: "Isr_2");

            migrationBuilder.DropTable(
                name: "Isr_3_securities");

            migrationBuilder.DropTable(
                name: "Item_Group_Master");

            migrationBuilder.DropTable(
                name: "Item_Master");

            migrationBuilder.DropTable(
                name: "Item_Service_Type_Master");

            migrationBuilder.DropTable(
                name: "Item_Trn");

            migrationBuilder.DropTable(
                name: "Letter_Alert_4_Phy");

            migrationBuilder.DropTable(
                name: "Letter_Alert_4_Phy_Trx");

            migrationBuilder.DropTable(
                name: "Log_Comp_Master");

            migrationBuilder.DropTable(
                name: "Maker_Checker_Ac_Log_Master");

            migrationBuilder.DropTable(
                name: "Maker_Checker_Log_Master");

            migrationBuilder.DropTable(
                name: "Masters_Show_Allow_User");

            migrationBuilder.DropTable(
                name: "Mker_Cker_Trans_Status_Msg_Master");

            migrationBuilder.DropTable(
                name: "Model_Req");

            migrationBuilder.DropTable(
                name: "Multi_Purpose_Type_Master");

            migrationBuilder.DropTable(
                name: "Name_Change_Master");

            migrationBuilder.DropTable(
                name: "Nominee_Change_Master");

            migrationBuilder.DropTable(
                name: "Nsdl_Category_Master");

            migrationBuilder.DropTable(
                name: "Nsdl_Master");

            migrationBuilder.DropTable(
                name: "Nsdl_Master_01");

            migrationBuilder.DropTable(
                name: "Nsdl_Master_02");

            migrationBuilder.DropTable(
                name: "Nsdl_Master_03");

            migrationBuilder.DropTable(
                name: "Partymaster");

            migrationBuilder.DropTable(
                name: "Partytrn");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Ac_Purc");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Ac_Req_Iss");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Ac_Req_Rec");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Ac_Sale");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Companies");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_In_Ward");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Out_Ward");

            migrationBuilder.DropTable(
                name: "Pdf_Store_Master_Req_Rec");

            migrationBuilder.DropTable(
                name: "Pendency_Event_Master");

            migrationBuilder.DropTable(
                name: "Pendency_Event_Master_Log");

            migrationBuilder.DropTable(
                name: "Pendency_Event_Master_Trn");

            migrationBuilder.DropTable(
                name: "Per_Day_Holding_All_Comp");

            migrationBuilder.DropTable(
                name: "Phy_Category_Master");

            migrationBuilder.DropTable(
                name: "Protal_Link_Maitain_Master");

            migrationBuilder.DropTable(
                name: "Purpose_Mst");

            migrationBuilder.DropTable(
                name: "Recent_Comp_Selection_Master");

            migrationBuilder.DropTable(
                name: "Reco_Cdsl_01");

            migrationBuilder.DropTable(
                name: "Reco_Cdsl_02");

            migrationBuilder.DropTable(
                name: "Reco_Import_01");

            migrationBuilder.DropTable(
                name: "Reco_Import_02");

            migrationBuilder.DropTable(
                name: "Reco_Import_Row_File");

            migrationBuilder.DropTable(
                name: "Reco_Nsdl_01");

            migrationBuilder.DropTable(
                name: "Reco_Nsdl_02");

            migrationBuilder.DropTable(
                name: "Reco_Nsdl_Row_File");

            migrationBuilder.DropTable(
                name: "Reco_Process_Report_Master");

            migrationBuilder.DropTable(
                name: "Reco_Row_File_Cdsl");

            migrationBuilder.DropTable(
                name: "Reject_Code_Msg_Master");

            migrationBuilder.DropTable(
                name: "Reject_Code_Msg_Master_Trx");

            migrationBuilder.DropTable(
                name: "Rejres");

            migrationBuilder.DropTable(
                name: "Req_Rec_Drn_Status");

            migrationBuilder.DropTable(
                name: "Req_Rec_Drn_Status_Cdsl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Drn_Status_Nsdl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Master");

            migrationBuilder.DropTable(
                name: "Req_Rec_Master_Comp");

            migrationBuilder.DropTable(
                name: "Req_Rec_Master_Comp_Docus");

            migrationBuilder.DropTable(
                name: "Req_Rec_Master_Comp_Schedule");

            migrationBuilder.DropTable(
                name: "Req_Rec_Master_Multi");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_01_Cdsl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_01_Nsdl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_02_Cdsl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_02_Nsdl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_03_Cdsl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_03_Nsdl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_01");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_02");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_Cdsl_Rtm8_Row_File");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_Row_File_Cdsl");

            migrationBuilder.DropTable(
                name: "Req_Rec_Online_Row_File_Nsdl");

            migrationBuilder.DropTable(
                name: "Req_Recv_Master_Online_Alert");

            migrationBuilder.DropTable(
                name: "Req_Rej_Flag_Master");

            migrationBuilder.DropTable(
                name: "Rta_Company_Detail");

            migrationBuilder.DropTable(
                name: "Sample_Detail");

            migrationBuilder.DropTable(
                name: "Sh_13_securities");

            migrationBuilder.DropTable(
                name: "Sh_14_securities");

            migrationBuilder.DropTable(
                name: "State_Master");

            migrationBuilder.DropTable(
                name: "System_Display_Helper_Master");

            migrationBuilder.DropTable(
                name: "System_Records");

            migrationBuilder.DropTable(
                name: "Task_Event_Master");

            migrationBuilder.DropTable(
                name: "Task_Event_Master_Log");

            migrationBuilder.DropTable(
                name: "Task_Event_Master_Trn");

            migrationBuilder.DropTable(
                name: "Unit_Type_Master");

            migrationBuilder.DropTable(
                name: "User_Detail");

            migrationBuilder.DropTable(
                name: "User_Log_Master");

            migrationBuilder.DropTable(
                name: "Verify_Log_Master");

            migrationBuilder.DropTable(
                name: "Vers_Master");

            migrationBuilder.DropTable(
                name: "Ward_Master_In");

            migrationBuilder.DropTable(
                name: "Ward_Master_Out");

            migrationBuilder.DropTable(
                name: "Ward_Master_Out1");

            migrationBuilder.DropTable(
                name: "Comp_Selection_Master");

            migrationBuilder.DropTable(
                name: "Complaint_Master");

            migrationBuilder.DropTable(
                name: "forms_master");

            migrationBuilder.DropTable(
                name: "ISR_1");

            migrationBuilder.DropTable(
                name: "Isr_3");

            migrationBuilder.DropTable(
                name: "Sh_13");

            migrationBuilder.DropTable(
                name: "Sh_14");

            migrationBuilder.DropTable(
                name: "user_profile_master");
        }
    }
}
