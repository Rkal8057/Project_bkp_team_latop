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
    public class vou_list_master
    {
   
        [Key, Column("vou_type_id", Order = 1, TypeName = "bigint")]
        public long? vou_type_id { get; set; }

        [Column("vou_type_name", Order = 2, TypeName = "text")]
        public string? vou_type_name { get; set; }

        [Column("vou_list_remark", Order = 3, TypeName = "text")]
        public string? vou_list_remark { get; set; }

        [Column("unique_trn_id", Order = 4, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }

        [Column("client_purchaser_code", Order = 5, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 6, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("agent_code", Order = 7, TypeName = "bigint")]
        public long? agent_code { get; set; }

        [Column("agent_name", Order = 8, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("vender_code", Order = 9, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("vender_name", Order = 10, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("created_on", Order = 11, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 12, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("old_software_code_ya_id", Order = 13, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }
    }
}
