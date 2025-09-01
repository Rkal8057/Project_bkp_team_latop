using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class All_Comp_Holding_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("import_date", Order = 2, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("enter_date", Order = 3, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("file_exchange_name", Order = 4, TypeName = "text")]
       public string? file_exchange_name { get; set; }

       [Column("batch_no_dt", Order = 5, TypeName = "text")]
       public string? batch_no_dt { get; set; }

       [Column("isin_no", Order = 6, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 7, TypeName = "text")]
       public string? isin_comp_name { get; set; }

       [Column("holding_qty", Order = 8, TypeName = "float")]
       public long? holding_qty { get; set; }

       [Column("cdsl_noshares_qty", Order = 9, TypeName = "float")]
       public long? cdsl_noshares_qty { get; set; }

       [Column("cdsl_shlock_qty", Order = 10, TypeName = "float")]
       public long? cdsl_shlock_qty { get; set; }

       [Column("cdsl_plbal_qty", Order = 11, TypeName = "float")]
       public long? cdsl_plbal_qty { get; set; }

       [Column("nsdl_benlock", Order = 12, TypeName = "float")]
       public long? nsdl_benlock { get; set; }

       [Column("nsdl_nsdl_benblk", Order = 13, TypeName = "float")]
       public long? nsdl_nsdl_benblk { get; set; }

       [Column("nsdl_nsdl_benplg", Order = 14, TypeName = "float")]
       public long? nsdl_nsdl_benplg { get; set; }

       [Column("nsdl_nsdl_benplglk", Order = 15, TypeName = "float")]
       public long? nsdl_nsdl_benplglk { get; set; }

       [Column("nsdl_nsdl_benplgun", Order = 16, TypeName = "float")]
       public long? nsdl_nsdl_benplgun { get; set; }

       [Column("nsdl_nsdl_benplgcloc", Order = 17, TypeName = "float")]
       public long? nsdl_nsdl_benplgcloc { get; set; }

       [Column("nsdl_nsdl_benrem", Order = 18, TypeName = "float")]
       public long? nsdl_nsdl_benrem { get; set; }

       [Column("nsdl_nsdl_benremloc", Order = 19, TypeName = "float")]
       public long? nsdl_nsdl_benremloc { get; set; }

       [Column("nsdl_nsdl_bencmidpos", Order = 20, TypeName = "float")]
       public long? nsdl_nsdl_bencmidpos { get; set; }

       [Column("nsdl_nsdl_cmpool", Order = 21, TypeName = "float")]
       public long? nsdl_nsdl_cmpool { get; set; }

       [Column("nsdl_nsdl_ccsett", Order = 22, TypeName = "float")]
       public long? nsdl_nsdl_ccsett { get; set; }

       [Column("user_name", Order = 23, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 24, TypeName = "text")]
       public string? computer_id { get; set; }

       [Column("trx_id", Order = 25, TypeName = "bigint(10)")]
       public long? trx_id { get; set; }

   }
}
