using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class NSDLMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [Column("Import_Id", Order = 2, TypeName = "double(18,3)")]
        public double? Import_Id { get; set; }

        [Column("Import_Id_txt", Order = 3, TypeName = "varchar(255)")]
        public string Import_Id_txt { get; set; }

        [Column("Import_Date", Order = 4, TypeName = "datetime")]
        public DateTime? Import_Date { get; set; }

        [Column("entry_Date", Order = 5, TypeName = "datetime")]
        public DateTime? entry_Date { get; set; }

        [Column("Holder_Ac_Status", Order = 6, TypeName = "varchar(100)")]
        public string? Holder_Ac_Status { get; set; }

        [Column("Modify_on", Order = 7, TypeName = "datetime")]
        public DateTime? Modify_on { get; set; }

        [Column("comp_Sno", Order = 8, TypeName = "double(18,3)")]
        public double? comp_Sno { get; set; }

        [Column("Comp_ISIN", Order = 9, TypeName = "varchar(12)")]
        public string? Comp_ISIN { get; set; }

        [Column("comp_Name", Order = 10, TypeName = "varchar(255)")]
        public string? comp_Name { get; set; }

        [Column("comp_Name_short", Order = 11, TypeName = "varchar(50)")]
        public string? comp_Name_short { get; set; }

        [Column("username", Order = 12, TypeName = "varchar(100)")]
        public string? username { get; set; }

        [Column("Cate_id", Order = 13, TypeName = "double(18,3)")]
        public double? Cate_id { get; set; }

        [Column("CDSL_Unique_Code", Order = 14, TypeName = "varchar(50)")]
        public string? CDSL_Unique_Code { get; set; }

        [Column("Category_Header", Order = 15, TypeName = "varchar(255)")]
        public string? Category_Header { get; set; }

        [Column("Category_Header_Detail", Order = 16, TypeName = "varchar(255)")]
        public string? Category_Header_Detail { get; set; }

        [Column("Category_Header_Discreption", Order = 17, TypeName = "varchar(255)")]
        public string? Category_Header_Discreption { get; set; }

        [Column("NON_PROMOTER", Order = 18, TypeName = "varchar(25)")]
        public string? NON_PROMOTER { get; set; }

        [Column("P_PI_PN", Order = 19, TypeName = "varchar(3)")]
        public string? P_PI_PN { get; set; }

        [Column("P_PI_PN_Details", Order = 20, TypeName = "varchar(255)")]
        public string? P_PI_PN_Details { get; set; }

        [Column("Holder_Share_Status", Order = 21, TypeName = "varchar(100)")]
        public string? Holder_Share_Status { get; set; }

        [Column("Account_Type", Order = 22, TypeName = "varchar(100)")]
        public string? Account_Type { get; set; }

        [Column("Share_Lock_YN", Order = 23, TypeName = "varchar(100)")]
        public string? Share_Lock_YN { get; set; }

        [Column("Share_PLG_YN", Order = 24, TypeName = "varchar(100)")]
        public string? Share_PLG_YN { get; set; }

        [Column("Record_Type_C_1", Order = 25, TypeName = "varchar(2)")]
        public string? Record_Type_C_1 { get; set; }

        [Column("Line_Number_C_2", Order = 26, TypeName = "double(18,3)")]
        public double? Line_Number_C_2 { get; set; }

        [Column("DP_ID_C_3", Order = 27, TypeName = "varchar(16)")]
        public string? DP_ID_C_3 { get; set; }

        [Column("BO_Id_C_4", Order = 28, TypeName = "varchar(16)")]
        public string? BO_Id_C_4 { get; set; }

        [Column("BO_Type_C_5", Order = 29, TypeName = "varchar(2)")]
        public string? BO_Type_C_5 { get; set; }

        [Column("BO_subtype_C_6", Order = 30, TypeName = "varchar(2)")]
        public string? BO_subtype_C_6 { get; set; }

        [Column("BO_Account_Category_C_7", Order = 31, TypeName = "varchar(2)")]
        public string? BO_Account_Category_C_7 { get; set; }

        [Column("BO_Occupation_C_8", Order = 32, TypeName = "varchar(2)")]
        public string? BO_Occupation_C_8 { get; set; }

        [Column("First_Holder_Name_Or_BP_Name_C_9", Order = 33, TypeName = "varchar(250)")]
        public string? First_Holder_Name_Or_BP_Name_C_9 { get; set; }

        [Column("First_Holder_Father_Or_Husband_name_C_10", Order = 34, TypeName = "varchar(250)")]
        public string? First_Holder_Father_Or_Husband_name_C_10 { get; set; }

        [Column("BO_Address_Part1_Or_BP_Addr1_C_11", Order = 35, TypeName = "varchar(250)")]
        public string? BO_Address_Part1_Or_BP_Addr1_C_11 { get; set; }

        [Column("BO_Address_Part2_Or_BP_Addr2_C_12", Order = 36, TypeName = "varchar(250)")]
        public string? BO_Address_Part2_Or_BP_Addr2_C_12 { get; set; }

        [Column("BO_Address_Part3_Or_BP_Addr3_C_13", Order = 37, TypeName = "varchar(250)")]
        public string? BO_Address_Part3_Or_BP_Addr3_C_13 { get; set; }

        [Column("BO_Address_Part4_Or_BP_Addr4_C_14", Order = 38, TypeName = "varchar(250)")]
        public string? BO_Address_Part4_Or_BP_Addr4_C_14 { get; set; }

        [Column("BO_Address_PincodeBP_PinCode_C_15", Order = 39, TypeName = "varchar(250)")]
        public string? BO_Address_PincodeBP_PinCode_C_15 { get; set; }

        [Column("BO_PhoneNumber_or_BP_PhoneNo_C_16", Order = 40, TypeName = "varchar(250)")]
        public string? BO_PhoneNumber_or_BP_PhoneNo_C_16 { get; set; }

        [Column("BO_FaxNumber_Or_BP_FaxNo_C_17", Order = 41, TypeName = "varchar(250)")]
        public string? BO_FaxNumber_Or_BP_FaxNo_C_17 { get; set; }

        [Column("Second_Holder_Name_C_18", Order = 42, TypeName = "varchar(250)")]
        public string? Second_Holder_Name_C_18 { get; set; }

        [Column("Second_Holder_Father_Or_Husband_Name_C_19", Order = 43, TypeName = "varchar(250)")]
        public string? Second_Holder_Father_Or_Husband_Name_C_19 { get; set; }

        [Column("Third_Holder_Name_C_20", Order = 44, TypeName = "varchar(250)")]
        public string? Third_Holder_Name_C_20 { get; set; }

        [Column("Third_Holder_Father_Or_Husband_name_C_21", Order = 45, TypeName = "varchar(250)")]
        public string? Third_Holder_Father_Or_Husband_name_C_21 { get; set; }

        [Column("Filler1_C_22", Order = 46, TypeName = "varchar(50)")]
        public string? Filler1_C_22 { get; set; }

        [Column("Filler2_C_23", Order = 47, TypeName = "varchar(50)")]
        public string? Filler2_C_23 { get; set; }

        [Column("First_Holder_IncomeTax_PAN_C_24", Order = 48, TypeName = "varchar(50)")]
        public string? First_Holder_IncomeTax_PAN_C_24 { get; set; }

        [Column("Second_Holder_IncomeTax_PAN_C_25", Order = 49, TypeName = "varchar(50)")]
        public string? Second_Holder_IncomeTax_PAN_C_25 { get; set; }

        [Column("Third_Holder_IncomeTax_PAN_C_26", Order = 50, TypeName = "varchar(50)")]
        public string? Third_Holder_IncomeTax_PAN_C_26 { get; set; }

        [Column("Nominee_Guardian_Indicator_C_27", Order = 51, TypeName = "varchar(1)")]
        public string? Nominee_Guardian_Indicator_C_27 { get; set; }

        [Column("Nominee_Guardian_Name_C_28", Order = 52, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Name_C_28 { get; set; }

        [Column("Nominee_Guardian_Address_Part1_C_29", Order = 53, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Address_Part1_C_29 { get; set; }

        [Column("Nominee_Guardian_Address_Part2_C_30", Order = 54, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Address_Part2_C_30 { get; set; }

        [Column("Nominee_Guardian_Address_Part3_C_31", Order = 55, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Address_Part3_C_31 { get; set; }

        [Column("Nominee_Guardian_Address_Part4_C_32", Order = 56, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Address_Part4_C_32 { get; set; }

        [Column("Nominee_Guardian_Address_Pincode_C_33", Order = 57, TypeName = "varchar(250)")]
        public string? Nominee_Guardian_Address_Pincode_C_33 { get; set; }

        [Column("DateofBirth_IncaseOf_Minor_C_34", Order = 58, TypeName = "varchar(250)")]
        public string? DateofBirth_IncaseOf_Minor_C_34 { get; set; }

        [Column("Minor_Indicator_C_35", Order = 59, TypeName = "varchar(1)")]
        public string? Minor_Indicator_C_35 { get; set; }

        [Column("BO_Bank_Account_Number_C_36", Order = 60, TypeName = "varchar(250)")]
        public string? BO_Bank_Account_Number_C_36 { get; set; }

        [Column("Bank_Name_and_Branch_C_37", Order = 61, TypeName = "varchar(250)")]
        public string? Bank_Name_and_Branch_C_37 { get; set; }

        [Column("Bank_Address_Part1_C_38", Order = 62, TypeName = "varchar(250)")]
        public string? Bank_Address_Part1_C_38 { get; set; }

        [Column("Bank_Address_Part2_C_39", Order = 63, TypeName = "varchar(250)")]
        public string? Bank_Address_Part2_C_39 { get; set; }

        [Column("Bank_Address_Part3_C_40", Order = 64, TypeName = "varchar(250)")]
        public string? Bank_Address_Part3_C_40 { get; set; }

        [Column("Bank_Address_Part4_C_41", Order = 65, TypeName = "varchar(250)")]
        public string? Bank_Address_Part4_C_41 { get; set; }

        [Column("Bank_Address_Pincode_C_42", Order = 66, TypeName = "varchar(250)")]
        public string? Bank_Address_Pincode_C_42 { get; set; }

        [Column("RBI_Reference_Number_C_43", Order = 67, TypeName = "varchar(250)")]
        public string? RBI_Reference_Number_C_43 { get; set; }

        [Column("RBI_Approval_Date_C_44", Order = 68, TypeName = "varchar(25)")]
        public string? RBI_Approval_Date_C_44 { get; set; }

        [Column("SEBI_Registration_Number_C_45", Order = 69, TypeName = "varchar(250)")]
        public string? SEBI_Registration_Number_C_45 { get; set; }

        [Column("BO_Tax_Deduction_Status_C_46", Order = 70, TypeName = "varchar(250)")]
        public string? BO_Tax_Deduction_Status_C_46 { get; set; }

        [Column("BO_Status_C_47", Order = 71, TypeName = "varchar(2)")]
        public string? BO_Status_C_47 { get; set; }

        [Column("BO_FreePositions_C_48", Order = 72, TypeName = "double(18,3)")]
        public double? BO_FreePositions_C_48 { get; set; }

        [Column("BO_LockIn_Positions_C_49", Order = 73, TypeName = "double(18,3)")]
        public double? BO_LockIn_Positions_C_49 { get; set; }

        [Column("BO_Block_Positions_C_50", Order = 74, TypeName = "double(18,3)")]
        public double? BO_Block_Positions_C_50 { get; set; }

        [Column("BO_Pledged_Positions_C_51", Order = 75, TypeName = "double(18,3)")]
        public double? BO_Pledged_Positions_C_51 { get; set; }

        [Column("BO_Pledgedwith_Lockin_Positions_C_52", Order = 76, TypeName = "double(18,3)")]
        public double? BO_Pledgedwith_Lockin_Positions_C_52 { get; set; }

        [Column("BO_PledgedUnconfirmed_Positions_C_53", Order = 77, TypeName = "double(18,3)")]
        public double? BO_PledgedUnconfirmed_Positions_C_53 { get; set; }

        [Column("BO_UnconfirmedPledgedwith_Lockin_Positions_C_54", Order = 78, TypeName = "double(18,3)")]
        public double? BO_UnconfirmedPledgedwith_Lockin_Positions_C_54 { get; set; }

        [Column("BO_Remat_Positions_C_55", Order = 79, TypeName = "double(18,3)")]
        public double? BO_Remat_Positions_C_55 { get; set; }

        [Column("BO_Remat_LockIn_Positions_C_56", Order = 80, TypeName = "double(18,3)")]
        public double? BO_Remat_LockIn_Positions_C_56 { get; set; }

        [Column("BO_CMIDD_Positions_C_57", Order = 81, TypeName = "double(18,3)")]
        public double? BO_CMIDD_Positions_C_57 { get; set; }

        [Column("CMPoolPositions_C_58", Order = 82, TypeName = "double(18,3)")]
        public double? CMPoolPositions_C_58 { get; set; }

        [Column("CCSettlement_Positions_C_59", Order = 83, TypeName = "double(18,3)")]
        public double? CCSettlement_Positions_C_59 { get; set; }

        [Column("MICRCode_C_60", Order = 84, TypeName = "varchar(250)")]
        public string? MICRCode_C_60 { get; set; }

        [Column("IFSC_C_61", Order = 85, TypeName = "varchar(250)")]
        public string? IFSC_C_61 { get; set; }

        [Column("Bank_Account_Type_C_62", Order = 86, TypeName = "varchar(16)")]
        public string? Bank_Account_Type_C_62 { get; set; }

        [Column("Filler3_C_63", Order = 87, TypeName = "varchar(250)")]
        public string? Filler3_C_63 { get; set; }

        [Column("First_Holder_MapinID_C_64", Order = 88, TypeName = "varchar(250)")]
        public string? First_Holder_MapinID_C_64 { get; set; }

        [Column("Second_Holder_MapinID_C_65", Order = 89, TypeName = "varchar(250)")]
        public string? Second_Holder_MapinID_C_65 { get; set; }

        [Column("Third_Holder_MapinID_C_66", Order = 90, TypeName = "varchar(250)")]
        public string? Third_Holder_MapinID_C_66 { get; set; }

        [Column("First_Holder_EmailID_C_67", Order = 91, TypeName = "varchar(250)")]
        public string? First_Holder_EmailID_C_67 { get; set; }

        [Column("Second_Holder_EmailID_C_68", Order = 92, TypeName = "varchar(250)")]
        public string? Second_Holder_EmailID_C_68 { get; set; }

        [Column("Third_Holder_EmailID_C_69", Order = 93, TypeName = "varchar(250)")]
        public string? Third_Holder_EmailID_C_69 { get; set; }

        [Column("RGESSFlag_C_70", Order = 94, TypeName = "varchar(1)")]
        public string? RGESSFlag_C_70 { get; set; }

        [Column("BO_FreePositions_Hold_dueto_NDU_C_71", Order = 95, TypeName = "double(18,3)")]
        public double? BO_FreePositions_Hold_dueto_NDU_C_71 { get; set; }

        [Column("BO_Lockin_PositionsHold_dueto_NDU_C_72", Order = 96, TypeName = "double(18,3)")]
        public double? BO_Lockin_PositionsHold_dueto_NDU_C_72 { get; set; }

        [Column("BO_Unconfirmed_FreePositions_Hold_dueto_NDU_C_73", Order = 97, TypeName = "double(18,3)")]
        public double? BO_Unconfirmed_FreePositions_Hold_dueto_NDU_C_73 { get; set; }

        [Column("BO_Unconfirmed_Lockin_PositionsHold_dueto_NDU_C_74", Order = 98, TypeName = "double(18,3)")]
        public double? BO_Unconfirmed_Lockin_PositionsHold_dueto_NDU_C_74 { get; set; }

        [Column("BO_Address_Statecode_C_75", Order = 99, TypeName = "varchar(250)")]
        public string? BO_Address_Statecode_C_75 { get; set; }

        [Column("BO_Address_Countrycode_C_76", Order = 100, TypeName = "varchar(250)")]
        public string? BO_Address_Countrycode_C_76 { get; set; }

        [Column("LEINo_C_77", Order = 101, TypeName = "varchar(250)")]
        public string? LEINo_C_77 { get; set; }

        [Column("PANFlag_for_First_Holder_C_78", Order = 102, TypeName = "varchar(1)")]
        public string? PANFlag_for_First_Holder_C_78 { get; set; }

        [Column("PANFlag_for_Second_Holder_C_79", Order = 103, TypeName = "varchar(1)")]
        public string? PANFlag_for_Second_Holder_C_79 { get; set; }

        [Column("PANFlag_for_Third_Holder_C_80", Order = 104, TypeName = "varchar(1)")]
        public string? PANFlag_for_Third_Holder_C_80 { get; set; }

        [Column("Filler4_C_81", Order = 105, TypeName = "varchar(50)")]
        public string? Filler4_C_81 { get; set; }

        [Column("IS_Deleted", Order = 106, TypeName = "tinyint(1)")]
        public bool? IS_Deleted { get; set; }

    
    }
}
