using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("req_rec_certi_details")] 
       
   public class Req_Rec_Certi_Details
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("req_rec_certi_details_id", Order = 2, TypeName = "bigint(10)")]
       public long? req_rec_certi_details_id { get; set; }

       [Column("req_entry_date", Order = 3, TypeName = "datetime")]
       public DateTime? req_entry_date { get; set; }

       [Column("unique_trn_id", Order = 4, TypeName = "varchar(50)")]
       public string? unique_trn_id { get; set; }

       [Column("req_id", Order = 5, TypeName = "float")]
       public long? req_id { get; set; }

       [Column("certi_no", Order = 6, TypeName = "varchar(50)")]
       public string? certi_no { get; set; }

       [Column("st_dist_no", Order = 7, TypeName = "float")]
       public long? st_dist_no { get; set; }

       [Column("upto_dist", Order = 8, TypeName = "float")]
       public long? upto_dist { get; set; }

       [Column("share_qty", Order = 9, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("selected_certi", Order = 10, TypeName = "varchar(1)")]
       public string? selected_certi { get; set; }

       [Column("req_folio_no", Order = 11, TypeName = "varchar(16)")]
       public string? req_folio_no { get; set; }

       [Column("req_cl_id", Order = 12, TypeName = "varchar(8)")]
       public string? req_cl_id { get; set; }

       [Column("req_dp_id", Order = 13, TypeName = "varchar(8)")]
       public string? req_dp_id { get; set; }

       [Column("certi_status", Order = 14, TypeName = "varchar(100)")]
       public string? certi_status { get; set; }

       [Column("folio_no_drn", Order = 15, TypeName = "varchar(16)")]
       public string? folio_no_drn { get; set; }

       [Column("cl_id_drn", Order = 16, TypeName = "varchar(8)")]
       public string? cl_id_drn { get; set; }

       [Column("dp_id_drn", Order = 17, TypeName = "varchar(8)")]
       public string? dp_id_drn { get; set; }

       [Column("certi_no_drn", Order = 18, TypeName = "varchar(50)")]
       public string? certi_no_drn { get; set; }

       [Column("st_dist_no_drn", Order = 19, TypeName = "float")]
       public long? st_dist_no_drn { get; set; }

       [Column("upto_dist_drn", Order = 20, TypeName = "float")]
       public long? upto_dist_drn { get; set; }

       [Column("share_qty_drn", Order = 21, TypeName = "float")]
       public long? share_qty_drn { get; set; }

       [Column("folio_as_per_dp", Order = 22, TypeName = "varchar(16)")]
       public string? folio_as_per_dp { get; set; }

       [Column("cl_id_as_per_dp", Order = 23, TypeName = "varchar(8)")]
       public string? cl_id_as_per_dp { get; set; }

       [Column("dp_id_as_per_dp", Order = 24, TypeName = "varchar(8)")]
       public string? dp_id_as_per_dp { get; set; }

       [Column("certi_as_per_dp", Order = 25, TypeName = "varchar(50)")]
       public string? certi_as_per_dp { get; set; }

       [Column("st_dist_as_per_dp", Order = 26, TypeName = "float")]
       public long? st_dist_as_per_dp { get; set; }

       [Column("upto_dist_as_per_dp", Order = 27, TypeName = "float")]
       public long? upto_dist_as_per_dp { get; set; }

       [Column("share_qty_as_per_dp", Order = 28, TypeName = "float")]
       public long? share_qty_as_per_dp { get; set; }

       [Column("certi_match", Order = 29, TypeName = "varchar(30)")]
       public string? certi_match { get; set; }

       [Column("dist_match", Order = 30, TypeName = "varchar(30)")]
       public string? dist_match { get; set; }

       [Column("folio_match", Order = 31, TypeName = "varchar(30)")]
       public string? folio_match { get; set; }

       [Column("no_of_certi_as_per_dp", Order = 32, TypeName = "float")]
       public long? no_of_certi_as_per_dp { get; set; }

   }
}
