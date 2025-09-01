using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_to_ca_master_dnr_03")] 
       
   public class Tr_To_Ca_Master_Dnr_03
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("vou_type", Order = 4, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("sno_grid", Order = 5, TypeName = "float")]
       public long? sno_grid { get; set; }

       [Column("isin_no", Order = 6, TypeName = "varchar(100)")]
       public string? isin_no { get; set; }

       [Column("dr_cr_isin", Order = 7, TypeName = "varchar(100)")]
       public string? dr_cr_isin { get; set; }

       [Column("dr_cr_indicator", Order = 8, TypeName = "varchar(100)")]
       public string? dr_cr_indicator { get; set; }

       [Column("dist_from", Order = 9, TypeName = "varchar(50)")]
       public string? dist_from { get; set; }

       [Column("dist_upto", Order = 10, TypeName = "varchar(50)")]
       public string? dist_upto { get; set; }

       [Column("dn_share_qty", Order = 11, TypeName = "varchar(50)")]
       public string? dn_share_qty { get; set; }

       [Column("status_dr_cr_flag_dnr", Order = 12, TypeName = "varchar(50)")]
       public string? status_dr_cr_flag_dnr { get; set; }

       [Column("ca_type", Order = 13, TypeName = "varchar(50)")]
       public string? ca_type { get; set; }

   }
}
