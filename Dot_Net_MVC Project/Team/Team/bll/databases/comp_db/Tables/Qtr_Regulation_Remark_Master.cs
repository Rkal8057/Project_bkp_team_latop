using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("qtr_regulation_remark_master")] 
       
   public class Qtr_Regulation_Remark_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("main_index_no", Order = 2, TypeName = "bigint(10)")]
       public long? main_index_no { get; set; }

       [Column("sub_index_no", Order = 3, TypeName = "bigint(10)")]
       public long? sub_index_no { get; set; }

       [Column("sno_index_no", Order = 4, TypeName = "bigint(10)")]
       public long? sno_index_no { get; set; }

       [Column("sno_index_no_2", Order = 5, TypeName = "bigint(10)")]
       public long? sno_index_no_2 { get; set; }

       [Column("column_0_index", Order = 6, TypeName = "bigint(10)")]
       public long? column_0_index { get; set; }

       [Column("column_0_index_1", Order = 7, TypeName = "bigint(10)")]
       public long? column_0_index_1 { get; set; }

       [Column("column_0_index_2", Order = 8, TypeName = "bigint(10)")]
       public long? column_0_index_2 { get; set; }

       [Column("remark_column_1", Order = 9, TypeName = "varchar(50)")]
       public string? remark_column_1 { get; set; }

       [Column("remark_column_2", Order = 10, TypeName = "varchar(50)")]
       public string? remark_column_2 { get; set; }

       [Column("remark_column_3", Order = 11, TypeName = "varchar(50)")]
       public string? remark_column_3 { get; set; }

       [Column("remark_column_4", Order = 12, TypeName = "varchar(50)")]
       public string? remark_column_4 { get; set; }

       [Column("remark_column_5", Order = 13, TypeName = "varchar(50)")]
       public string? remark_column_5 { get; set; }

       [Column("remark_column_6", Order = 14, TypeName = "varchar(50)")]
       public string? remark_column_6 { get; set; }

       [Column("remark_column_7", Order = 15, TypeName = "varchar(50)")]
       public string? remark_column_7 { get; set; }

       [Column("remark_column_8", Order = 16, TypeName = "varchar(50)")]
       public string? remark_column_8 { get; set; }

       [Column("remark_column_9", Order = 17, TypeName = "varchar(50)")]
       public string? remark_column_9 { get; set; }

       [Column("remark_column_10", Order = 18, TypeName = "varchar(50)")]
       public string? remark_column_10 { get; set; }

       [Column("remark_column_11", Order = 19, TypeName = "varchar(50)")]
       public string? remark_column_11 { get; set; }

       [Column("remark_column_12", Order = 20, TypeName = "varchar(50)")]
       public string? remark_column_12 { get; set; }

       [Column("remark_column_13", Order = 21, TypeName = "varchar(50)")]
       public string? remark_column_13 { get; set; }

       [Column("remark_column_14", Order = 22, TypeName = "varchar(50)")]
       public string? remark_column_14 { get; set; }

       [Column("remark_column_15", Order = 23, TypeName = "varchar(50)")]
       public string? remark_column_15 { get; set; }

       [Column("remark_column_16", Order = 24, TypeName = "varchar(50)")]
       public string? remark_column_16 { get; set; }

       [Column("remark_column_17", Order = 25, TypeName = "varchar(50)")]
       public string? remark_column_17 { get; set; }

       [Column("remark_column_18", Order = 26, TypeName = "varchar(50)")]
       public string? remark_column_18 { get; set; }

       [Column("remark_column_19", Order = 27, TypeName = "varchar(50)")]
       public string? remark_column_19 { get; set; }

       [Column("remark_column_20", Order = 28, TypeName = "varchar(50)")]
       public string? remark_column_20 { get; set; }

       [Column("remark_column_21", Order = 29, TypeName = "varchar(50)")]
       public string? remark_column_21 { get; set; }

       [Column("remark_column_22", Order = 30, TypeName = "varchar(50)")]
       public string? remark_column_22 { get; set; }

       [Column("remark_column_23", Order = 31, TypeName = "varchar(50)")]
       public string? remark_column_23 { get; set; }

       [Column("remark_column_24", Order = 32, TypeName = "varchar(50)")]
       public string? remark_column_24 { get; set; }

       [Column("remark_column_25", Order = 33, TypeName = "varchar(50)")]
       public string? remark_column_25 { get; set; }

       [Column("remark_column_26", Order = 34, TypeName = "varchar(50)")]
       public string? remark_column_26 { get; set; }

       [Column("remark_column_27", Order = 35, TypeName = "varchar(50)")]
       public string? remark_column_27 { get; set; }

       [Column("remark_column_28", Order = 36, TypeName = "varchar(50)")]
       public string? remark_column_28 { get; set; }

       [Column("remark_column_29", Order = 37, TypeName = "varchar(50)")]
       public string? remark_column_29 { get; set; }

       [Column("page_sheet_flag", Order = 38, TypeName = "varchar(50)")]
       public string? page_sheet_flag { get; set; }

   }
}
