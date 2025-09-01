using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("company_benpos_history_master")] 
       
   public class Company_Benpos_History_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_atuo_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_atuo_id { get; set; }

       [Column("trx_id", Order = 3, TypeName = "float")]
       public long? trx_id { get; set; }

       [Column("import_date", Order = 4, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("enter_date", Order = 5, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("file_exchange_name", Order = 6, TypeName = "varchar(50)")]
       public string? file_exchange_name { get; set; }

       [Column("batch_no_dt", Order = 7, TypeName = "varchar(50)")]
       public string? batch_no_dt { get; set; }

       [Column("isin_no", Order = 8, TypeName = "varchar(50)")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 9, TypeName = "varchar(50)")]
       public string? isin_comp_name { get; set; }

       [Column("holding_qty", Order = 10, TypeName = "float")]
       public long? holding_qty { get; set; }

       [Column("cdsl_noshares_qty", Order = 11, TypeName = "float")]
       public long? cdsl_noshares_qty { get; set; }

       [Column("cdsl_shlock_qty", Order = 12, TypeName = "float")]
       public long? cdsl_shlock_qty { get; set; }

       [Column("cdsl_plbal_qty", Order = 13, TypeName = "float")]
       public long? cdsl_plbal_qty { get; set; }

       [Column("nsdl_benlock", Order = 14, TypeName = "float")]
       public long? nsdl_benlock { get; set; }

       [Column("nsdl_nsdl_benblk", Order = 15, TypeName = "float")]
       public long? nsdl_nsdl_benblk { get; set; }

       [Column("nsdl_nsdl_benplg", Order = 16, TypeName = "float")]
       public long? nsdl_nsdl_benplg { get; set; }

       [Column("nsdl_nsdl_benplglk", Order = 17, TypeName = "float")]
       public long? nsdl_nsdl_benplglk { get; set; }

       [Column("nsdl_nsdl_benplgun", Order = 18, TypeName = "float")]
       public long? nsdl_nsdl_benplgun { get; set; }

       [Column("nsdl_nsdl_benplgcloc", Order = 19, TypeName = "float")]
       public long? nsdl_nsdl_benplgcloc { get; set; }

       [Column("nsdl_nsdl_benrem", Order = 20, TypeName = "float")]
       public long? nsdl_nsdl_benrem { get; set; }

       [Column("nsdl_nsdl_benremloc", Order = 21, TypeName = "float")]
       public long? nsdl_nsdl_benremloc { get; set; }

       [Column("nsdl_nsdl_bencmidpos", Order = 22, TypeName = "float")]
       public long? nsdl_nsdl_bencmidpos { get; set; }

       [Column("nsdl_nsdl_cmpool", Order = 23, TypeName = "float")]
       public long? nsdl_nsdl_cmpool { get; set; }

       [Column("nsdl_nsdl_ccsett", Order = 24, TypeName = "float")]
       public long? nsdl_nsdl_ccsett { get; set; }

       [Column("user_name", Order = 25, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 26, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
