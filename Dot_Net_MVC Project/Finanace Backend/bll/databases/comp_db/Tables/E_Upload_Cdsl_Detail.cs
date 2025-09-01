using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_upload_cdsl_detail")] 
       
   public class E_Upload_Cdsl_Detail
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("tp_start", Order = 3, TypeName = "varchar(4)")]
       public string? tp_start { get; set; }

       [Column("tranaction_type", Order = 4, TypeName = "varchar(2)")]
       public string? tranaction_type { get; set; }

       [Column("tp_end", Order = 5, TypeName = "varchar(5)")]
       public string? tp_end { get; set; }

       [Column("bnfcry_start", Order = 6, TypeName = "varchar(8)")]
       public string? bnfcry_start { get; set; }

       [Column("bo_id", Order = 7, TypeName = "varchar(16)")]
       public string? bo_id { get; set; }

       [Column("bnfcry_end", Order = 8, TypeName = "varchar(9)")]
       public string? bnfcry_end { get; set; }

       [Column("isin_start", Order = 9, TypeName = "varchar(6)")]
       public string? isin_start { get; set; }

       [Column("isin_no", Order = 10, TypeName = "varchar(12)")]
       public string? isin_no { get; set; }

       [Column("isin_end", Order = 11, TypeName = "varchar(7)")]
       public string? isin_end { get; set; }

       [Column("drn_start", Order = 12, TypeName = "varchar(5)")]
       public string? drn_start { get; set; }

       [Column("drn_no", Order = 13, TypeName = "varchar(8)")]
       public string? drn_no { get; set; }

       [Column("drn_end", Order = 14, TypeName = "varchar(6)")]
       public string? drn_end { get; set; }

       [Column("drn_qty_start", Order = 15, TypeName = "varchar(5)")]
       public string? drn_qty_start { get; set; }

       [Column("drn_qty", Order = 16, TypeName = "varchar(19)")]
       public string? drn_qty { get; set; }

       [Column("drn_qty_end", Order = 17, TypeName = "varchar(6)")]
       public string? drn_qty_end { get; set; }

       [Column("ref_start", Order = 18, TypeName = "varchar(5)")]
       public string? ref_start { get; set; }

       [Column("rta_ref_no", Order = 19, TypeName = "varchar(16)")]
       public string? rta_ref_no { get; set; }

       [Column("ref_end", Order = 20, TypeName = "varchar(6)")]
       public string? ref_end { get; set; }

       [Column("rcvdt_start", Order = 21, TypeName = "varchar(7)")]
       public string? rcvdt_start { get; set; }

       [Column("ref_rcv_dt", Order = 22, TypeName = "varchar(16)")]
       public string? ref_rcv_dt { get; set; }

       [Column("rcvdt_end", Order = 23, TypeName = "varchar(8)")]
       public string? rcvdt_end { get; set; }

       [Column("veraccpt_start", Order = 24, TypeName = "varchar(10)")]
       public string? veraccpt_start { get; set; }

       [Column("verify_accept_qty", Order = 25, TypeName = "varchar(19)")]
       public string? verify_accept_qty { get; set; }

       [Column("veraccpt_end", Order = 26, TypeName = "varchar(11)")]
       public string? veraccpt_end { get; set; }

       [Column("verrjct_start", Order = 27, TypeName = "varchar(9)")]
       public string? verrjct_start { get; set; }

       [Column("verify_reject_qty", Order = 28, TypeName = "varchar(19)")]
       public string? verify_reject_qty { get; set; }

       [Column("verrjct_end", Order = 29, TypeName = "varchar(10)")]
       public string? verrjct_end { get; set; }

       [Column("accpt_start", Order = 30, TypeName = "varchar(7)")]
       public string? accpt_start { get; set; }

       [Column("accept_qty", Order = 31, TypeName = "varchar(19)")]
       public string? accept_qty { get; set; }

       [Column("accpt_end", Order = 32, TypeName = "varchar(8)")]
       public string? accpt_end { get; set; }

       [Column("rjct_start", Order = 33, TypeName = "varchar(6)")]
       public string? rjct_start { get; set; }

       [Column("reject_qty", Order = 34, TypeName = "varchar(19)")]
       public string? reject_qty { get; set; }

       [Column("rjct_end", Order = 35, TypeName = "varchar(7)")]
       public string? rjct_end { get; set; }

       [Column("rej_start", Order = 36, TypeName = "varchar(5)")]
       public string? rej_start { get; set; }

       [Column("rejection_detail", Order = 37, TypeName = "varchar(100)")]
       public string? rejection_detail { get; set; }

       [Column("rej_end", Order = 38, TypeName = "varchar(6)")]
       public string? rej_end { get; set; }

       [Column("flg_start", Order = 39, TypeName = "varchar(5)")]
       public string? flg_start { get; set; }

       [Column("rejection_flag", Order = 40, TypeName = "varchar(1)")]
       public string? rejection_flag { get; set; }

       [Column("flg_end", Order = 41, TypeName = "varchar(6)")]
       public string? flg_end { get; set; }

       [Column("cd_start", Order = 42, TypeName = "varchar(4)")]
       public string? cd_start { get; set; }

       [Column("rejection_code", Order = 43, TypeName = "varchar(2)")]
       public string? rejection_code { get; set; }

       [Column("cd_end", Order = 44, TypeName = "varchar(5)")]
       public string? cd_end { get; set; }

       [Column("prtqty_start", Order = 45, TypeName = "varchar(8)")]
       public string? prtqty_start { get; set; }

       [Column("rejected_qty", Order = 46, TypeName = "varchar(19)")]
       public string? rejected_qty { get; set; }

       [Column("prtqty_end", Order = 47, TypeName = "varchar(9)")]
       public string? prtqty_end { get; set; }

       [Column("rmk_start", Order = 48, TypeName = "varchar(5)")]
       public string? rmk_start { get; set; }

       [Column("rejection_remark", Order = 49, TypeName = "varchar(40)")]
       public string? rejection_remark { get; set; }

       [Column("rmkend", Order = 50, TypeName = "varchar(6)")]
       public string? rmkend { get; set; }

       [Column("ranges_start", Order = 51, TypeName = "varchar(8)")]
       public string? ranges_start { get; set; }

       [Column("no_of_ranges", Order = 52, TypeName = "varchar(2)")]
       public string? no_of_ranges { get; set; }

       [Column("ranges_end", Order = 53, TypeName = "varchar(9)")]
       public string? ranges_end { get; set; }

   }
}
