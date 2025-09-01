using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("categroy_converted_master")] 
       
   public class Categroy_Converted_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("comp_sno", Order = 2, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 3, TypeName = "varchar(100)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 4, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 5, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("cate_auto_id", Order = 6, TypeName = "bigint(10)")]
       public long? cate_auto_id { get; set; }

       [Column("client_panno", Order = 7, TypeName = "varchar(50)")]
       public string? client_panno { get; set; }

       [Column("client_name", Order = 8, TypeName = "varchar(50)")]
       public string? client_name { get; set; }

       [Column("client_group_type", Order = 9, TypeName = "varchar(100)")]
       public string? client_group_type { get; set; }

       [Column("client_holding", Order = 10, TypeName = "varchar(100)")]
       public string? client_holding { get; set; }

       [Column("client_name_via_import", Order = 11, TypeName = "varchar(50)")]
       public string? client_name_via_import { get; set; }

       [Column("client_group_type_via_import", Order = 12, TypeName = "varchar(100)")]
       public string? client_group_type_via_import { get; set; }

       [Column("client_holding_via_import", Order = 13, TypeName = "varchar(100)")]
       public string? client_holding_via_import { get; set; }

       [Column("client_cdsl_unique_code", Order = 14, TypeName = "varchar(50)")]
       public string? client_cdsl_unique_code { get; set; }

       [Column("client_cdsl_unique_code_converted", Order = 15, TypeName = "varchar(50)")]
       public string? client_cdsl_unique_code_converted { get; set; }

       [Column("cate_id", Order = 16, TypeName = "float")]
       public long? cate_id { get; set; }

       [Column("unique_id", Order = 17, TypeName = "varchar(50)")]
       public string? unique_id { get; set; }

       [Column("cdsl_unique_code", Order = 18, TypeName = "varchar(50)")]
       public string? cdsl_unique_code { get; set; }

       [Column("exchange_unique_code", Order = 19, TypeName = "varchar(50)")]
       public string? exchange_unique_code { get; set; }

       [Column("exchange_name", Order = 20, TypeName = "varchar(50)")]
       public string? exchange_name { get; set; }

       [Column("cate_code_1", Order = 21, TypeName = "float")]
       public long? cate_code_1 { get; set; }

       [Column("cate_code_2", Order = 22, TypeName = "float")]
       public long? cate_code_2 { get; set; }

       [Column("cate_code_3", Order = 23, TypeName = "float")]
       public long? cate_code_3 { get; set; }

       [Column("category_header_detail", Order = 24, TypeName = "varchar(50)")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 25, TypeName = "varchar(50)")]
       public string? category_header { get; set; }

       [Column("category_header_discreption", Order = 26, TypeName = "varchar(50)")]
       public string? category_header_discreption { get; set; }

       [Column("page_name_group", Order = 27, TypeName = "varchar(50)")]
       public string? page_name_group { get; set; }

       [Column("main_category_header_index_no", Order = 28, TypeName = "float")]
       public long? main_category_header_index_no { get; set; }

       [Column("main_category_header_name", Order = 29, TypeName = "varchar(50)")]
       public string? main_category_header_name { get; set; }

       [Column("sub_categroy_index_no", Order = 30, TypeName = "float")]
       public long? sub_categroy_index_no { get; set; }

       [Column("sub_categroy_index_code", Order = 31, TypeName = "varchar(50)")]
       public string? sub_categroy_index_code { get; set; }

       [Column("sub_categroy_name", Order = 32, TypeName = "varchar(50)")]
       public string? sub_categroy_name { get; set; }

       [Column("sub_categroy_index_no_2", Order = 33, TypeName = "float")]
       public long? sub_categroy_index_no_2 { get; set; }

       [Column("sub_categroy_name_2", Order = 34, TypeName = "varchar(50)")]
       public string? sub_categroy_name_2 { get; set; }

       [Column("clinet_details_under_category", Order = 35, TypeName = "varchar(50)")]
       public string? clinet_details_under_category { get; set; }

       [Column("p_pi_pn", Order = 36, TypeName = "varchar(50)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_pn_details", Order = 37, TypeName = "varchar(50)")]
       public string? p_pi_pn_details { get; set; }

   }
}
