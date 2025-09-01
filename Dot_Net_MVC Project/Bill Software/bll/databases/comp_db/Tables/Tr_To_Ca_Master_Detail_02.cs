using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_to_ca_master_detail_02")] 
       
   public class Tr_To_Ca_Master_Detail_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_id_02", Order = 2, TypeName = "bigint(10)")]
       public long? trx_id_02 { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("detail_sno", Order = 4, TypeName = "float")]
       public long? detail_sno { get; set; }

       [Column("main_dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? main_dp_id { get; set; }

       [Column("main_cl_id", Order = 6, TypeName = "varchar(8)")]
       public string? main_cl_id { get; set; }

       [Column("main_dp_id_cl_id", Order = 7, TypeName = "varchar(16)")]
       public string? main_dp_id_cl_id { get; set; }

       [Column("client_account_category", Order = 8, TypeName = "varchar(50)")]
       public string? client_account_category { get; set; }

       [Column("allotment_qty", Order = 9, TypeName = "float")]
       public long? allotment_qty { get; set; }

       [Column("lock_in_reason_code_grid", Order = 10, TypeName = "varchar(50)")]
       public string? lock_in_reason_code_grid { get; set; }

       [Column("lock_in_reason_date_grid", Order = 11, TypeName = "varchar(50)")]
       public string? lock_in_reason_date_grid { get; set; }

       [Column("issue_offer_price_grid", Order = 12, TypeName = "float")]
       public long? issue_offer_price_grid { get; set; }

       [Column("paidup_price_grid", Order = 13, TypeName = "float")]
       public long? paidup_price_grid { get; set; }

       [Column("issued_amount_grid", Order = 14, TypeName = "float")]
       public long? issued_amount_grid { get; set; }

       [Column("paidup_amount_grid", Order = 15, TypeName = "float")]
       public long? paidup_amount_grid { get; set; }

       [Column("comp_isin_cr", Order = 16, TypeName = "varchar(20)")]
       public string? comp_isin_cr { get; set; }

       [Column("comp_isin_dr", Order = 17, TypeName = "varchar(20)")]
       public string? comp_isin_dr { get; set; }

       [Column("tot_qty_free_dr", Order = 18, TypeName = "varchar(50)")]
       public string? tot_qty_free_dr { get; set; }

       [Column("tot_qty_free_cr", Order = 19, TypeName = "varchar(50)")]
       public string? tot_qty_free_cr { get; set; }

       [Column("tot_qty_lockin_dr", Order = 20, TypeName = "varchar(50)")]
       public string? tot_qty_lockin_dr { get; set; }

       [Column("tot_qty_lockin_cr", Order = 21, TypeName = "varchar(50)")]
       public string? tot_qty_lockin_cr { get; set; }

       [Column("tot_qty_frozen_dr", Order = 22, TypeName = "varchar(50)")]
       public string? tot_qty_frozen_dr { get; set; }

       [Column("tot_qty_frozen_cr", Order = 23, TypeName = "varchar(50)")]
       public string? tot_qty_frozen_cr { get; set; }

       [Column("dp_id_cr", Order = 24, TypeName = "varchar(8)")]
       public string? dp_id_cr { get; set; }

       [Column("cl_id_cr", Order = 25, TypeName = "varchar(8)")]
       public string? cl_id_cr { get; set; }

       [Column("cl_ac_categroy_cr", Order = 26, TypeName = "varchar(100)")]
       public string? cl_ac_categroy_cr { get; set; }

       [Column("qty_cr", Order = 27, TypeName = "varchar(50)")]
       public string? qty_cr { get; set; }

       [Column("qty_frozen_cr", Order = 28, TypeName = "varchar(50)")]
       public string? qty_frozen_cr { get; set; }

       [Column("qty_lockin_cr", Order = 29, TypeName = "varchar(50)")]
       public string? qty_lockin_cr { get; set; }

       [Column("lock_in_reason_code_grid_cr", Order = 30, TypeName = "varchar(2)")]
       public string? lock_in_reason_code_grid_cr { get; set; }

       [Column("lock_in_reason_expiry_date_grid_cr", Order = 31, TypeName = "varchar(10)")]
       public string? lock_in_reason_expiry_date_grid_cr { get; set; }

       [Column("dp_id_dr", Order = 32, TypeName = "varchar(8)")]
       public string? dp_id_dr { get; set; }

       [Column("cl_id_dr", Order = 33, TypeName = "varchar(8)")]
       public string? cl_id_dr { get; set; }

       [Column("cl_ac_categroy_dr", Order = 34, TypeName = "varchar(100)")]
       public string? cl_ac_categroy_dr { get; set; }

       [Column("qty_dr", Order = 35, TypeName = "varchar(50)")]
       public string? qty_dr { get; set; }

       [Column("qty_frozen_dr", Order = 36, TypeName = "varchar(50)")]
       public string? qty_frozen_dr { get; set; }

       [Column("qty_lockin_dr", Order = 37, TypeName = "varchar(50)")]
       public string? qty_lockin_dr { get; set; }

       [Column("lock_in_reason_code_grid_dr", Order = 38, TypeName = "varchar(2)")]
       public string? lock_in_reason_code_grid_dr { get; set; }

       [Column("lock_in_reason_expiry_date_grid_dr", Order = 39, TypeName = "varchar(10)")]
       public string? lock_in_reason_expiry_date_grid_dr { get; set; }

       [Column("lockin_reason_dr", Order = 40, TypeName = "varchar(50)")]
       public string? lockin_reason_dr { get; set; }

       [Column("lockin_reason_cr", Order = 41, TypeName = "varchar(50)")]
       public string? lockin_reason_cr { get; set; }

       [Column("debit_credit_flag_dr", Order = 42, TypeName = "varchar(50)")]
       public string? debit_credit_flag_dr { get; set; }

       [Column("debit_credit_flag_cr", Order = 43, TypeName = "varchar(50)")]
       public string? debit_credit_flag_cr { get; set; }

   }
}
