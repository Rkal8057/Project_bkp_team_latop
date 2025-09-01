using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_01_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("req_rec_online_isin_no", Order = 3, TypeName = "text")]
       public string? req_rec_online_isin_no { get; set; }

       [Column("req_rec_online_isin_company", Order = 4, TypeName = "text")]
       public string? req_rec_online_isin_company { get; set; }

       [Column("req_rec_online_trx_no", Order = 5, TypeName = "float")]
       public long? req_rec_online_trx_no { get; set; }

       [Column("trx_no", Order = 6, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 7, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 8, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("req_rec_record_date", Order = 9, TypeName = "datetime")]
       public DateTime? req_rec_record_date { get; set; }

       [Column("req_rec_record_date_text", Order = 10, TypeName = "varchar(20)")]
       public string? req_rec_record_date_text { get; set; }

       [Column("record_type", Order = 11, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("isin_no", Order = 12, TypeName = "varchar(12)")]
       public string? isin_no { get; set; }

       [Column("sr_bp_id", Order = 13, TypeName = "varchar(8)")]
       public string? sr_bp_id { get; set; }

       [Column("sr_name", Order = 14, TypeName = "varchar(135)")]
       public string? sr_name { get; set; }

       [Column("statement_preparation_date", Order = 15, TypeName = "varchar(20)")]
       public string? statement_preparation_date { get; set; }

       [Column("statement_preparation_time", Order = 16, TypeName = "varchar(20)")]
       public string? statement_preparation_time { get; set; }

       [Column("total_demat_positions_conversion_of_units_request", Order = 17, TypeName = "double(18,3)")]
       public long? total_demat_positions_conversion_of_units_request { get; set; }

       [Column("total_demat_positions_conversion_of_units_accepted", Order = 18, TypeName = "double(18,3)")]
       public long? total_demat_positions_conversion_of_units_accepted { get; set; }

       [Column("total_demat_positions_conversion_of_units_rejected", Order = 19, TypeName = "double(18,3)")]
       public long? total_demat_positions_conversion_of_units_rejected { get; set; }

       [Column("total_demat_positions_conversion_of_units_pending", Order = 20, TypeName = "double(18,3)")]
       public long? total_demat_positions_conversion_of_units_pending { get; set; }

       [Column("total_remat_positions_requested", Order = 21, TypeName = "double(18,3)")]
       public long? total_remat_positions_requested { get; set; }

       [Column("total_remat_positions_accepted", Order = 22, TypeName = "double(18,3)")]
       public long? total_remat_positions_accepted { get; set; }

       [Column("total_remat_positions_rejected", Order = 23, TypeName = "double(18,3)")]
       public long? total_remat_positions_rejected { get; set; }

       [Column("total_remat_positions_pending", Order = 24, TypeName = "double(18,3)")]
       public long? total_remat_positions_pending { get; set; }

       [Column("total_repurchase_redemption_position_requested", Order = 25, TypeName = "double(18,3)")]
       public long? total_repurchase_redemption_position_requested { get; set; }

       [Column("total_repurchase_redemption_position_accepted", Order = 26, TypeName = "double(18,3)")]
       public long? total_repurchase_redemption_position_accepted { get; set; }

       [Column("total_repurchase_redemption_position_rejected", Order = 27, TypeName = "double(18,3)")]
       public long? total_repurchase_redemption_position_rejected { get; set; }

       [Column("total_repurchase_redemption_position_pending", Order = 28, TypeName = "double(18,3)")]
       public long? total_repurchase_redemption_position_pending { get; set; }

       [Column("total_num_of_dmat_conversion_of_units_instr", Order = 29, TypeName = "double(18,3)")]
       public long? total_num_of_dmat_conversion_of_units_instr { get; set; }

       [Column("total_num_of_remat_instr_8", Order = 30, TypeName = "float")]
       public long? total_num_of_remat_instr_8 { get; set; }

       [Column("total_number_of_repurchase_redemption_instr_8", Order = 31, TypeName = "float")]
       public long? total_number_of_repurchase_redemption_instr_8 { get; set; }

       [Column("total_number_of_partially_pending_demat_conversion_of_units_8", Order = 32, TypeName = "float")]
       public long? total_number_of_partially_pending_demat_conversion_of_units_8 { get; set; }

       [Column("total_num_of_partially_pending_remat_8", Order = 33, TypeName = "float")]
       public long? total_num_of_partially_pending_remat_8 { get; set; }

       [Column("total_num_of_partially_pending_repurchase_redemption_8", Order = 34, TypeName = "float")]
       public long? total_num_of_partially_pending_repurchase_redemption_8 { get; set; }

       [Column("total_number_of_fully_pending_demat_conversion_of_units_8", Order = 35, TypeName = "float")]
       public long? total_number_of_fully_pending_demat_conversion_of_units_8 { get; set; }

       [Column("total_num_of_fully_pending_remat_8", Order = 36, TypeName = "float")]
       public long? total_num_of_fully_pending_remat_8 { get; set; }

       [Column("total_num_of_fully_pending_repurchase_redemption_8", Order = 37, TypeName = "float")]
       public long? total_num_of_fully_pending_repurchase_redemption_8 { get; set; }

       [Column("total_number_of_detail_records_7", Order = 38, TypeName = "float")]
       public long? total_number_of_detail_records_7 { get; set; }

       [Column("full_incremental_flag", Order = 39, TypeName = "varchar(1)")]
       public string? full_incremental_flag { get; set; }

       [Column("incremental_reference_date", Order = 40, TypeName = "varchar(20)")]
       public string? incremental_reference_date { get; set; }

       [Column("filler_01", Order = 41, TypeName = "varchar(10)")]
       public string? filler_01 { get; set; }

   }
}
