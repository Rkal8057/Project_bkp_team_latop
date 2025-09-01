using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Benpos_Process_Master_1718
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("ben_pro_id", Order = 2, TypeName = "bigint(10)")]
       public long? ben_pro_id { get; set; }

       [Column("bene_pro_date", Order = 3, TypeName = "datetime")]
       public DateTime? bene_pro_date { get; set; }

       [Column("import_id", Order = 4, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_id_txt", Order = 5, TypeName = "text")]
       public string? import_id_txt { get; set; }

       [Column("import_date", Order = 6, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("entry_date", Order = 7, TypeName = "datetime")]
       public DateTime? entry_date { get; set; }

       [Column("database_name_found_yn", Order = 8, TypeName = "varchar(50)")]
       public string? database_name_found_yn { get; set; }

       [Column("database_found_yn", Order = 9, TypeName = "varchar(50)")]
       public string? database_found_yn { get; set; }

       [Column("comp_isin_found_yn_in_db", Order = 10, TypeName = "varchar(50)")]
       public string? comp_isin_found_yn_in_db { get; set; }

       [Column("comp_sno", Order = 11, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 12, TypeName = "text")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 13, TypeName = "text")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 14, TypeName = "text")]
       public string? comp_name_short { get; set; }

       [Column("username", Order = 15, TypeName = "text")]
       public string? username { get; set; }

       [Column("bespos_exchange_name", Order = 16, TypeName = "text")]
       public string? bespos_exchange_name { get; set; }

       [Column("bespos_path", Order = 17, TypeName = "text")]
       public string? bespos_path { get; set; }

       [Column("benpos_date", Order = 18, TypeName = "datetime")]
       public DateTime? benpos_date { get; set; }

       [Column("benpos_found_yn", Order = 19, TypeName = "varchar(50)")]
       public string? benpos_found_yn { get; set; }

       [Column("pro_nsdl_yn", Order = 20, TypeName = "varchar(50)")]
       public string? pro_nsdl_yn { get; set; }

       [Column("nsdl_01_found_yn", Order = 21, TypeName = "varchar(50)")]
       public string? nsdl_01_found_yn { get; set; }

       [Column("nsdl_02_found_yn", Order = 22, TypeName = "varchar(50)")]
       public string? nsdl_02_found_yn { get; set; }

       [Column("nsdl_03_found_yn", Order = 23, TypeName = "varchar(50)")]
       public string? nsdl_03_found_yn { get; set; }

       [Column("nsdl_has_error_yn", Order = 24, TypeName = "varchar(50)")]
       public string? nsdl_has_error_yn { get; set; }

       [Column("nsdl_error_detail", Order = 25, TypeName = "text")]
       public string? nsdl_error_detail { get; set; }

       [Column("nsdl_position", Order = 26, TypeName = "float")]
       public long? nsdl_position { get; set; }

       [Column("nsdl_total_no_records", Order = 27, TypeName = "float")]
       public long? nsdl_total_no_records { get; set; }

       [Column("nsdl_holding_master_update_yn", Order = 28, TypeName = "varchar(100)")]
       public string? nsdl_holding_master_update_yn { get; set; }

       [Column("pro_cdsl_yn", Order = 29, TypeName = "text")]
       public string? pro_cdsl_yn { get; set; }

       [Column("cdsl_01_found_yn", Order = 30, TypeName = "varchar(50)")]
       public string? cdsl_01_found_yn { get; set; }

       [Column("cdsl_02_found_yn", Order = 31, TypeName = "varchar(50)")]
       public string? cdsl_02_found_yn { get; set; }

       [Column("cdsl_has_error_yn", Order = 32, TypeName = "varchar(50)")]
       public string? cdsl_has_error_yn { get; set; }

       [Column("cdsl_error_detail", Order = 33, TypeName = "text")]
       public string? cdsl_error_detail { get; set; }

       [Column("cdsl_position", Order = 34, TypeName = "float")]
       public long? cdsl_position { get; set; }

       [Column("cdsl_total_no_records", Order = 35, TypeName = "float")]
       public long? cdsl_total_no_records { get; set; }

       [Column("cdsl_holding_master_update_yn", Order = 36, TypeName = "varchar(50)")]
       public string? cdsl_holding_master_update_yn { get; set; }

       [Column("pro_phy_yn", Order = 37, TypeName = "varchar(50)")]
       public string? pro_phy_yn { get; set; }

       [Column("phy_has_error_yn", Order = 38, TypeName = "varchar(50)")]
       public string? phy_has_error_yn { get; set; }

       [Column("phy_error_detail", Order = 39, TypeName = "text")]
       public string? phy_error_detail { get; set; }

       [Column("phy_position", Order = 40, TypeName = "float")]
       public long? phy_position { get; set; }

       [Column("phy_total_no_records", Order = 41, TypeName = "float")]
       public long? phy_total_no_records { get; set; }

       [Column("phy_holding_master_update_yn", Order = 42, TypeName = "float")]
       public long? phy_holding_master_update_yn { get; set; }

       [Column("over_all_error_yn", Order = 43, TypeName = "varchar(50)")]
       public string? over_all_error_yn { get; set; }

       [Column("over_all_error_detail", Order = 44, TypeName = "text")]
       public string? over_all_error_detail { get; set; }

       [Column("bespos_file_name", Order = 45, TypeName = "text")]
       public string? bespos_file_name { get; set; }

   }
}
