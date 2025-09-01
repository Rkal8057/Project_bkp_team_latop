using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Cdsl_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("reco_import_trx_no", Order = 3, TypeName = "float")]
       public long? reco_import_trx_no { get; set; }

       [Column("trx_no", Order = 4, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 5, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 6, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("reco_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? reco_record_date { get; set; }

       [Column("reco_record_date_text", Order = 8, TypeName = "varchar(20)")]
       public string? reco_record_date_text { get; set; }

       [Column("isin_alpha_code_1", Order = 9, TypeName = "text")]
       public string? isin_alpha_code_1 { get; set; }

       [Column("isin_description_2", Order = 10, TypeName = "text")]
       public string? isin_description_2 { get; set; }

       [Column("confirmation_status_3", Order = 11, TypeName = "text")]
       public string? confirmation_status_3 { get; set; }

       [Column("confirm_description_4", Order = 12, TypeName = "text")]
       public string? confirm_description_4 { get; set; }

       [Column("cds_opening_balance_5", Order = 13, TypeName = "double(18,3)")]
       public long? cds_opening_balance_5 { get; set; }

       [Column("rta_opening_balance_6", Order = 14, TypeName = "double(18,3)")]
       public long? rta_opening_balance_6 { get; set; }

       [Column("cds_demat_confirmation_balance_7", Order = 15, TypeName = "double(18,3)")]
       public long? cds_demat_confirmation_balance_7 { get; set; }

       [Column("rta_demat_confirmation_balance_8", Order = 16, TypeName = "double(18,3)")]
       public long? rta_demat_confirmation_balance_8 { get; set; }

       [Column("cds_remat_confirmation_balance_9", Order = 17, TypeName = "double(18,3)")]
       public long? cds_remat_confirmation_balance_9 { get; set; }

       [Column("rta_remat_confirmation_balance_10", Order = 18, TypeName = "double(18,3)")]
       public long? rta_remat_confirmation_balance_10 { get; set; }

       [Column("cds_inter_depository_transfer_in_balance_11", Order = 19, TypeName = "double(18,3)")]
       public long? cds_inter_depository_transfer_in_balance_11 { get; set; }

       [Column("rta_inter_depository_transfer_in_balance_12", Order = 20, TypeName = "double(18,3)")]
       public long? rta_inter_depository_transfer_in_balance_12 { get; set; }

       [Column("cds_inter_depository_transfer_out_balance_13", Order = 21, TypeName = "double(18,3)")]
       public long? cds_inter_depository_transfer_out_balance_13 { get; set; }

       [Column("rta_inter_depository_transfer_out_balance_14", Order = 22, TypeName = "double(18,3)")]
       public long? rta_inter_depository_transfer_out_balance_14 { get; set; }

       [Column("cds_corporate_actions_transfer_additions_15", Order = 23, TypeName = "double(18,3)")]
       public long? cds_corporate_actions_transfer_additions_15 { get; set; }

       [Column("rta_corporate_actions_transfer_additions_16", Order = 24, TypeName = "double(18,3)")]
       public long? rta_corporate_actions_transfer_additions_16 { get; set; }

       [Column("cds_corporate_actions_transfer_subtractions_17", Order = 25, TypeName = "double(18,3)")]
       public long? cds_corporate_actions_transfer_subtractions_17 { get; set; }

       [Column("rta_corporate_actions_transfer_subtractions_18", Order = 26, TypeName = "double(18,3)")]
       public long? rta_corporate_actions_transfer_subtractions_18 { get; set; }

       [Column("cds_ipo_additions_19", Order = 27, TypeName = "double(18,3)")]
       public long? cds_ipo_additions_19 { get; set; }

       [Column("rta_ipo_additions_20", Order = 28, TypeName = "double(18,3)")]
       public long? rta_ipo_additions_20 { get; set; }

       [Column("cds_closing_balance_21", Order = 29, TypeName = "double(18,3)")]
       public long? cds_closing_balance_21 { get; set; }

       [Column("rta_closing_balance_22", Order = 30, TypeName = "double(18,3)")]
       public long? rta_closing_balance_22 { get; set; }

   }
}
