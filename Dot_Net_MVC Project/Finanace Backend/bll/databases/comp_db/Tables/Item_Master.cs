using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("item_master")] 
       
   public class Item_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("item_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? item_auto_id { get; set; }

       [Column("item_code", Order = 3, TypeName = "bigint(10)")]
       public long? item_code { get; set; }

       [Column("item_name", Order = 4, TypeName = "varchar(50)")]
       public string? item_name { get; set; }

       [Column("group_code", Order = 5, TypeName = "bigint(10)")]
       public long? group_code { get; set; }

       [Column("group_name", Order = 6, TypeName = "varchar(50)")]
       public string? group_name { get; set; }

       [Column("pur_rate", Order = 7, TypeName = "double(18,3)")]
       public long? pur_rate { get; set; }

       [Column("sal_rate", Order = 8, TypeName = "double(18,3)")]
       public long? sal_rate { get; set; }

       [Column("op_stock", Order = 9, TypeName = "double(18,3)")]
       public long? op_stock { get; set; }

       [Column("remark_note", Order = 10, TypeName = "varchar(50)")]
       public string? remark_note { get; set; }

       [Column("enter_date_time", Order = 11, TypeName = "datetime")]
       public DateTime? enter_date_time { get; set; }

       [Column("lower_unit", Order = 12, TypeName = "varchar(50)")]
       public string? lower_unit { get; set; }

       [Column("upper_unit", Order = 13, TypeName = "varchar(50)")]
       public string? upper_unit { get; set; }

       [Column("packing_type", Order = 14, TypeName = "varchar(50)")]
       public string? packing_type { get; set; }

       [Column("other4", Order = 15, TypeName = "varchar(50)")]
       public string? other4 { get; set; }

       [Column("other5", Order = 16, TypeName = "varchar(50)")]
       public string? other5 { get; set; }

       [Column("con_qty_1", Order = 17, TypeName = "double(18,3)")]
       public long? con_qty_1 { get; set; }

       [Column("min_qty", Order = 18, TypeName = "bigint(10)")]
       public long? min_qty { get; set; }

       [Column("max_qty", Order = 19, TypeName = "bigint(10)")]
       public long? max_qty { get; set; }

       [Column("con_qty_2", Order = 20, TypeName = "bigint(10)")]
       public long? con_qty_2 { get; set; }

       [Column("other_num5", Order = 21, TypeName = "bigint(10)")]
       public long? other_num5 { get; set; }

       [Column("nag_qty", Order = 22, TypeName = "double(18,3)")]
       public long? nag_qty { get; set; }

       [Column("bag_qty", Order = 23, TypeName = "double(18,3)")]
       public long? bag_qty { get; set; }

       [Column("loose_qty", Order = 24, TypeName = "double(18,3)")]
       public long? loose_qty { get; set; }

       [Column("nag_conv", Order = 25, TypeName = "double(18,3)")]
       public long? nag_conv { get; set; }

       [Column("bag_conv", Order = 26, TypeName = "double(18,3)")]
       public long? bag_conv { get; set; }

       [Column("nag_packing", Order = 27, TypeName = "varchar(50)")]
       public string? nag_packing { get; set; }

       [Column("bag_packing", Order = 28, TypeName = "varchar(50)")]
       public string? bag_packing { get; set; }

       [Column("loose_packing", Order = 29, TypeName = "varchar(50)")]
       public string? loose_packing { get; set; }

       [Column("item_type", Order = 30, TypeName = "varchar(50)")]
       public string? item_type { get; set; }

       [Column("packing_cost", Order = 31, TypeName = "double(18,3)")]
       public long? packing_cost { get; set; }

       [Column("hsn_code", Order = 32, TypeName = "varchar(50)")]
       public string? hsn_code { get; set; }

       [Column("gst_tax_rate", Order = 33, TypeName = "double(18,3)")]
       public long? gst_tax_rate { get; set; }

       [Column("dis_slab_type", Order = 34, TypeName = "varchar(50)")]
       public string? dis_slab_type { get; set; }

       [Column("dis_per_1st", Order = 35, TypeName = "double(18,3)")]
       public long? dis_per_1st { get; set; }

       [Column("dis_amt_1st", Order = 36, TypeName = "double(18,3)")]
       public long? dis_amt_1st { get; set; }

       [Column("rate_1st", Order = 37, TypeName = "double(18,3)")]
       public long? rate_1st { get; set; }

       [Column("dis_per_2st", Order = 38, TypeName = "double(18,3)")]
       public long? dis_per_2st { get; set; }

       [Column("dis_amt_2st", Order = 39, TypeName = "double(18,3)")]
       public long? dis_amt_2st { get; set; }

       [Column("rate_2st", Order = 40, TypeName = "double(18,3)")]
       public long? rate_2st { get; set; }

       [Column("tax_per", Order = 41, TypeName = "double(18,3)")]
       public long? tax_per { get; set; }

       [Column("tax_amt", Order = 42, TypeName = "double(18,3)")]
       public long? tax_amt { get; set; }

       [Column("rate_final", Order = 43, TypeName = "double(18,3)")]
       public long? rate_final { get; set; }

       [Column("comp_sno", Order = 44, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 45, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 46, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 47, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
