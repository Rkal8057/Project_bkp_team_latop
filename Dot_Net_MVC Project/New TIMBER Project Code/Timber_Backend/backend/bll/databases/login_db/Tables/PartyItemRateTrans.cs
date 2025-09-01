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
    public class PartyItemRateTrans
    {

        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("pname", Order = 1, TypeName = "text")]
        public string? pname { get; set; }

        [Column("pcode", Order = 2, TypeName = "bigint")]
        public long? pcode { get; set; }

        [ForeignKey("PartyMaster") ,Column("party_master_id", Order = 3, TypeName = "bigint")]
        public long? party_master_id { get; set; }

        [Column("item_short_name", Order = 4, TypeName = "text")]
        public string? item_short_name { get; set; }

        [Column("item_name", Order = 5, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("agr_date", Order = 6, TypeName = "datetime")]
        public DateTime? agr_date { get; set; } = DateTime.Now;

        [Column("price_sell_rate", Order = 7, TypeName = "float")]
        public double? price_sell_rate { get; set; }

        [Column("price_sell_discount_percentage", Order = 8, TypeName = "float")]
        public double? price_sell_discount_percentage { get; set; }

        [Column("price_sell_discount_amount", Order = 9, TypeName = "float")]
        public double? price_sell_discount_amount { get; set; }

        [Column("price_sell_amount_after_discount", Order = 10, TypeName = "float")]
        public double? price_sell_amount_after_discount { get; set; }

        [Column("price_sell_gst_percentage", Order = 11, TypeName = "float")]
        public double? price_sell_gst_percentage { get; set; }

        [Column("price_sell_gst_amount", Order = 12, TypeName = "float")]
        public double? price_sell_gst_amount { get; set; }

        [Column("price_sell_amount_with_gst", Order = 13, TypeName = "float")]
        public double? price_sell_amount_with_gst { get; set; }

        [Column("item_code", Order = 28, TypeName = "bigint")]
        public long? item_code { get; set; } = 0;

        [Column("delete", Order = 29, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 30, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }


        public virtual PartyMaster? PartyMaster { get; set; }

    }
}
