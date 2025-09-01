using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("old_texla2")] 
       
   public class Old_Texla2
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("folio_id", Order = 3, TypeName = "varchar(16)")]
       public string? folio_id { get; set; }

       [Column("old_folio_no_id", Order = 4, TypeName = "varchar(16)")]
       public string? old_folio_no_id { get; set; }

       [Column("reason", Order = 5, TypeName = "varchar(50)")]
       public string? reason { get; set; }

       [Column("dem", Order = 6, TypeName = "varchar(50)")]
       public string? dem { get; set; }

       [Column("stcert_numric", Order = 7, TypeName = "float")]
       public long? stcert_numric { get; set; }

       [Column("noshares", Order = 8, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("stcert", Order = 9, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 10, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("disto", Order = 11, TypeName = "float")]
       public long? disto { get; set; }

       [Column("remarks", Order = 12, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("old_stcert", Order = 13, TypeName = "varchar(50)")]
       public string? old_stcert { get; set; }

       [Column("fpd", Order = 14, TypeName = "varchar(250)")]
       public string? fpd { get; set; }

       [Column("shlot", Order = 15, TypeName = "varchar(250)")]
       public string? shlot { get; set; }

       [Column("uflag", Order = 16, TypeName = "varchar(250)")]
       public string? uflag { get; set; }

       [Column("sta", Order = 17, TypeName = "float")]
       public long? sta { get; set; }

       [Column("dpid", Order = 18, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("clid", Order = 19, TypeName = "varchar(8)")]
       public string? clid { get; set; }

       [Column("btag", Order = 20, TypeName = "varchar(100)")]
       public string? btag { get; set; }

       [Column("paidupdate", Order = 21, TypeName = "datetime")]
       public DateTime? paidupdate { get; set; }

       [Column("dmdate", Order = 22, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("trfdate", Order = 23, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("refno", Order = 24, TypeName = "varchar(50)")]
       public string? refno { get; set; }

       [Column("trfolio", Order = 25, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("derno", Order = 26, TypeName = "varchar(100)")]
       public string? derno { get; set; }

       [Column("dpidno", Order = 27, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 28, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("empcode", Order = 29, TypeName = "varchar(100)")]
       public string? empcode { get; set; }

       [Column("misccode", Order = 30, TypeName = "varchar(50)")]
       public string? misccode { get; set; }

       [Column("allotno", Order = 31, TypeName = "varchar(50)")]
       public string? allotno { get; set; }

       [Column("folio_status", Order = 32, TypeName = "varchar(50)")]
       public string? folio_status { get; set; }

       [Column("folio_in_or_out", Order = 33, TypeName = "varchar(50)")]
       public string? folio_in_or_out { get; set; }

       [Column("last_refno", Order = 34, TypeName = "varchar(50)")]
       public string? last_refno { get; set; }

       [Column("last_ref_date", Order = 35, TypeName = "varchar(50)")]
       public string? last_ref_date { get; set; }

       [Column("transfer_from", Order = 36, TypeName = "varchar(250)")]
       public string? transfer_from { get; set; }

       [Column("share_type", Order = 37, TypeName = "varchar(250)")]
       public string? share_type { get; set; }

       [Column("share_price", Order = 38, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("comp_isin", Order = 39, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 40, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("trf_type", Order = 41, TypeName = "varchar(100)")]
       public string? trf_type { get; set; }

       [Column("oth_no", Order = 42, TypeName = "varchar(100)")]
       public string? oth_no { get; set; }

       [Column("pay_code", Order = 43, TypeName = "varchar(100)")]
       public string? pay_code { get; set; }

       [Column("paid_value", Order = 44, TypeName = "float")]
       public long? paid_value { get; set; }

       [Column("lock_flag", Order = 45, TypeName = "varchar(100)")]
       public string? lock_flag { get; set; }

       [Column("lock_upto", Order = 46, TypeName = "varchar(100)")]
       public string? lock_upto { get; set; }

       [Column("stop_flag", Order = 47, TypeName = "varchar(100)")]
       public string? stop_flag { get; set; }

       [Column("stop_code", Order = 48, TypeName = "varchar(100)")]
       public string? stop_code { get; set; }

       [Column("stop_docno", Order = 49, TypeName = "varchar(100)")]
       public string? stop_docno { get; set; }

       [Column("dupl_flag", Order = 50, TypeName = "varchar(100)")]
       public string? dupl_flag { get; set; }

       [Column("texla2_id", Order = 51, TypeName = "bigint(10)")]
       public long? texla2_id { get; set; }

   }
}
