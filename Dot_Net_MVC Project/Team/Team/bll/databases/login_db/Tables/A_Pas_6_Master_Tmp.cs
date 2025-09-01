using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{

    public class A_Pas_6_Master_Tmp
    {
        [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [Column("table_id", Order = 2, TypeName = "bigint(10)")]
        public long? table_id { get; set; }

        [Column("isin_no_company", Order = 3, TypeName = "text")]
        public string? isin_no_company { get; set; }

        [Column("isin_company", Order = 4, TypeName = "text")]
        public string? isin_company { get; set; }

        [Column("isin_company_type", Order = 5, TypeName = "text")]
        public string? isin_company_type { get; set; }

        [Column("nsdl_conn_yn", Order = 6, TypeName = "varchar(3)")]
        public string? nsdl_conn_yn { get; set; }

        [Column("cdsl_conn_yn", Order = 7, TypeName = "varchar(3)")]
        public string? cdsl_conn_yn { get; set; }

        [Column("phy_conn_yn", Order = 8, TypeName = "varchar(3)")]
        public string? phy_conn_yn { get; set; }

        [Column("total_qty", Order = 9, TypeName = "float")]
        public long? total_qty { get; set; }

        [Column("deposi_nsdl_qty", Order = 10, TypeName = "float")]
        public long? deposi_nsdl_qty { get; set; }

        [Column("deposi_cdsl_qty", Order = 11, TypeName = "float")]
        public long? deposi_cdsl_qty { get; set; }

        [Column("deposi_phy_qty", Order = 12, TypeName = "float")]
        public long? deposi_phy_qty { get; set; }

        [Column("nsdl_cdsl_total", Order = 13, TypeName = "float")]
        public long? nsdl_cdsl_total { get; set; }

        [Column("mismatch_yn", Order = 14, TypeName = "varchar(1)")]
        public string? mismatch_yn { get; set; }

        [Column("from_date", Order = 15, TypeName = "datetime")]
        public DateTime? from_date { get; set; }

        [Column("upto_date", Order = 16, TypeName = "datetime")]
        public DateTime? upto_date { get; set; }

        [Column("pas_6_date", Order = 17, TypeName = "datetime")]
        public DateTime? pas_6_date { get; set; }

        [Column("pas_6_remark", Order = 18, TypeName = "text")]
        public string? pas_6_remark { get; set; }

        [Column("email_address_rta", Order = 19, TypeName = "text")]
        public string? email_address_rta { get; set; }

        [Column("website_address_rta", Order = 20, TypeName = "text")]
        public string? website_address_rta { get; set; }

        [Column("company_name_rta", Order = 21, TypeName = "text")]
        public string? company_name_rta { get; set; }

        [Column("compliance_officer_current", Order = 22, TypeName = "text")]
        public string? compliance_officer_current { get; set; }

        [Column("maker_make_current", Order = 23, TypeName = "text")]
        public string? maker_make_current { get; set; }

        [Column("checker_name_current", Order = 24, TypeName = "text")]
        public string? checker_name_current { get; set; }

        [Column("registered_office_rta", Order = 25, TypeName = "text")]
        public string? registered_office_rta { get; set; }

        [Column("corporate_office_rta", Order = 26, TypeName = "text")]
        public string? corporate_office_rta { get; set; }

        [Column("cin_no_rta", Order = 27, TypeName = "text")]
        public string? cin_no_rta { get; set; }

        [Column("pan_no_rta", Order = 28, TypeName = "text")]
        public string? pan_no_rta { get; set; }

        [Column("isin_rta", Order = 29, TypeName = "text")]
        public string? isin_rta { get; set; }

        [Column("ph_nos_rta", Order = 30, TypeName = "text")]
        public string? ph_nos_rta { get; set; }

        [Column("member_in_exchange_rta", Order = 31, TypeName = "text")]
        public string? member_in_exchange_rta { get; set; }

        [Column("depository_participant_rta", Order = 32, TypeName = "text")]
        public string? depository_participant_rta { get; set; }

        [Column("category_detail_rta", Order = 33, TypeName = "text")]
        public string? category_detail_rta { get; set; }

        [Column("created_on", Order = 34, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("printed_yn", Order = 35, TypeName = "varchar(1)")]
        public string? printed_yn { get; set; }

    }
}
