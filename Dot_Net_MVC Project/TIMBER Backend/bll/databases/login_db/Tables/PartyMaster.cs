using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class PartyMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("name", Order = 2, TypeName = "text")]
        public string? name { get; set; }

        [Column("address", Order = 3, TypeName = "text")]
        public string?address { get; set; }

        [Column("mobile_number", Order = 4, TypeName = "bigint")]
        public long? mobile_number { get; set; }

        [Column("email", Order = 5, TypeName = "text")]
        public string? email { get; set; }

        [Column("pincode", Order = 6, TypeName = "bigint")]
        public long? pincode { get; set; }

        [Column("hire_status", Order = 7, TypeName = "text")]
        public string? hire_status { get; set; }

        [Column("agreement_start_date", Order = 8, TypeName = "datetime")]
        public DateTime? agreement_start_date { get; set; }


        [Column("bill_type", Order = 9, TypeName = "text")]
        public string? bill_type { get; set; }

        [Column("group", Order = 10, TypeName = "text")]
        public string? group { get; set; }

        [Column("security_amount", Order = 11, TypeName = "decimal(18,2)")]
        public decimal? security_amount { get; set; }


        [Column("tax_type", Order = 12, TypeName = "text")]
        public string? tax_type { get; set; }

        [Column("percentage", Order = 13, TypeName = "decimal(5,2)")]
        public decimal? percentage { get; set; }

        [Column("dr", Order = 14, TypeName = "text")]
        public string? dr { get; set; }

        [Column("gstin", Order = 15, TypeName = "text")]
        public string? gstin { get; set; }

        [Column("ref_by", Order = 16, TypeName = "text")]
        public string? ref_by { get; set; }

            

        // finanace table key 


        [Column("GSTIN_No", Order = 17, TypeName = "text")]
        public string? GSTIN_No { get; set; }

        [Column("Pay_Term_Days", Order = 18, TypeName = "text")]
        public string? Pay_Term_Days { get; set; }

        [Column("Addhar_No", Order = 19, TypeName = "text")]
        public string? Addhar_No { get; set; }

        [Column("PAN_NO", Order = 20, TypeName = "text")]
        public string? PAN_NO { get; set; }

        [Column("Ac_Opening_Date", Order = 21, TypeName = "date")]
        public DateTime? Ac_Opening_Date { get; set; }

        [Column("Op_Bal", Order = 22, TypeName = "bigint")]
        public long? Op_Bal { get; set; }

        [Column("Dr_Cr", Order = 23, TypeName = "text")]
        public string? Dr_Cr { get; set; }


        [Column("party_company_name", Order = 24, TypeName = "text")]
        public string? party_company_name { get; set; }

        [Column("party_group_category_name", Order = 25, TypeName = "text")]
        public string? party_group_category_name { get; set; }


        [Column("ref_commission", Order = 26, TypeName = "text")]
        public string? ref_commission { get; set; }

        [Column("party_agr_code", Order = 27, TypeName = "text")]
        public string? party_agr_code { get; set; }


        [Column("party_group_category_id", Order = 28, TypeName = "bigint")]
        public long? party_group_category_id { get; set; }


        [Column("agreement_end_date", Order = 29, TypeName = "datetime")]
        public DateTime? agreement_end_date { get; set; }

        [Column("type_of_service", Order = 30, TypeName = "text")]
        public string? type_of_service { get; set; }

        [Column("delete_at", Order = 31, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;




        public ICollection<SalesMaster> SalesMaster { get; set; }
        public ICollection<PartyAddressTransMaster>? PartyAddressTransMaster { get; set; }
        public ICollection<PartyContactTransMaster>? PartyContactTransMaster { get;set; }
        public ICollection<AggrementMaster>? AggrementMaster { get; set; }
        public ICollection<PartyItemRateTrans>? PartyItemRateTrans { get; set; }

        public ICollection<Remark_Upload_Detail>? Remark_Upload_Detail { get; set; }


    }
}
