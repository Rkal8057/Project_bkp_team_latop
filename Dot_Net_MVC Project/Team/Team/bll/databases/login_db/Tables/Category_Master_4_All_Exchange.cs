using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Category_Master_4_All_Exchange
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cate_id", Order = 2, TypeName = "float")]
       public long? cate_id { get; set; }

       [Column("cate_id_status", Order = 3, TypeName = "text")]
       public string? cate_id_status { get; set; }

       [Column("unique_id", Order = 4, TypeName = "text")]
       public string? unique_id { get; set; }

       [Column("cdsl_unique_code", Order = 5, TypeName = "text")]
       public string? cdsl_unique_code { get; set; }

       [Column("exchange_unique_code", Order = 6, TypeName = "text")]
       public string? exchange_unique_code { get; set; }

       [Column("exchange_name", Order = 7, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("cate_code_1", Order = 8, TypeName = "float")]
       public long? cate_code_1 { get; set; }

       [Column("cate_code_2", Order = 9, TypeName = "float")]
       public long? cate_code_2 { get; set; }

       [Column("cate_code_3", Order = 10, TypeName = "float")]
       public long? cate_code_3 { get; set; }

       [Column("category_header_detail", Order = 11, TypeName = "text")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 12, TypeName = "text")]
       public string? category_header { get; set; }

       [Column("category_header_discreption", Order = 13, TypeName = "text")]
       public string? category_header_discreption { get; set; }

       [Column("page_name_group", Order = 14, TypeName = "text")]
       public string? page_name_group { get; set; }

       [Column("main_category_header_index_no", Order = 15, TypeName = "float")]
       public long? main_category_header_index_no { get; set; }

       [Column("main_category_header_name", Order = 16, TypeName = "text")]
       public string? main_category_header_name { get; set; }

       [Column("sub_categroy_index_no", Order = 17, TypeName = "float")]
       public long? sub_categroy_index_no { get; set; }

       [Column("sub_categroy_index_code", Order = 18, TypeName = "text")]
       public string? sub_categroy_index_code { get; set; }

       [Column("sub_categroy_name", Order = 19, TypeName = "text")]
       public string? sub_categroy_name { get; set; }

       [Column("sub_categroy_index_no_2", Order = 20, TypeName = "float")]
       public long? sub_categroy_index_no_2 { get; set; }

       [Column("sub_categroy_name_2", Order = 21, TypeName = "text")]
       public string? sub_categroy_name_2 { get; set; }

       [Column("clinet_details_under_category", Order = 22, TypeName = "text")]
       public string? clinet_details_under_category { get; set; }

       [Column("p_pi_pn", Order = 23, TypeName = "text")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_pn_details", Order = 24, TypeName = "text")]
       public string? p_pi_pn_details { get; set; }

       [Column("page_name_group_modify", Order = 25, TypeName = "text")]
       public string? page_name_group_modify { get; set; }

       [Column("main_category_header_index_no_modify", Order = 26, TypeName = "float")]
       public long? main_category_header_index_no_modify { get; set; }

       [Column("main_category_header_name_modify", Order = 27, TypeName = "text")]
       public string? main_category_header_name_modify { get; set; }

       [Column("sub_categroy_index_no_modify", Order = 28, TypeName = "float")]
       public long? sub_categroy_index_no_modify { get; set; }

       [Column("sub_categroy_index_code_modify", Order = 29, TypeName = "text")]
       public string? sub_categroy_index_code_modify { get; set; }

       [Column("sub_categroy_name_modify", Order = 30, TypeName = "text")]
       public string? sub_categroy_name_modify { get; set; }

       [Column("sub_categroy_index_no_2_modify", Order = 31, TypeName = "float")]
       public long? sub_categroy_index_no_2_modify { get; set; }

       [Column("sub_categroy_name_2_modify", Order = 32, TypeName = "text")]
       public string? sub_categroy_name_2_modify { get; set; }

       [Column("clinet_details_under_category_modify", Order = 33, TypeName = "text")]
       public string? clinet_details_under_category_modify { get; set; }

       [Column("p_pi_pn_modify", Order = 34, TypeName = "text")]
       public string? p_pi_pn_modify { get; set; }

       [Column("p_pi_pn_details_modify", Order = 35, TypeName = "text")]
       public string? p_pi_pn_details_modify { get; set; }

   }
}
