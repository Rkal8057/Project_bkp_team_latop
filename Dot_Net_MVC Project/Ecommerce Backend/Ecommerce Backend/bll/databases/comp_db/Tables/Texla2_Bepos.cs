using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_bepos")] 
       
   public class Texla2_Bepos
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("import_date", Order = 2, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("foliono", Order = 3, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("noshares", Order = 4, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("stcert", Order = 5, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 6, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("disto", Order = 7, TypeName = "float")]
       public long? disto { get; set; }

       [Column("btag", Order = 8, TypeName = "varchar(100)")]
       public string? btag { get; set; }

       [Column("last_refno", Order = 9, TypeName = "varchar(50)")]
       public string? last_refno { get; set; }

       [Column("last_ref_date", Order = 10, TypeName = "datetime")]
       public DateTime? last_ref_date { get; set; }

       [Column("transfer_from", Order = 11, TypeName = "varchar(50)")]
       public string? transfer_from { get; set; }

       [Column("entry_on_date", Order = 12, TypeName = "datetime")]
       public DateTime? entry_on_date { get; set; }

       [Column("modify_on_date", Order = 13, TypeName = "datetime")]
       public DateTime? modify_on_date { get; set; }

       [Column("record_insert_datetime", Order = 14, TypeName = "datetime")]
       public DateTime? record_insert_datetime { get; set; }

   }
}
