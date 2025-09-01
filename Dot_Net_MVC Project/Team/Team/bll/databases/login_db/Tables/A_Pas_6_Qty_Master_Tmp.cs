using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class A_Pas_6_Qty_Master_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("isin_no", Order = 3, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("company_name", Order = 4, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("company_name_short", Order = 5, TypeName = "text")]
       public string? company_name_short { get; set; }

       [Column("isin_company_type", Order = 6, TypeName = "text")]
       public string? isin_company_type { get; set; }

       [Column("nsdl_conn_yn", Order = 7, TypeName = "varchar(3)")]
       public string? nsdl_conn_yn { get; set; }

       [Column("cdsl_conn_yn", Order = 8, TypeName = "varchar(3)")]
       public string? cdsl_conn_yn { get; set; }

       [Column("phy_conn_yn", Order = 9, TypeName = "varchar(3)")]
       public string? phy_conn_yn { get; set; }

       [Column("sno", Order = 10, TypeName = "float")]
       public long? sno { get; set; }

       [Column("particular_detail", Order = 11, TypeName = "text")]
       public string? particular_detail { get; set; }

       [Column("within_21_days_qty_nsdl", Order = 12, TypeName = "text")]
       public string? within_21_days_qty_nsdl { get; set; }

       [Column("beyound_21_days_qty_nsdl", Order = 13, TypeName = "text")]
       public string? beyound_21_days_qty_nsdl { get; set; }

       [Column("within_21_days_qty_cdsl", Order = 14, TypeName = "text")]
       public string? within_21_days_qty_cdsl { get; set; }

       [Column("beyound_21_days_qty_cdsl", Order = 15, TypeName = "text")]
       public string? beyound_21_days_qty_cdsl { get; set; }

       [Column("registered_office", Order = 16, TypeName = "text")]
       public string? registered_office { get; set; }

       [Column("corporate_office", Order = 17, TypeName = "text")]
       public string? corporate_office { get; set; }

       [Column("cin_no", Order = 18, TypeName = "text")]
       public string? cin_no { get; set; }

       [Column("pan_no", Order = 19, TypeName = "text")]
       public string? pan_no { get; set; }

       [Column("ph_nos", Order = 20, TypeName = "text")]
       public string? ph_nos { get; set; }

       [Column("email_address", Order = 21, TypeName = "text")]
       public string? email_address { get; set; }

       [Column("website_address", Order = 22, TypeName = "text")]
       public string? website_address { get; set; }

       [Column("created_on", Order = 23, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

   }
}
