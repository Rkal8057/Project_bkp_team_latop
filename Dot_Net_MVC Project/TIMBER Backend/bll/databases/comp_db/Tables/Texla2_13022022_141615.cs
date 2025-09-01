using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_13022022_141615")] 
       
   public class Texla2_13022022_141615
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("comp_sno", Order = 2, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 3, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 4, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 5, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("texla2_id", Order = 6, TypeName = "bigint(10)")]
       public long? texla2_id { get; set; }

       [Column("foliono", Order = 7, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("folio_id", Order = 8, TypeName = "varchar(16)")]
       public string? folio_id { get; set; }

       [Column("old_folio_no_id", Order = 9, TypeName = "varchar(16)")]
       public string? old_folio_no_id { get; set; }

       [Column("reason", Order = 10, TypeName = "varchar(50)")]
       public string? reason { get; set; }

       [Column("dem", Order = 11, TypeName = "varchar(50)")]
       public string? dem { get; set; }

       [Column("share_type", Order = 12, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("noshares", Order = 13, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("stcert_numric", Order = 14, TypeName = "float")]
       public long? stcert_numric { get; set; }

       [Column("stcert", Order = 15, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 16, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("disto", Order = 17, TypeName = "float")]
       public long? disto { get; set; }

       [Column("remarks", Order = 18, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("allotno", Order = 19, TypeName = "float")]
       public long? allotno { get; set; }

       [Column("old_stcert", Order = 20, TypeName = "varchar(50)")]
       public string? old_stcert { get; set; }

       [Column("misccode", Order = 21, TypeName = "float")]
       public long? misccode { get; set; }

       [Column("paidupdate", Order = 22, TypeName = "datetime")]
       public DateTime? paidupdate { get; set; }

       [Column("fpd", Order = 23, TypeName = "varchar(50)")]
       public string? fpd { get; set; }

       [Column("shlot", Order = 24, TypeName = "float")]
       public long? shlot { get; set; }

       [Column("uflag", Order = 25, TypeName = "varchar(100)")]
       public string? uflag { get; set; }

       [Column("sta", Order = 26, TypeName = "varchar(100)")]
       public string? sta { get; set; }

       [Column("dpid", Order = 27, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("clid", Order = 28, TypeName = "varchar(8)")]
       public string? clid { get; set; }

       [Column("btag", Order = 29, TypeName = "varchar(100)")]
       public string? btag { get; set; }

       [Column("trfdate", Order = 30, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("refno", Order = 31, TypeName = "float")]
       public long? refno { get; set; }

       [Column("trfolio", Order = 32, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("derno", Order = 33, TypeName = "varchar(100)")]
       public string? derno { get; set; }

       [Column("dpidno", Order = 34, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 35, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("dmdate", Order = 36, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("folio_status", Order = 37, TypeName = "varchar(50)")]
       public string? folio_status { get; set; }

       [Column("folio_in_or_out", Order = 38, TypeName = "varchar(50)")]
       public string? folio_in_or_out { get; set; }

       [Column("last_refno", Order = 39, TypeName = "varchar(50)")]
       public string? last_refno { get; set; }

       [Column("last_ref_date", Order = 40, TypeName = "varchar(50)")]
       public string? last_ref_date { get; set; }

       [Column("transfer_from", Order = 41, TypeName = "varchar(250)")]
       public string? transfer_from { get; set; }

       [Column("record_insert_datetime", Order = 42, TypeName = "datetime")]
       public DateTime? record_insert_datetime { get; set; }

       [Column("tot_share_qty", Order = 43, TypeName = "double(18,3)")]
       public long? tot_share_qty { get; set; }

   }
}
