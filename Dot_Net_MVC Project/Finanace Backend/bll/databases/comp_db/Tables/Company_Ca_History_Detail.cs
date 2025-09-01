using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("company_ca_history_detail")] 
       
   public class Company_Ca_History_Detail
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "varchar(50)")]
       public string? trfno { get; set; }

       [Column("trfdate", Order = 4, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("vou_type", Order = 5, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("allot_date", Order = 6, TypeName = "datetime")]
       public DateTime? allot_date { get; set; }

       [Column("execution_date", Order = 7, TypeName = "datetime")]
       public DateTime? execution_date { get; set; }

       [Column("ca_type_flag", Order = 8, TypeName = "varchar(50)")]
       public string? ca_type_flag { get; set; }

       [Column("cr_dr_indicator", Order = 9, TypeName = "varchar(50)")]
       public string? cr_dr_indicator { get; set; }

       [Column("exchange_name", Order = 10, TypeName = "varchar(50)")]
       public string? exchange_name { get; set; }

       [Column("remarks", Order = 11, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("ca_type_desc_code_master", Order = 12, TypeName = "varchar(50)")]
       public string? ca_type_desc_code_master { get; set; }

       [Column("ca_type_desc_name_master", Order = 13, TypeName = "varchar(50)")]
       public string? ca_type_desc_name_master { get; set; }

       [Column("ca_type_desc_code_sub", Order = 14, TypeName = "varchar(50)")]
       public string? ca_type_desc_code_sub { get; set; }

       [Column("ca_type_desc_name_sub", Order = 15, TypeName = "varchar(50)")]
       public string? ca_type_desc_name_sub { get; set; }

       [Column("tot_allotment_qty", Order = 16, TypeName = "float")]
       public long? tot_allotment_qty { get; set; }

       [Column("lock_in_c_allot_qty", Order = 17, TypeName = "float")]
       public long? lock_in_c_allot_qty { get; set; }

       [Column("closing_date", Order = 18, TypeName = "datetime")]
       public DateTime? closing_date { get; set; }

       [Column("opening_date", Order = 19, TypeName = "datetime")]
       public DateTime? opening_date { get; set; }

       [Column("comp_sno", Order = 20, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 21, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 22, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 23, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("paid_up_capital_qty", Order = 24, TypeName = "float")]
       public long? paid_up_capital_qty { get; set; }

       [Column("paid_up_capital_amt", Order = 25, TypeName = "float")]
       public long? paid_up_capital_amt { get; set; }

       [Column("qty_phy", Order = 26, TypeName = "float")]
       public long? qty_phy { get; set; }

       [Column("qty_cdsl", Order = 27, TypeName = "float")]
       public long? qty_cdsl { get; set; }

       [Column("qty_nsdl", Order = 28, TypeName = "float")]
       public long? qty_nsdl { get; set; }

       [Column("share_price", Order = 29, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("qty_phy_fully", Order = 30, TypeName = "float")]
       public long? qty_phy_fully { get; set; }

       [Column("qty_cdsl_fully", Order = 31, TypeName = "float")]
       public long? qty_cdsl_fully { get; set; }

       [Column("qty_nsdl_fully", Order = 32, TypeName = "float")]
       public long? qty_nsdl_fully { get; set; }

       [Column("share_price_fully", Order = 33, TypeName = "float")]
       public long? share_price_fully { get; set; }

       [Column("qty_phy_partly", Order = 34, TypeName = "float")]
       public long? qty_phy_partly { get; set; }

       [Column("qty_cdsl_partly", Order = 35, TypeName = "float")]
       public long? qty_cdsl_partly { get; set; }

       [Column("qty_nsdl_partly", Order = 36, TypeName = "float")]
       public long? qty_nsdl_partly { get; set; }

       [Column("share_price_partly", Order = 37, TypeName = "float")]
       public long? share_price_partly { get; set; }

       [Column("value_date", Order = 38, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 39, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("maker_username", Order = 40, TypeName = "varchar(50)")]
       public string? maker_username { get; set; }

       [Column("checker_username", Order = 41, TypeName = "varchar(50)")]
       public string? checker_username { get; set; }

       [Column("current_status", Order = 42, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("record_status", Order = 43, TypeName = "varchar(50)")]
       public string? record_status { get; set; }

       [Column("computer_id", Order = 44, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
