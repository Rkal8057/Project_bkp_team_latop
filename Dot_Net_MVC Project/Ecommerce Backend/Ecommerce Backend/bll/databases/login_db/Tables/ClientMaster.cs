using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB.Login.Tables
{
    public class ClientMaster
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

        [Column("client_name", Order = 8, TypeName = "text")]
        public string? client_name { get; set; }

        [Column("client_feedback", Order = 9, TypeName = "text")]
        public string? client_feedback { get; set; }

        [Column("client_status", Order = 10, TypeName = "bigint")]
        public long? client_status { get; set; } = 0;

        [Column("deleted", Order = 11, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("img_url", Order = 12, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("username", Order = 13, TypeName = "text")]
        public string? username { get; set; }

        [Column("created_on", Order = 14, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 15, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
    }
}
