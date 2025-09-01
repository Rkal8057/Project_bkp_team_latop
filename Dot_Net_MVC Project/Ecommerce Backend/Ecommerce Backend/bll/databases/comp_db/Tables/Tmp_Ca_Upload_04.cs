using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tmp_ca_upload_04")] 
       
   public class Tmp_Ca_Upload_04
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("index_no", Order = 4, TypeName = "float")]
       public long? index_no { get; set; }

       [Column("record_type", Order = 5, TypeName = "float")]
       public long? record_type { get; set; }

       [Column("folio_no_ci_id", Order = 6, TypeName = "varchar(16)")]
       public string? folio_no_ci_id { get; set; }

       [Column("dp_id", Order = 7, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("drn_no", Order = 8, TypeName = "varchar(30)")]
       public string? drn_no { get; set; }

       [Column("column_no_1", Order = 9, TypeName = "varchar(50)")]
       public string? column_no_1 { get; set; }

       [Column("column_no_2", Order = 10, TypeName = "varchar(50)")]
       public string? column_no_2 { get; set; }

       [Column("column_no_3", Order = 11, TypeName = "varchar(50)")]
       public string? column_no_3 { get; set; }

       [Column("column_no_4", Order = 12, TypeName = "varchar(50)")]
       public string? column_no_4 { get; set; }

       [Column("column_no_5", Order = 13, TypeName = "varchar(50)")]
       public string? column_no_5 { get; set; }

       [Column("column_no_6", Order = 14, TypeName = "varchar(50)")]
       public string? column_no_6 { get; set; }

       [Column("column_no_7", Order = 15, TypeName = "varchar(50)")]
       public string? column_no_7 { get; set; }

       [Column("column_no_8", Order = 16, TypeName = "varchar(50)")]
       public string? column_no_8 { get; set; }

       [Column("column_no_9", Order = 17, TypeName = "varchar(50)")]
       public string? column_no_9 { get; set; }

       [Column("column_no_10", Order = 18, TypeName = "varchar(50)")]
       public string? column_no_10 { get; set; }

       [Column("column_no_11", Order = 19, TypeName = "varchar(50)")]
       public string? column_no_11 { get; set; }

       [Column("column_no_12", Order = 20, TypeName = "varchar(50)")]
       public string? column_no_12 { get; set; }

       [Column("column_no_13", Order = 21, TypeName = "varchar(50)")]
       public string? column_no_13 { get; set; }

       [Column("column_no_14", Order = 22, TypeName = "varchar(50)")]
       public string? column_no_14 { get; set; }

       [Column("column_no_15", Order = 23, TypeName = "varchar(50)")]
       public string? column_no_15 { get; set; }

       [Column("column_no_16", Order = 24, TypeName = "varchar(50)")]
       public string? column_no_16 { get; set; }

       [Column("column_no_17", Order = 25, TypeName = "varchar(50)")]
       public string? column_no_17 { get; set; }

       [Column("column_no_18", Order = 26, TypeName = "varchar(50)")]
       public string? column_no_18 { get; set; }

       [Column("column_no_19", Order = 27, TypeName = "varchar(50)")]
       public string? column_no_19 { get; set; }

       [Column("column_no_20", Order = 28, TypeName = "varchar(50)")]
       public string? column_no_20 { get; set; }

       [Column("column_no_21", Order = 29, TypeName = "varchar(50)")]
       public string? column_no_21 { get; set; }

       [Column("column_no_22", Order = 30, TypeName = "varchar(50)")]
       public string? column_no_22 { get; set; }

       [Column("column_no_23", Order = 31, TypeName = "varchar(50)")]
       public string? column_no_23 { get; set; }

       [Column("column_no_24", Order = 32, TypeName = "varchar(50)")]
       public string? column_no_24 { get; set; }

       [Column("column_no_25", Order = 33, TypeName = "varchar(50)")]
       public string? column_no_25 { get; set; }

       [Column("column_no_26", Order = 34, TypeName = "varchar(50)")]
       public string? column_no_26 { get; set; }

       [Column("column_no_27", Order = 35, TypeName = "varchar(50)")]
       public string? column_no_27 { get; set; }

       [Column("column_no_28", Order = 36, TypeName = "varchar(50)")]
       public string? column_no_28 { get; set; }

       [Column("column_no_29", Order = 37, TypeName = "varchar(50)")]
       public string? column_no_29 { get; set; }

       [Column("column_no_30", Order = 38, TypeName = "varchar(50)")]
       public string? column_no_30 { get; set; }

       [Column("column_no_31", Order = 39, TypeName = "varchar(50)")]
       public string? column_no_31 { get; set; }

       [Column("column_no_32", Order = 40, TypeName = "varchar(50)")]
       public string? column_no_32 { get; set; }

       [Column("column_no_33", Order = 41, TypeName = "varchar(50)")]
       public string? column_no_33 { get; set; }

       [Column("column_no_34", Order = 42, TypeName = "varchar(50)")]
       public string? column_no_34 { get; set; }

       [Column("column_no_35", Order = 43, TypeName = "varchar(50)")]
       public string? column_no_35 { get; set; }

       [Column("column_no_36", Order = 44, TypeName = "varchar(50)")]
       public string? column_no_36 { get; set; }

       [Column("column_no_37", Order = 45, TypeName = "varchar(50)")]
       public string? column_no_37 { get; set; }

       [Column("column_no_38", Order = 46, TypeName = "varchar(50)")]
       public string? column_no_38 { get; set; }

       [Column("column_no_39", Order = 47, TypeName = "varchar(50)")]
       public string? column_no_39 { get; set; }

       [Column("column_no_40", Order = 48, TypeName = "varchar(50)")]
       public string? column_no_40 { get; set; }

       [Column("column_no_41", Order = 49, TypeName = "varchar(50)")]
       public string? column_no_41 { get; set; }

       [Column("column_no_42", Order = 50, TypeName = "varchar(50)")]
       public string? column_no_42 { get; set; }

       [Column("column_no_43", Order = 51, TypeName = "varchar(50)")]
       public string? column_no_43 { get; set; }

       [Column("column_no_44", Order = 52, TypeName = "varchar(50)")]
       public string? column_no_44 { get; set; }

       [Column("column_no_45", Order = 53, TypeName = "varchar(50)")]
       public string? column_no_45 { get; set; }

       [Column("column_no_46", Order = 54, TypeName = "varchar(50)")]
       public string? column_no_46 { get; set; }

       [Column("column_no_47", Order = 55, TypeName = "varchar(50)")]
       public string? column_no_47 { get; set; }

       [Column("column_no_48", Order = 56, TypeName = "varchar(50)")]
       public string? column_no_48 { get; set; }

       [Column("column_no_49", Order = 57, TypeName = "varchar(50)")]
       public string? column_no_49 { get; set; }

       [Column("column_no_50", Order = 58, TypeName = "varchar(50)")]
       public string? column_no_50 { get; set; }

   }
}
