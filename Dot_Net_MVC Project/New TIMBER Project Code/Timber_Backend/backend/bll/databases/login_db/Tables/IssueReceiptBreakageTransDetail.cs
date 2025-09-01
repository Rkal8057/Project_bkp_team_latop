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
    public class IssueReceiptBreakageTransDetail
    {

        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("rate", Order = 1 , TypeName ="float")]
        public double? rate { get; set; }

        [Column("qty", Order = 2, TypeName = "float")]
        public double? qty { get; set; }

        [Column("amt", Order = 3, TypeName = "float")]
        public double? amt { get; set; }

        [Column("narr", Order = 4, TypeName = "text")]
        public string? narr { get; set; }

        [Column("damage", Order = 5, TypeName = "float")]
        public double? damage { get; set; }

        [Column("missing", Order = 6, TypeName = "float")]
        public double? missing { get; set; }

        [Column("item_name", Order = 7, TypeName = "text")]
        public string? item_name { get; set; }

        [ForeignKey("IssueReceiptMaster"), Column("challan_master_id", Order = 8, TypeName = "bigint")]
        public long? challan_master_id { get; set; }

        [Column("challan_trans_id", Order = 9, TypeName = "bigint")]
        public long? challan_trans_id { get; set; }

        [Column("unique_number", Order = 10, TypeName = "text")]
        public string? unique_number { get; set; }

        [Column("delete_at", Order = 11, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 12, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }
        public virtual IssueReceiptMaster? IssueReceiptMaster { get; set; }


    }
}
