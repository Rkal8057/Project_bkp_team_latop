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
    public class ContactMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

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

        [Column("firstname", Order = 8, TypeName = "text")]
        public string? firstname { get; set; }

        [Column("lastname", Order = 9, TypeName = "text")]
        public string? lastname { get; set; }

        [Column("email", Order = 10, TypeName = "text")]
        public string? email { get; set; }

        [Column("phn_no", Order = 11, TypeName = "text")]
        public string? phn_no { get; set; }

        [Column("subject", Order = 12, TypeName = "text")]
        public string? subject { get; set; }

        [Column("message", Order = 13, TypeName = "text")]
        public string? message { get; set; }

        [Column("seen_status", Order = 14, TypeName = "text")]
        public string? seen_status { get; set; }

        [Column("sent_on", Order = 15, TypeName = "datetime")]
        public DateTime? sent_on { get; set; }
    }
}
