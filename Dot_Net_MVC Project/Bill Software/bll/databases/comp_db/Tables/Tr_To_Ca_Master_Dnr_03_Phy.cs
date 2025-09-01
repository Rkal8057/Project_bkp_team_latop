using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_to_ca_master_dnr_03_phy")] 
       
   public class Tr_To_Ca_Master_Dnr_03_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("drn_sno", Order = 4, TypeName = "float")]
       public long? drn_sno { get; set; }

       [Column("foliono", Order = 5, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("reason", Order = 6, TypeName = "varchar(50)")]
       public string? reason { get; set; }

       [Column("noshares", Order = 7, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("stcert", Order = 8, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 9, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("disto", Order = 10, TypeName = "float")]
       public long? disto { get; set; }

       [Column("share_price", Order = 11, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("paid_value", Order = 12, TypeName = "float")]
       public long? paid_value { get; set; }

       [Column("share_type", Order = 13, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("allotno", Order = 14, TypeName = "float")]
       public long? allotno { get; set; }

       [Column("paidupdate", Order = 15, TypeName = "datetime")]
       public DateTime? paidupdate { get; set; }

       [Column("refno", Order = 16, TypeName = "float")]
       public long? refno { get; set; }

       [Column("remarks", Order = 17, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

   }
}
