using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class vou_master
    {
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }

        [Column("client_purchaser_code", Order = 2, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 3, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("agent_code", Order = 4, TypeName = "bigint")]
        public long? agent_code { get; set; }

        [Column("agent_name", Order = 5, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("vender_code", Order = 6, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("vender_name", Order = 7, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("vou_type_id", Order = 8, TypeName = "bigint")]
        public long? vou_type_id { get; set; }

        [Column("vou_type", Order = 9, TypeName = "text")]
        public string? vou_type { get; set; }

        [Column("vou_fa_year", Order = 10, TypeName = "text")]
        public string? vou_fa_year { get; set; }

        [Column("vou_ref_no", Order = 11, TypeName = "text")]
        public string? vou_ref_no { get; set; }

        [Column("vou_date", Order = 12, TypeName = "date")]
        public DateTime? vou_date { get; set; }

        [Column("vou_cash_bank_id", Order = 13, TypeName = "bigint")]
        public long? vou_cash_bank_id { get; set; }

        [Column("vou_cash_bank_name", Order = 14, TypeName = "text")]
        public string? vou_cash_bank_name { get; set; }

        [Column("tot_vou_amt", Order = 15, TypeName = "decimal(18,2)")]
        public decimal? tot_vou_amt { get; set; }

        [Column("created_on", Order = 16, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 17, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("username", Order = 18, TypeName = "text")]
        public string? username { get; set; }

        [Column("month", Order = 19, TypeName = "bigint")]
        public long? month { get; set; }

        [Column("year", Order = 20, TypeName = "bigint")]
        public long? year { get; set; }

        [Column("status", Order = 21, TypeName = "bigint")]
        public long? status { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 22, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }


        public ICollection<vou_trn_master>? vou_trn_master { get; set; }
    }
}
