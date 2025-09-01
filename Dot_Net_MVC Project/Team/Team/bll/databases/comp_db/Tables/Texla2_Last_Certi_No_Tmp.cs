using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_last_certi_no_tmp")] 
       
   public class Texla2_Last_Certi_No_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("reason", Order = 3, TypeName = "varchar(50)")]
       public string? reason { get; set; }

       [Column("dem", Order = 4, TypeName = "varchar(50)")]
       public string? dem { get; set; }

       [Column("noshares", Order = 5, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("stcert", Order = 6, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 7, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("disto", Order = 8, TypeName = "float")]
       public long? disto { get; set; }

       [Column("remarks", Order = 9, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("allotno", Order = 10, TypeName = "float")]
       public long? allotno { get; set; }

       [Column("old_stcert", Order = 11, TypeName = "varchar(50)")]
       public string? old_stcert { get; set; }

       [Column("misccode", Order = 12, TypeName = "float")]
       public long? misccode { get; set; }

       [Column("paidupdate", Order = 13, TypeName = "datetime")]
       public DateTime? paidupdate { get; set; }

       [Column("fpd", Order = 14, TypeName = "varchar(50)")]
       public string? fpd { get; set; }

       [Column("shlot", Order = 15, TypeName = "float")]
       public long? shlot { get; set; }

       [Column("uflag", Order = 16, TypeName = "varchar(100)")]
       public string? uflag { get; set; }

       [Column("sta", Order = 17, TypeName = "varchar(100)")]
       public string? sta { get; set; }

       [Column("dpid", Order = 18, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("clid", Order = 19, TypeName = "varchar(8)")]
       public string? clid { get; set; }

       [Column("btag", Order = 20, TypeName = "varchar(100)")]
       public string? btag { get; set; }

       [Column("trfdate", Order = 21, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("refno", Order = 22, TypeName = "float")]
       public long? refno { get; set; }

       [Column("trfolio", Order = 23, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("derno", Order = 24, TypeName = "varchar(100)")]
       public string? derno { get; set; }

       [Column("dpidno", Order = 25, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 26, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("dmdate", Order = 27, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("folio_status", Order = 28, TypeName = "varchar(50)")]
       public string? folio_status { get; set; }

       [Column("folio_in_or_out", Order = 29, TypeName = "varchar(50)")]
       public string? folio_in_or_out { get; set; }

       [Column("last_refno", Order = 30, TypeName = "varchar(50)")]
       public string? last_refno { get; set; }

       [Column("last_ref_date", Order = 31, TypeName = "varchar(50)")]
       public string? last_ref_date { get; set; }

       [Column("transfer_from", Order = 32, TypeName = "varchar(250)")]
       public string? transfer_from { get; set; }

       [Column("texla2_id", Order = 33, TypeName = "bigint(10)")]
       public long? texla2_id { get; set; }

       [Column("record_insert_datetime", Order = 34, TypeName = "datetime")]
       public DateTime? record_insert_datetime { get; set; }

       [Column("comp_sno", Order = 35, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 36, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 37, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 38, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("stcert_numric", Order = 39, TypeName = "float")]
       public long? stcert_numric { get; set; }

   }
}
