using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("upload_master_nsdl_cdsl")] 
       
   public class Upload_Master_Nsdl_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("record_identification", Order = 3, TypeName = "varchar(2)")]
       public string? record_identification { get; set; }

       [Column("batch_id_number", Order = 4, TypeName = "varchar(8)")]
       public string? batch_id_number { get; set; }

       [Column("record_type", Order = 5, TypeName = "float")]
       public long? record_type { get; set; }

       [Column("depositor_type_n_c_p", Order = 6, TypeName = "varchar(8)")]
       public string? depositor_type_n_c_p { get; set; }

       [Column("account_no", Order = 7, TypeName = "varchar(16)")]
       public string? account_no { get; set; }

       [Column("first_holder_name", Order = 8, TypeName = "varchar(164)")]
       public string? first_holder_name { get; set; }

       [Column("first_holder_pan_no", Order = 9, TypeName = "varchar(10)")]
       public string? first_holder_pan_no { get; set; }

       [Column("second_holder_name", Order = 10, TypeName = "varchar(164)")]
       public string? second_holder_name { get; set; }

       [Column("second_holder_pan_no", Order = 11, TypeName = "varchar(10)")]
       public string? second_holder_pan_no { get; set; }

       [Column("third_holder_name", Order = 12, TypeName = "varchar(164)")]
       public string? third_holder_name { get; set; }

       [Column("third_holder_pan_no", Order = 13, TypeName = "varchar(10)")]
       public string? third_holder_pan_no { get; set; }

       [Column("fourth_holder_name", Order = 14, TypeName = "varchar(164)")]
       public string? fourth_holder_name { get; set; }

       [Column("fourth_holder_pan_no", Order = 15, TypeName = "varchar(10)")]
       public string? fourth_holder_pan_no { get; set; }

       [Column("address_line_1", Order = 16, TypeName = "varchar(136)")]
       public string? address_line_1 { get; set; }

       [Column("address_line_2", Order = 17, TypeName = "varchar(136)")]
       public string? address_line_2 { get; set; }

       [Column("address_line_3", Order = 18, TypeName = "varchar(136)")]
       public string? address_line_3 { get; set; }

       [Column("address_line_4", Order = 19, TypeName = "varchar(136)")]
       public string? address_line_4 { get; set; }

       [Column("pin_code", Order = 20, TypeName = "varchar(50)")]
       public string? pin_code { get; set; }

       [Column("mobile_number", Order = 21, TypeName = "varchar(100)")]
       public string? mobile_number { get; set; }

       [Column("email_id", Order = 22, TypeName = "varchar(150)")]
       public string? email_id { get; set; }

       [Column("certi_number_from", Order = 23, TypeName = "varchar(10)")]
       public string? certi_number_from { get; set; }

       [Column("certi_number_upto", Order = 24, TypeName = "varchar(10)")]
       public string? certi_number_upto { get; set; }

       [Column("dist_number_from", Order = 25, TypeName = "varchar(18)")]
       public string? dist_number_from { get; set; }

       [Column("dist_number_upto", Order = 26, TypeName = "varchar(18)")]
       public string? dist_number_upto { get; set; }

       [Column("holdings", Order = 27, TypeName = "varchar(18)")]
       public string? holdings { get; set; }

       [Column("share_qty", Order = 28, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("client_type", Order = 29, TypeName = "varchar(2)")]
       public string? client_type { get; set; }

       [Column("client_status_as_on", Order = 30, TypeName = "varchar(2)")]
       public string? client_status_as_on { get; set; }

       [Column("transferee_1st_name", Order = 31, TypeName = "varchar(164)")]
       public string? transferee_1st_name { get; set; }

       [Column("transferee_1st_pan_no", Order = 32, TypeName = "varchar(10)")]
       public string? transferee_1st_pan_no { get; set; }

       [Column("transferee_2nd_name", Order = 33, TypeName = "varchar(164)")]
       public string? transferee_2nd_name { get; set; }

       [Column("transferee_2nd_pan_no", Order = 34, TypeName = "varchar(10)")]
       public string? transferee_2nd_pan_no { get; set; }

       [Column("ttransferee_3rd_name", Order = 35, TypeName = "varchar(164)")]
       public string? ttransferee_3rd_name { get; set; }

       [Column("transferee_3rd_pan_no", Order = 36, TypeName = "varchar(10)")]
       public string? transferee_3rd_pan_no { get; set; }

       [Column("transferee_4th_name", Order = 37, TypeName = "varchar(164)")]
       public string? transferee_4th_name { get; set; }

       [Column("transferee_4th_pan_no", Order = 38, TypeName = "varchar(10)")]
       public string? transferee_4th_pan_no { get; set; }

       [Column("filler_field", Order = 39, TypeName = "varchar(100)")]
       public string? filler_field { get; set; }

   }
}
