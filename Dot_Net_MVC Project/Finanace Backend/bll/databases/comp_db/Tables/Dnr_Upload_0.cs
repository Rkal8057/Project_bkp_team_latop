using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("dnr_upload_0")] 
       
   public class Dnr_Upload_0
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("listing_status_dn_nse_cbox", Order = 3, TypeName = "varchar(50)")]
       public string? listing_status_dn_nse_cbox { get; set; }

       [Column("listing_status_dn_bse_cbox", Order = 4, TypeName = "varchar(50)")]
       public string? listing_status_dn_bse_cbox { get; set; }

       [Column("listing_status_dn_mcx_sx_cbox", Order = 5, TypeName = "varchar(50)")]
       public string? listing_status_dn_mcx_sx_cbox { get; set; }

       [Column("nature_of_isin_combobox", Order = 6, TypeName = "varchar(50)")]
       public string? nature_of_isin_combobox { get; set; }

       [Column("cutoff_flag_combobox", Order = 7, TypeName = "varchar(50)")]
       public string? cutoff_flag_combobox { get; set; }

       [Column("issue_description", Order = 8, TypeName = "varchar(50)")]
       public string? issue_description { get; set; }

       [Column("transaction_flag_combobox", Order = 9, TypeName = "varchar(50)")]
       public string? transaction_flag_combobox { get; set; }

       [Column("allotment_date", Order = 10, TypeName = "varchar(50)")]
       public string? allotment_date { get; set; }

       [Column("flag_for_status_of_dn_range_cbox", Order = 11, TypeName = "varchar(50)")]
       public string? flag_for_status_of_dn_range_cbox { get; set; }

       [Column("ex_change_name", Order = 12, TypeName = "varchar(50)")]
       public string? ex_change_name { get; set; }

       [Column("bathc_id", Order = 13, TypeName = "varchar(50)")]
       public string? bathc_id { get; set; }

       [Column("dep_id", Order = 14, TypeName = "varchar(50)")]
       public string? dep_id { get; set; }

       [Column("rta_id", Order = 15, TypeName = "varchar(50)")]
       public string? rta_id { get; set; }

       [Column("business_date", Order = 16, TypeName = "varchar(50)")]
       public string? business_date { get; set; }

       [Column("running_digit_no", Order = 17, TypeName = "varchar(50)")]
       public string? running_digit_no { get; set; }

       [Column("current_date_time", Order = 18, TypeName = "varchar(50)")]
       public string? current_date_time { get; set; }

   }
}
