using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class IssueReceiptMiscTransDetail
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("bill_no_automatic", Order = 1, TypeName = "bigint")]
        public  long? bill_no_automatic { get; set; }

        [Column("pcode", Order = 2, TypeName = "bigint")]
        public  long? pcode { get; set; }

        [Column("pname", Order = 3, TypeName = "text")]
        public string? pname { get; set; }

        [Column("agr_code_old", Order = 4, TypeName = "text")]
        public string? agr_code_old { get; set; }

        [Column("ch_no", Order = 5, TypeName = "text")]
        public string? ch_no { get; set; }

        [Column("bill_date", Order = 6, TypeName = "datetime")]
        public DateTime? bill_date { get; set; }

        [Column("exp_ac_name", Order = 7, TypeName = "text")]
        public string? exp_ac_name { get; set; }

        [Column("exp_amt", Order = 8, TypeName = "bigint")]
       public  long? exp_amt { get; set; }

        [Column("exp_remarks", Order = 9, TypeName = "text")]
        public string? exp_remarks { get; set; }

        [Column("ir_flag", Order = 10, TypeName = "text")]
        public string? ir_flag { get; set; }

        [Column("fo_oh", Order = 11, TypeName = "text")]
        public string? fo_oh { get; set; }

        [ForeignKey("IssueReceiptMaster"), Column("challan_master_id", Order = 12, TypeName = "bigint")]
        public long? challan_master_id { get; set; }

        [Column("unique_number", Order = 13, TypeName = "text")]
        public string? unique_number { get; set; }

        [Column("delete_at", Order = 14, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 15, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        public virtual IssueReceiptMaster? IssueReceiptMaster { get; set; }
    }
}
