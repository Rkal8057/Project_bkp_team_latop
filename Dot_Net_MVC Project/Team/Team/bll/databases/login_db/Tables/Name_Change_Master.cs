using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Name_Change_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("name_change_id", Order = 2, TypeName = "bigint(10)")]
       public long? name_change_id { get; set; }

       [Column("change_created_on", Order = 3, TypeName = "datetime")]
       public DateTime? change_created_on { get; set; }

       [Column("change_updated_on", Order = 4, TypeName = "datetime")]
       public DateTime? change_updated_on { get; set; }

       [Column("dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 6, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("change_flag", Order = 7, TypeName = "varchar(8)")]
       public string? change_flag { get; set; }

       [Column("fst_hld_nm", Order = 8, TypeName = "varchar(2255)")]
       public string? fst_hld_nm { get; set; }

       [Column("snd_hld_nm", Order = 9, TypeName = "text")]
       public string? snd_hld_nm { get; set; }

       [Column("thd_hld_nm", Order = 10, TypeName = "text")]
       public string? thd_hld_nm { get; set; }

       [Column("fst_hld_fh", Order = 11, TypeName = "text")]
       public string? fst_hld_fh { get; set; }

       [Column("snd_hld_fh", Order = 12, TypeName = "text")]
       public string? snd_hld_fh { get; set; }

       [Column("thd_hld_fh", Order = 13, TypeName = "text")]
       public string? thd_hld_fh { get; set; }

   }
}
