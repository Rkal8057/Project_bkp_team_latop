using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class vou_trn_master
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

        [ForeignKey("vou_master"), Column("voucher_master_id", Order = 8, TypeName = "bigint")]
        public long? voucher_master_id { get; set; }

        [Column("vou_p_id", Order = 9, TypeName = "bigint")]
        public long? vou_p_id { get; set; }

        [Column("vou_pname", Order = 10, TypeName = "text")]
        public string? vou_pname { get; set; }

        [Column("vou_chq_detail", Order = 11, TypeName = "text")]
        public string? vou_chq_detail { get; set; }

        [Column("vou_narr", Order = 12, TypeName = "text")]
        public string? vou_narr { get; set; }

        [Column("vou_amt", Order = 13, TypeName = "decimal(18,2)")]
        public decimal vou_amt { get; set; }

        [Column("vou_agst_bill", Order = 14, TypeName = "text")]
        public string? vou_agst_bill { get; set; }

        [Column("created_on", Order = 15, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 16, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("username", Order = 17, TypeName = "text")]
        public string? username { get; set; }


        [Column("month", Order = 18, TypeName = "bigint")]
        public long? month { get; set; }

        [Column("year", Order = 19, TypeName = "bigint")]
        public long? year { get; set; }

        [Column("status", Order = 20, TypeName = "bigint")]
        public long? status { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 21, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }



        [Column("vou_gst_amt", Order = 22, TypeName = "decimal(18,2)")]
        public decimal? vou_gst_amt { get; set; }

        [Column("vou_gst_per", Order = 23, TypeName = "decimal(18,2)")]
        public decimal? vou_gst_per { get; set; }

        [Column("vou_gross_amt", Order = 24, TypeName = "decimal(18,2)")]
        public decimal? vou_gross_amt { get; set; }


        public virtual vou_master? vou_master { get; set; }
    }
}
