using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Benpos_Process_Control_Mst_1718
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("process_id", Order = 2, TypeName = "bigint(10)")]
       public long? process_id { get; set; }

       [Column("process_date", Order = 3, TypeName = "datetime")]
       public DateTime? process_date { get; set; }

       [Column("process_exchange_name", Order = 4, TypeName = "varchar(100)")]
       public string? process_exchange_name { get; set; }

       [Column("comp_isin", Order = 5, TypeName = "varchar(100)")]
       public string? comp_isin { get; set; }

       [Column("benpos_date", Order = 6, TypeName = "datetime")]
       public DateTime? benpos_date { get; set; }

       [Column("nsdl_done_yn", Order = 7, TypeName = "varchar(1)")]
       public string? nsdl_done_yn { get; set; }

       [Column("nsdl_holding", Order = 8, TypeName = "float")]
       public long? nsdl_holding { get; set; }

       [Column("error_in_nsdl_yn", Order = 9, TypeName = "varchar(1)")]
       public string? error_in_nsdl_yn { get; set; }

       [Column("error_detail_nsdl", Order = 10, TypeName = "varchar(100)")]
       public string? error_detail_nsdl { get; set; }

       [Column("cdsl_done_yn", Order = 11, TypeName = "varchar(100)")]
       public string? cdsl_done_yn { get; set; }

       [Column("cdsl_holding", Order = 12, TypeName = "float")]
       public long? cdsl_holding { get; set; }

       [Column("error_in_cdsl_yn", Order = 13, TypeName = "varchar(1)")]
       public string? error_in_cdsl_yn { get; set; }

       [Column("error_detail_cdsl", Order = 14, TypeName = "varchar(100)")]
       public string? error_detail_cdsl { get; set; }

       [Column("phy_done_yn", Order = 15, TypeName = "varchar(100)")]
       public string? phy_done_yn { get; set; }

       [Column("phy_holding", Order = 16, TypeName = "float")]
       public long? phy_holding { get; set; }

       [Column("error_in_phy_yn", Order = 17, TypeName = "varchar(1)")]
       public string? error_in_phy_yn { get; set; }

       [Column("error_detail_phy", Order = 18, TypeName = "varchar(100)")]
       public string? error_detail_phy { get; set; }

   }
}
