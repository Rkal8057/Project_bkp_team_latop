using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class KYCDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint auto_increment")]
        public long id { get; set; }

        [Column("table_trf_no", Order = 2, TypeName = "decimal(18, 2)")]
        public decimal? table_trf_no { get; set; }

        [Column("multi_master_trx_no", Order = 3, TypeName = "decimal(18, 2)")]
        public decimal? multi_master_trx_no { get; set; }

        [Column("master_req_id", Order = 4, TypeName = "decimal(18, 2)")]
        public decimal? master_req_id { get; set; }

        [Column("master_inward_id", Order = 5, TypeName = "decimal(18, 2)")]
        public decimal? master_inward_id { get; set; }

        [Column("master_trf_no", Order = 6, TypeName = "decimal(18, 2)")]
        public decimal? master_trf_no { get; set; }

        [Column("p_update_type_finance", Order = 7, TypeName = "text")]
        public string? p_update_type_finance { get; set; }

        [Column("p_address_type_code_bank", Order = 8, TypeName = "text")]
        public string? p_address_type_code_bank { get; set; }

        [Column("p_address_type_code_detail_bank", Order = 9, TypeName = "text")]
        public string? p_address_type_code_detail_bank { get; set; }

        [Column("p_account_type_code", Order = 10, TypeName = "text")]
        public string? p_account_type_code { get; set; }

        [Column("p_bank_ac_no", Order = 11, TypeName = "text")]
        public string? p_bank_ac_no { get; set; }

        [Column("p_account_type", Order = 12, TypeName = "text")]
        public string? p_account_type { get; set; }

        [Column("p_bank_name", Order = 13, TypeName = "text")]
        public string? p_bank_name { get; set; }

        [Column("p_bank_micrno", Order = 14, TypeName = "text")]
        public string? p_bank_micrno { get; set; }

        [Column("p_bank_ifsc_code", Order = 15, TypeName = "text")]
        public string? p_bank_ifsc_code { get; set; }

        [Column("p_bank_add1", Order = 16, TypeName = "text")]
        public string? p_bank_add1 { get; set; }

        [Column("p_bank_add2", Order = 17, TypeName = "text")]
        public string? p_bank_add2 { get; set; }

        [Column("p_bank_add3", Order = 18, TypeName = "text")]
        public string? p_bank_add3 { get; set; }

        [Column("p_bank_city", Order = 19, TypeName = "text")]
        public string? p_bank_city { get; set; }

        [Column("p_bank_state", Order = 20, TypeName = "text")]
        public string? p_bank_state { get; set; }

        [Column("p_bank_pincode", Order = 21, TypeName = "text")]
        public string? p_bank_pincode { get; set; }

        [Column("p_bank_country", Order = 22, TypeName = "text")]
        public string? p_bank_country { get; set; }

        [Column("t_panno1", Order = 23, TypeName = "text")]
        public string? t_panno1 { get; set; }

        [Column("t_panno2", Order = 24, TypeName = "text")]
        public string? t_panno2 { get; set; }

        [Column("t_panno3", Order = 25, TypeName = "text")]
        public string? t_panno3 { get; set; }

        [Column("p_panno1", Order = 26, TypeName = "text")]
        public string? p_panno1 { get; set; }

        [Column("p_panno2", Order = 27, TypeName = "text")]
        public string? p_panno2 { get; set; }

        [Column("p_panno3", Order = 28, TypeName = "text")]
        public string? p_panno3 { get; set; }

        [Column("p_adhaar_no", Order = 29, TypeName = "text")]
        public string? p_adhaar_no { get; set; }

        [Column("p_voter_id", Order = 30, TypeName = "text")]
        public string? p_voter_id { get; set; }

        [Column("p_dl_no", Order = 31, TypeName = "text")]
        public string? p_dl_no { get; set; }

        [Column("p_passport_no", Order = 32, TypeName = "text")]
        public string? p_passport_no { get; set; }

        [Column("p_emailid", Order = 33, TypeName = "text")]
        public string? p_emailid { get; set; }

        [Column("p_phone", Order = 34, TypeName = "text")]
        public string? p_phone { get; set; }

        [Column("pan1_addhar_linked_yn", Order = 35, TypeName = "text")]
        public string? pan1_addhar_linked_yn { get; set; }

        [Column("pan2_addhar_linked_yn", Order = 36, TypeName = "text")]
        public string? pan2_addhar_linked_yn { get; set; }

        [Column("pan3_addhar_linked_yn", Order = 37, TypeName = "text")]
        public string? pan3_addhar_linked_yn { get; set; }

        [Column("rr_flag_name", Order = 38, TypeName = "text")]
        public string? rr_flag_name { get; set; }

        [Column("rejecte_yn", Order = 39, TypeName = "text")]
        public string? rejecte_yn { get; set; }

        [Column("verify_yn", Order = 40, TypeName = "text")]
        public string? verify_yn { get; set; }

        [Column("verify_by_username", Order = 41, TypeName = "text")]
        public string? verify_by_username { get; set; }

        [Column("verify_status_msg", Order = 42, TypeName = "text")]
        public string? verify_status_msg { get; set; }

        [Column("verify_remark", Order = 43, TypeName = "text")]
        public string? verify_remark { get; set; }

        [Column("verify_updated_on", Order = 44, TypeName = "date")]
        public DateTime? verify_updated_on { get; set; }

        [Column("maker_id", Order = 45, TypeName = "bigint")]
        public long? maker_id { get; set; }

        [Column("maker_name", Order = 46, TypeName = "text")]
        public string? maker_name { get; set; }

        [Column("maker_remark", Order = 47, TypeName = "text")]
        public string? maker_remark { get; set; }

        [Column("maker_status", Order = 48, TypeName = "text")]
        public string? maker_status { get; set; }

        [Column("maker_status_created_on", Order = 49, TypeName = "date")]
        public DateTime? maker_status_created_on { get; set; }

        [Column("checker_id", Order = 50, TypeName = "text")]
        public int? checker_id { get; set; }

        [Column("checker_name", Order = 51, TypeName = "text")]
        public string? checker_name { get; set; }

        [Column("checker_remark", Order = 52, TypeName = "text")]
        public string? checker_remark { get; set; }

        [Column("checker_status", Order = 53, TypeName = "text")]
        public string? checker_status { get; set; }

        [Column("checker_status_created_on", Order = 54, TypeName = "date")]
        public DateTime? checker_status_created_on { get; set; }

        [Column("current_status", Order = 55, TypeName = "text")]
        public string? current_status { get; set; }

        [ForeignKey("HolderDetail"), Column("holder_detail_id", Order = 56, TypeName = "bigint")]
        public long? holder_detail_id { get; set; }

        [JsonIgnore]
        public virtual HolderDetail? HolderDetail { get; set; }

    }
}