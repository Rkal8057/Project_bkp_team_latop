using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("qtr_regulation_pattern_master")] 
       
   public class Qtr_Regulation_Pattern_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("main_index_no", Order = 3, TypeName = "bigint(10)")]
       public long? main_index_no { get; set; }

       [Column("sub_index_no", Order = 4, TypeName = "bigint(10)")]
       public long? sub_index_no { get; set; }

       [Column("sno_index_no", Order = 5, TypeName = "bigint(10)")]
       public long? sno_index_no { get; set; }

       [Column("sno_index_no_2", Order = 6, TypeName = "bigint(10)")]
       public long? sno_index_no_2 { get; set; }

       [Column("column_0_index", Order = 7, TypeName = "bigint(10)")]
       public long? column_0_index { get; set; }

       [Column("column_0_index_1", Order = 8, TypeName = "bigint(10)")]
       public long? column_0_index_1 { get; set; }

       [Column("column_0_index_2", Order = 9, TypeName = "bigint(10)")]
       public long? column_0_index_2 { get; set; }

       [Column("column_1", Order = 10, TypeName = "varchar(50)")]
       public string? column_1 { get; set; }

       [Column("column_2", Order = 11, TypeName = "varchar(50)")]
       public string? column_2 { get; set; }

       [Column("column_3", Order = 12, TypeName = "varchar(50)")]
       public string? column_3 { get; set; }

       [Column("column_4", Order = 13, TypeName = "varchar(50)")]
       public string? column_4 { get; set; }

       [Column("column_5", Order = 14, TypeName = "varchar(50)")]
       public string? column_5 { get; set; }

       [Column("column_6", Order = 15, TypeName = "varchar(50)")]
       public string? column_6 { get; set; }

       [Column("column_7", Order = 16, TypeName = "varchar(50)")]
       public string? column_7 { get; set; }

       [Column("column_8", Order = 17, TypeName = "varchar(50)")]
       public string? column_8 { get; set; }

       [Column("column_9", Order = 18, TypeName = "varchar(50)")]
       public string? column_9 { get; set; }

       [Column("column_10", Order = 19, TypeName = "varchar(50)")]
       public string? column_10 { get; set; }

       [Column("column_11", Order = 20, TypeName = "varchar(50)")]
       public string? column_11 { get; set; }

       [Column("column_12", Order = 21, TypeName = "varchar(50)")]
       public string? column_12 { get; set; }

       [Column("column_13", Order = 22, TypeName = "varchar(50)")]
       public string? column_13 { get; set; }

       [Column("column_14", Order = 23, TypeName = "varchar(50)")]
       public string? column_14 { get; set; }

       [Column("column_15", Order = 24, TypeName = "varchar(50)")]
       public string? column_15 { get; set; }

       [Column("column_16", Order = 25, TypeName = "varchar(50)")]
       public string? column_16 { get; set; }

       [Column("column_17", Order = 26, TypeName = "varchar(50)")]
       public string? column_17 { get; set; }

       [Column("column_18", Order = 27, TypeName = "varchar(50)")]
       public string? column_18 { get; set; }

       [Column("column_19", Order = 28, TypeName = "varchar(50)")]
       public string? column_19 { get; set; }

       [Column("column_20", Order = 29, TypeName = "varchar(50)")]
       public string? column_20 { get; set; }

       [Column("column_21", Order = 30, TypeName = "varchar(50)")]
       public string? column_21 { get; set; }

       [Column("column_22", Order = 31, TypeName = "varchar(50)")]
       public string? column_22 { get; set; }

       [Column("column_23", Order = 32, TypeName = "varchar(50)")]
       public string? column_23 { get; set; }

       [Column("column_24", Order = 33, TypeName = "varchar(50)")]
       public string? column_24 { get; set; }

       [Column("column_25", Order = 34, TypeName = "varchar(50)")]
       public string? column_25 { get; set; }

       [Column("column_26", Order = 35, TypeName = "varchar(50)")]
       public string? column_26 { get; set; }

       [Column("column_27", Order = 36, TypeName = "varchar(50)")]
       public string? column_27 { get; set; }

       [Column("column_28", Order = 37, TypeName = "varchar(50)")]
       public string? column_28 { get; set; }

       [Column("column_29", Order = 38, TypeName = "varchar(50)")]
       public string? column_29 { get; set; }

       [Column("flag_type", Order = 39, TypeName = "varchar(50)")]
       public string? flag_type { get; set; }

       [Column("page_sheet_flag", Order = 40, TypeName = "varchar(50)")]
       public string? page_sheet_flag { get; set; }

       [Column("promo_and_prom_grop_final_total", Order = 41, TypeName = "float")]
       public long? promo_and_prom_grop_final_total { get; set; }

       [Column("public_shares_holding_final_total", Order = 42, TypeName = "float")]
       public long? public_shares_holding_final_total { get; set; }

       [Column("promo_and_prom_grop_final_per", Order = 43, TypeName = "float")]
       public long? promo_and_prom_grop_final_per { get; set; }

       [Column("public_shares_holding_final_per", Order = 44, TypeName = "float")]
       public long? public_shares_holding_final_per { get; set; }

       [Column("promoter_benlock_qty_per", Order = 45, TypeName = "float")]
       public long? promoter_benlock_qty_per { get; set; }

       [Column("promoter_benplg_qty_per", Order = 46, TypeName = "float")]
       public long? promoter_benplg_qty_per { get; set; }

       [Column("promoter_benlock_qty_final", Order = 47, TypeName = "float")]
       public long? promoter_benlock_qty_final { get; set; }

       [Column("promoter_benplg_qty_final", Order = 48, TypeName = "float")]
       public long? promoter_benplg_qty_final { get; set; }

   }
}
