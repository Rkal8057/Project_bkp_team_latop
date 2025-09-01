using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_vote_nsdl_master")] 
       
   public class E_Vote_Nsdl_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("batch_number", Order = 3, TypeName = "varchar(7)")]
       public string? batch_number { get; set; }

       [Column("field_separator_1", Order = 4, TypeName = "varchar(1)")]
       public string? field_separator_1 { get; set; }

       [Column("record_type", Order = 5, TypeName = "float")]
       public long? record_type { get; set; }

       [Column("field_separator_2", Order = 6, TypeName = "varchar(1)")]
       public string? field_separator_2 { get; set; }

       [Column("depositor_type_n_c_p", Order = 7, TypeName = "varchar(8)")]
       public string? depositor_type_n_c_p { get; set; }

       [Column("field_separator_3", Order = 8, TypeName = "varchar(1)")]
       public string? field_separator_3 { get; set; }

       [Column("account_no", Order = 9, TypeName = "varchar(16)")]
       public string? account_no { get; set; }

       [Column("field_separator_4", Order = 10, TypeName = "varchar(1)")]
       public string? field_separator_4 { get; set; }

       [Column("first_holder_name", Order = 11, TypeName = "varchar(135)")]
       public string? first_holder_name { get; set; }

       [Column("field_separator_5", Order = 12, TypeName = "varchar(1)")]
       public string? field_separator_5 { get; set; }

       [Column("first_holder_pan_no", Order = 13, TypeName = "varchar(10)")]
       public string? first_holder_pan_no { get; set; }

       [Column("field_separator_6", Order = 14, TypeName = "varchar(1)")]
       public string? field_separator_6 { get; set; }

       [Column("second_holder_name", Order = 15, TypeName = "varchar(45)")]
       public string? second_holder_name { get; set; }

       [Column("field_separator_7", Order = 16, TypeName = "varchar(1)")]
       public string? field_separator_7 { get; set; }

       [Column("second_holder_pan_no", Order = 17, TypeName = "varchar(10)")]
       public string? second_holder_pan_no { get; set; }

       [Column("field_separator_8", Order = 18, TypeName = "varchar(1)")]
       public string? field_separator_8 { get; set; }

       [Column("third_holder_name", Order = 19, TypeName = "varchar(45)")]
       public string? third_holder_name { get; set; }

       [Column("field_separator_9", Order = 20, TypeName = "varchar(1)")]
       public string? field_separator_9 { get; set; }

       [Column("third_holder_pan_no", Order = 21, TypeName = "varchar(10)")]
       public string? third_holder_pan_no { get; set; }

       [Column("field_separator_10", Order = 22, TypeName = "varchar(1)")]
       public string? field_separator_10 { get; set; }

       [Column("address_line_1", Order = 23, TypeName = "varchar(36)")]
       public string? address_line_1 { get; set; }

       [Column("field_separator_11", Order = 24, TypeName = "varchar(1)")]
       public string? field_separator_11 { get; set; }

       [Column("address_line_2", Order = 25, TypeName = "varchar(36)")]
       public string? address_line_2 { get; set; }

       [Column("field_separator_12", Order = 26, TypeName = "varchar(1)")]
       public string? field_separator_12 { get; set; }

       [Column("address_line_3", Order = 27, TypeName = "varchar(36)")]
       public string? address_line_3 { get; set; }

       [Column("field_separator_13", Order = 28, TypeName = "varchar(1)")]
       public string? field_separator_13 { get; set; }

       [Column("address_line_4", Order = 29, TypeName = "varchar(36)")]
       public string? address_line_4 { get; set; }

       [Column("field_separator_14", Order = 30, TypeName = "varchar(1)")]
       public string? field_separator_14 { get; set; }

       [Column("pin_code", Order = 31, TypeName = "varchar(6)")]
       public string? pin_code { get; set; }

       [Column("field_separator_15", Order = 32, TypeName = "varchar(1)")]
       public string? field_separator_15 { get; set; }

       [Column("mobile_number", Order = 33, TypeName = "varchar(10)")]
       public string? mobile_number { get; set; }

       [Column("field_separator_16", Order = 34, TypeName = "varchar(1)")]
       public string? field_separator_16 { get; set; }

       [Column("email_id", Order = 35, TypeName = "varchar(50)")]
       public string? email_id { get; set; }

       [Column("field_separator_17", Order = 36, TypeName = "varchar(1)")]
       public string? field_separator_17 { get; set; }

       [Column("holdings", Order = 37, TypeName = "varchar(18)")]
       public string? holdings { get; set; }

       [Column("field_separator_18", Order = 38, TypeName = "varchar(1)")]
       public string? field_separator_18 { get; set; }

       [Column("client_type", Order = 39, TypeName = "varchar(2)")]
       public string? client_type { get; set; }

   }
}
