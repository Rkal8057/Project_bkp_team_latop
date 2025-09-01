using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("cdsl_master_01")] 
       
   public class Cdsl_Master_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("benpos_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? benpos_auto_id { get; set; }

       [Column("import_id", Order = 3, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_id_txt", Order = 4, TypeName = "varchar(50)")]
       public string? import_id_txt { get; set; }

       [Column("import_date", Order = 5, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("entry_date", Order = 6, TypeName = "datetime")]
       public DateTime? entry_date { get; set; }

       [Column("comp_sno", Order = 7, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 8, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 9, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 10, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("username", Order = 11, TypeName = "varchar(50)")]
       public string? username { get; set; }

       [Column("tot_qty", Order = 12, TypeName = "float")]
       public long? tot_qty { get; set; }

       [Column("tot_transit_qtu", Order = 13, TypeName = "float")]
       public long? tot_transit_qtu { get; set; }

       [Column("tot_free_qty", Order = 14, TypeName = "float")]
       public long? tot_free_qty { get; set; }

       [Column("tot_lock_in_qty", Order = 15, TypeName = "float")]
       public long? tot_lock_in_qty { get; set; }

       [Column("tot_block_qty", Order = 16, TypeName = "float")]
       public long? tot_block_qty { get; set; }

       [Column("tot_pledged_qty", Order = 17, TypeName = "float")]
       public long? tot_pledged_qty { get; set; }

       [Column("tot_pledged_lock_in_qty", Order = 18, TypeName = "float")]
       public long? tot_pledged_lock_in_qty { get; set; }

       [Column("tot_unconfirmed_pldg_qty", Order = 19, TypeName = "float")]
       public long? tot_unconfirmed_pldg_qty { get; set; }

       [Column("tot_uncon_pldg_lock_in_qty", Order = 20, TypeName = "float")]
       public long? tot_uncon_pldg_lock_in_qty { get; set; }

       [Column("tot_olidt_qty", Order = 21, TypeName = "float")]
       public long? tot_olidt_qty { get; set; }

       [Column("tot_remat_qty", Order = 22, TypeName = "float")]
       public long? tot_remat_qty { get; set; }

       [Column("tot_remat_lock_in_qty", Order = 23, TypeName = "float")]
       public long? tot_remat_lock_in_qty { get; set; }

       [Column("col_not_difine1_qty", Order = 24, TypeName = "float")]
       public long? col_not_difine1_qty { get; set; }

       [Column("col_not_difine2_qty", Order = 25, TypeName = "float")]
       public long? col_not_difine2_qty { get; set; }

       [Column("col_not_difine3_qty", Order = 26, TypeName = "float")]
       public long? col_not_difine3_qty { get; set; }

       [Column("col_not_difine4_qty", Order = 27, TypeName = "float")]
       public long? col_not_difine4_qty { get; set; }

       [Column("filler_1", Order = 28, TypeName = "varchar(8)")]
       public string? filler_1 { get; set; }

       [Column("filler_2", Order = 29, TypeName = "varchar(8)")]
       public string? filler_2 { get; set; }

       [Column("tot_no_of_records", Order = 30, TypeName = "float")]
       public long? tot_no_of_records { get; set; }

   }
}
