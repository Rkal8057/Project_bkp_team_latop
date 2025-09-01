using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("panno_update_with_demat")] 
       
   public class Panno_Update_With_Demat
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("old_id", Order = 2, TypeName = "double(18,3)")]
       public long? old_old_id { get; set; }

       [Column("created_on", Order = 3, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 4, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("selected_table", Order = 5, TypeName = "varchar(100)")]
       public string? selected_table { get; set; }

       [Column("trfno", Order = 6, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 7, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("form_name", Order = 8, TypeName = "varchar(100)")]
       public string? form_name { get; set; }

       [Column("unique_trn_id", Order = 9, TypeName = "varchar(100)")]
       public string? unique_trn_id { get; set; }

       [Column("user_id", Order = 10, TypeName = "float")]
       public long? user_id { get; set; }

       [Column("user_name", Order = 11, TypeName = "varchar(100)")]
       public string? user_name { get; set; }

       [Column("tpanno", Order = 12, TypeName = "varchar(20)")]
       public string? tpanno { get; set; }

       [Column("tpanno2", Order = 13, TypeName = "varchar(20)")]
       public string? tpanno2 { get; set; }

       [Column("tpanno3", Order = 14, TypeName = "varchar(20)")]
       public string? tpanno3 { get; set; }

       [Column("trfolio", Order = 15, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("t_names2", Order = 16, TypeName = "varchar(100)")]
       public string? t_names2 { get; set; }

       [Column("t_names3", Order = 17, TypeName = "varchar(100)")]
       public string? t_names3 { get; set; }

   }
}
