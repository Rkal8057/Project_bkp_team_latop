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
    public  class GeneralRequestCommunicationDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint")]
        public long? user_id { get; set; }

        [ForeignKey("GeneralRequestedDetail"), Column("general_request_id", Order = 3, TypeName = "bigint")]
        public long? general_request_id { get; set; }

        [Column("general_request_remark", Order = 4, TypeName = "text")]
        public string? general_request_remark { get; set; }

        [Column("created_at", Order = 5, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 6, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;
        public virtual GeneralRequestedDetail GeneralRequestedDetail { get; set; }


    }
}
