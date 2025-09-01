using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class login_db_v_110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NSDLMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Import_Id = table.Column<double>(type: "double(18,3)", nullable: true),
                    Import_Id_txt = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Import_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    entry_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Holder_Ac_Status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modify_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_Sno = table.Column<double>(type: "double(18,3)", nullable: true),
                    Comp_ISIN = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_Name = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comp_Name_short = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cate_id = table.Column<double>(type: "double(18,3)", nullable: true),
                    CDSL_Unique_Code = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category_Header = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category_Header_Detail = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category_Header_Discreption = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NON_PROMOTER = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    P_PI_PN = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    P_PI_PN_Details = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Holder_Share_Status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Account_Type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Share_Lock_YN = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Share_PLG_YN = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Record_Type_C_1 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Line_Number_C_2 = table.Column<double>(type: "double(18,3)", nullable: true),
                    DP_ID_C_3 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Id_C_4 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Type_C_5 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_subtype_C_6 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Account_Category_C_7 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Occupation_C_8 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    First_Holder_Name_Or_BP_Name_C_9 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    First_Holder_Father_Or_Husband_name_C_10 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_Part1_Or_BP_Addr1_C_11 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_Part2_Or_BP_Addr2_C_12 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_Part3_Or_BP_Addr3_C_13 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_Part4_Or_BP_Addr4_C_14 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_PincodeBP_PinCode_C_15 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_PhoneNumber_or_BP_PhoneNo_C_16 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_FaxNumber_Or_BP_FaxNo_C_17 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Second_Holder_Name_C_18 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Second_Holder_Father_Or_Husband_Name_C_19 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Third_Holder_Name_C_20 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Third_Holder_Father_Or_Husband_name_C_21 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filler1_C_22 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filler2_C_23 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    First_Holder_IncomeTax_PAN_C_24 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Second_Holder_IncomeTax_PAN_C_25 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Third_Holder_IncomeTax_PAN_C_26 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Indicator_C_27 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Name_C_28 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Address_Part1_C_29 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Address_Part2_C_30 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Address_Part3_C_31 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Address_Part4_C_32 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nominee_Guardian_Address_Pincode_C_33 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateofBirth_IncaseOf_Minor_C_34 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Minor_Indicator_C_35 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Bank_Account_Number_C_36 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Name_and_Branch_C_37 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Address_Part1_C_38 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Address_Part2_C_39 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Address_Part3_C_40 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Address_Part4_C_41 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Address_Pincode_C_42 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RBI_Reference_Number_C_43 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RBI_Approval_Date_C_44 = table.Column<string>(type: "varchar(25)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SEBI_Registration_Number_C_45 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Tax_Deduction_Status_C_46 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Status_C_47 = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_FreePositions_C_48 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_LockIn_Positions_C_49 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Block_Positions_C_50 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Pledged_Positions_C_51 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Pledgedwith_Lockin_Positions_C_52 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_PledgedUnconfirmed_Positions_C_53 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_UnconfirmedPledgedwith_Lockin_Positions_C_54 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Remat_Positions_C_55 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Remat_LockIn_Positions_C_56 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_CMIDD_Positions_C_57 = table.Column<double>(type: "double(18,3)", nullable: true),
                    CMPoolPositions_C_58 = table.Column<double>(type: "double(18,3)", nullable: true),
                    CCSettlement_Positions_C_59 = table.Column<double>(type: "double(18,3)", nullable: true),
                    MICRCode_C_60 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IFSC_C_61 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bank_Account_Type_C_62 = table.Column<string>(type: "varchar(16)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filler3_C_63 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    First_Holder_MapinID_C_64 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Second_Holder_MapinID_C_65 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Third_Holder_MapinID_C_66 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    First_Holder_EmailID_C_67 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Second_Holder_EmailID_C_68 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Third_Holder_EmailID_C_69 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RGESSFlag_C_70 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_FreePositions_Hold_dueto_NDU_C_71 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Lockin_PositionsHold_dueto_NDU_C_72 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Unconfirmed_FreePositions_Hold_dueto_NDU_C_73 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Unconfirmed_Lockin_PositionsHold_dueto_NDU_C_74 = table.Column<double>(type: "double(18,3)", nullable: true),
                    BO_Address_Statecode_C_75 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BO_Address_Countrycode_C_76 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LEINo_C_77 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PANFlag_for_First_Holder_C_78 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PANFlag_for_Second_Holder_C_79 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PANFlag_for_Third_Holder_C_80 = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filler4_C_81 = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IS_Deleted = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSDLMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NSDLMaster");
        }
    }
}
