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
    public class AggrementMaster
    {
        [Key ,Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("pcode", Order = 2, TypeName = "bigint")]
        public long? pcode { get; set; }

        [Column("pname_short_code", Order = 3, TypeName = "text")]
        public string? pname_short_code { get; set; }

        [Column("pname", Order = 4, TypeName = "text")]
        public string? pname { get; set; }

        [Column("agr_code_old", Order = 5, TypeName = "text")]
        public string? agr_code_old { get; set; }

        [Column("agr_no_old", Order = 6, TypeName = "text")]
        public string? agr_no_old { get; set; }

        [Column("item_status_agr", Order = 7, TypeName = "text")]
        public string? item_status_agr { get; set; }

        [ForeignKey("ItemMaster") ,Column("item_code", Order = 8, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("item_short_name", Order = 9, TypeName = "text")]
        public string? item_short_name { get; set; }

        [Column("item_name", Order = 10, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_group_code", Order = 11, TypeName = "bigint")]
        public long? item_group_code { get; set; }

        [Column("item_group_name", Order = 12, TypeName = "text")]
        public string? item_group_name { get; set; }

        [Column("mix_item_yes_no", Order = 13, TypeName = "text")]
        public string? mix_item_yes_no { get; set; }

        [Column("item_loc", Order = 14, TypeName = "text")]
        public string? item_loc { get; set; }

        [Column("rent_rate", Order = 15, TypeName = "float")]
        public double? rent_rate { get; set; }

        [Column("broken_chg", Order = 16, TypeName = "float")]
        public double? broken_chg { get; set; }

        [Column("agr_qty", Order = 17, TypeName = "float")]
        public double? agr_qty { get; set; }

        [Column("agr_date", Order = 18, TypeName = "datetime")]
        public DateTime? agr_date { get; set; }

        [Column("opening_qty", Order = 19, TypeName = "float")]
        public double? opening_qty { get; set; }

        [Column("rate_on_type", Order = 20, TypeName = "text")]
        public string? rate_on_type { get; set; }

        [Column("missing_rate", Order = 21, TypeName = "float")]
        public double? missing_rate { get; set; }

        [Column("notaxrate", Order = 22, TypeName = "float")]
        public double? notaxrate { get; set; }

        [Column("s_no", Order = 23, TypeName = "bigint")]
        public long? s_no { get; set; }

        [Column("rate_of_one_pcs", Order = 24, TypeName = "text")]
        public string? rate_of_one_pcs { get; set; }

        [Column("weight_of_one_pcs", Order = 25, TypeName = "float")]
        public double? weight_of_one_pcs { get; set; }

        [Column("created_on", Order = 26, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 27, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("delete", Order = 28, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

        [ForeignKey("PartyMaster") ,Column("party_master_id", Order = 29, TypeName = "bigint")]
        public long? party_master_id { get; set; }

        [Column("old_software_code_ya_id", Order = 30, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        public virtual PartyMaster? PartyMaster { get; set; }
        public virtual ItemMaster ? ItemMaster { get; set; }

        //public ICollection<IssueReceiptTransDetail>? IssueReceiptTransDetail { get; set; }

    }
}
